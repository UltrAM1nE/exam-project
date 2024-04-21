using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Net.Sockets;
using System.Net;
using System.Runtime.Remoting.Messaging;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data;
using Models;

namespace Server
{
    internal class Server
    {
        static async Task Main(string[] args)
        {
            Console.Title = "Testing System - Server";

            int port = 9001;
            IPAddress ipAddress = IPAddress.Parse("127.0.0.1"); ;
            IPEndPoint ep;
            TcpListener listener;
            List<Test> tests = new List<Test>();
            BinaryFormatter bf = new BinaryFormatter();
            string connStr = ConfigurationManager.ConnectionStrings["Default"]
                .ConnectionString;
            SqlConnection conn = new SqlConnection(connStr);

            Console.WriteLine("Press Y if you wish to use custom IP and port.");
            Console.WriteLine("Press any other key to use default IP and port.");
            if (Console.ReadKey(true).Key == ConsoleKey.Y)
            {
                try
                {
                    Console.Write("\nEnter IP address> ");
                    ipAddress = IPAddress.Parse(Console.ReadLine());
                    Console.Write("\nEnter port> ");
                    port = int.Parse(Console.ReadLine());
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"\n[{DateTime.Now.ToLongTimeString()}]Runtime error: " + ex.Message);
                    return;
                }
            }

            ep = new IPEndPoint(ipAddress, port);
            listener = new TcpListener(ep);
            listener.Start();
            Console.WriteLine($"\n\n[{DateTime.Now.ToLongTimeString()}] Server started.\n");

            try
            {
                while(true)
                {
                    TcpClient acceptor = await listener.AcceptTcpClientAsync();
                    NetworkStream ns = acceptor.GetStream();
                    MyRequest request = (MyRequest)bf.Deserialize(ns);

                    switch(request.Header)
                    {
                        case "AUTH":
                            User user = request.AuthUser;
                            string login = user.Login;
                            string pass = user.Password;
                            string query = string.Empty;
                            bool check = false;
                            string message = string.Empty;

                            conn.Open();
                            if(user.IsTeacher)
                                query = $"select * from Teachers " +
                                $"where Login = @login";
                            else
                                query = $"select * from Users " +
                                $"where Login = @login";
                            using (var cmd = new SqlCommand(query, conn))
                            {
                                cmd.Parameters.AddWithValue("@login", login);
                                using (var reader = await cmd.ExecuteReaderAsync())
                                {
                                    if (await reader.ReadAsync())
                                    {
                                        if (user.IsTeacher)
                                            query = $"select * from Teachers " +
                                        $"where Login = @login and Password = @pass";
                                        else
                                            query = $"select * from Users " +
                                            $"where Login = @login and Password = @pass";
                                        using (var tempCmd = new SqlCommand(query, conn))
                                        {
                                            tempCmd.Parameters.AddWithValue("@login", login);
                                            tempCmd.Parameters.AddWithValue("@pass", pass);
                                            using (var tempReader = await tempCmd.ExecuteReaderAsync())
                                            {
                                                if (await tempReader.ReadAsync())
                                                {
                                                    message = "SUCCESS-AUTH";
                                                    check = true;
                                                }
                                                else
                                                    message = "FAILURE";
                                            }
                                        }
                                    }
                                    else
                                    {
                                        if(user.IsTeacher)
                                            query = $"insert Teachers values (@login, @pass)";
                                        else
                                            query = $"insert Users values (@login, @pass)";
                                        using (var tempCmd = new SqlCommand(query, conn))
                                        {
                                            tempCmd.Parameters.AddWithValue("@login", login);
                                            tempCmd.Parameters.AddWithValue("@pass", pass);
                                            try { await tempCmd.ExecuteNonQueryAsync(); message = "SUCCESS-CREATE"; check = true; }
                                            catch (Exception ex)
                                            {
                                                Console.WriteLine($"[{DateTime.Now.ToLongTimeString()}] " +
                                                    $"User-triggered exception during ExecuteNonQuery()/Registering:\n{ex.Message}\n");
                                            }
                                        }
                                    }
                                }
                            }
                            if (check)
                            {
                                var authResponce = new MyResponce()
                                {
                                    ServerMessage = message,
                                    UserName = login,
                                };
                                bf.Serialize(ns, authResponce);
                            }
                            else
                            {
                                var authResponce = new MyResponce()
                                {
                                    ServerMessage = message
                                };
                                bf.Serialize(ns, authResponce);
                            }

                            Console.WriteLine($"[{DateTime.Now.ToLongTimeString()}] Auth request: " +
                                $"{login} | {pass} | IsTeacher: {user.IsTeacher} => {message}\n");
                            break;
                        case "CREATE-TEST":
                            Test newTest = request.Test;
                            check = false;
                            message = string.Empty;
                            query = "insert Tests values (@name, @teacherName, @isAvaivable)";
                            conn.Open();
                            using (var cmd = new SqlCommand(query, conn))
                            {
                                cmd.Parameters.AddWithValue("name", newTest.Name);
                                cmd.Parameters.AddWithValue("teacherName", newTest.TeacherName);
                                cmd.Parameters.AddWithValue("isAvaivable", newTest.IsAvaivable);
                                try { await cmd.ExecuteNonQueryAsync(); message = "CREATED"; check = true; }
                                catch (Exception ex)
                                {
                                    Console.WriteLine($"[{DateTime.Now.ToLongTimeString()}] " +
                                        $"User-triggered exception during ExecuteNonQuery()/CreateTest:\n{ex.Message}\n");
                                }
                            }
                            if (!check)
                                message = "FAILURE";
                            var createTestResponce = new MyResponce()
                            {
                                ServerMessage = message
                            };
                            bf.Serialize(ns, createTestResponce);

                            Console.WriteLine($"[{DateTime.Now.ToLongTimeString()}] CreateTest request from {newTest.TeacherName} => {message}\n");
                            break;
                        case "CREATE-QUESTION":
                            Question question = request.Question;
                            check = false;
                            message = string.Empty;
                            if(question.IsTextBased)
                            {
                                query = "insert Questions (Name, TestId, QuestionText, IsTextBased, TextAnswer) " +
                                    "values (@name, @testId, @questionText, @isTextBased, @textAnswer)";
                                conn.Open();
                                using (var cmd = new SqlCommand(query, conn))
                                {
                                    cmd.Parameters.AddWithValue("name", question.Name);
                                    cmd.Parameters.AddWithValue("testId", question.TestId);
                                    cmd.Parameters.AddWithValue("questionText", question.QuestionText);
                                    cmd.Parameters.AddWithValue("isTextBased", question.IsTextBased);
                                    cmd.Parameters.AddWithValue("textAnswer", question.TextAnswer);
                                    try { await cmd.ExecuteNonQueryAsync(); message = "CREATED"; check = true; }
                                    catch (Exception ex)
                                    {
                                        Console.WriteLine($"[{DateTime.Now.ToLongTimeString()}] " +
                                            $"User-triggered exception during ExecuteNonQuery()/CreateQuestion:\n{ex.Message}\n");
                                    }
                                }
                            }
                            else
                            {
                                query = "insert Questions (Name, TestId, QuestionText, IsTextBased, Var1Answer, " +
                                    "Var2Answer, Var3Answer, Var4Answer, Var5Answer, Var6Answer, CorrectVar) " +
                                    "values (@name, @testId, @questionText, @isTextBased, " +
                                    "@var1Answer, @var2Answer, @var3Answer, @var4Answer, @var5Answer, @var6Answer, @correctVar)";
                                conn.Open();
                                using (var cmd = new SqlCommand(query, conn))
                                {
                                    cmd.Parameters.AddWithValue("name", question.Name);
                                    cmd.Parameters.AddWithValue("testId", question.TestId);
                                    cmd.Parameters.AddWithValue("questionText", question.QuestionText);
                                    cmd.Parameters.AddWithValue("isTextBased", question.IsTextBased);
                                    cmd.Parameters.AddWithValue("var1Answer", question.Var1Answer);
                                    cmd.Parameters.AddWithValue("var2Answer", question.Var2Answer);
                                    cmd.Parameters.AddWithValue("var3Answer", question.Var3Answer);
                                    cmd.Parameters.AddWithValue("var4Answer", question.Var4Answer);
                                    cmd.Parameters.AddWithValue("var5Answer", question.Var5Answer);
                                    cmd.Parameters.AddWithValue("var6Answer", question.Var6Answer);
                                    cmd.Parameters.AddWithValue("correctVar", question.CorrectVar);
                                    try { await cmd.ExecuteNonQueryAsync(); message = "CREATED"; check = true; }
                                    catch (Exception ex)
                                    {
                                        Console.WriteLine($"[{DateTime.Now.ToLongTimeString()}] " +
                                            $"User-triggered exception during ExecuteNonQuery()/CreateQuestion:\n{ex.Message}\n");
                                    }
                                }
                            }
                            if (!check)
                                message = "FAILURE";
                            var createQuestionResponce = new MyResponce()
                            {
                                ServerMessage = message
                            };
                            bf.Serialize(ns, createQuestionResponce);

                            Console.WriteLine($"[{DateTime.Now.ToLongTimeString()}] CreateQuestion request | Name: {question.Name} => {message}\n");
                            break;
                        case "GET":
                            tests = new List<Test>();
                            query = "select * from Tests";
                            if (!request.AuthUser.IsTeacher)
                                query = "select * from Tests where IsAvaivable = 1";
                            conn.Open();
                            using (var cmd = new SqlCommand(query, conn))
                            {
                                using (var reader = await cmd.ExecuteReaderAsync())
                                {
                                    while (await reader.ReadAsync())
                                    {
                                        Test getTest = new Test()
                                        {
                                            Id = reader.GetInt32(0),
                                            Name = reader.GetString(1),
                                            TeacherName = reader.GetString(2),
                                            IsAvaivable = reader.GetBoolean(3),
                                            Questions = new List<Question>()
                                        };
                                        query = "select * from Questions where TestId = @id";
                                        using (var tempCmd = new SqlCommand(query, conn))
                                        {
                                            tempCmd.Parameters.AddWithValue("id", getTest.Id);
                                            using(var tempReader = await tempCmd.ExecuteReaderAsync())
                                            {
                                                while(await tempReader.ReadAsync())
                                                {
                                                    string textAnswer = null;
                                                    string var1 = null;
                                                    string var2 = null;
                                                    string var3 = null;
                                                    string var4 = null;
                                                    string var5 = null;
                                                    string var6 = null;
                                                    int correctVar = 0;

                                                    if (!tempReader.IsDBNull(5))
                                                    {
                                                        textAnswer = tempReader.GetString(5);
                                                    }
                                                    if (!tempReader.IsDBNull(6))
                                                    {
                                                        var1 = tempReader.GetString(6);
                                                    }
                                                    if (!tempReader.IsDBNull(7))
                                                    {
                                                        var2 = tempReader.GetString(7);
                                                    }
                                                    if (!tempReader.IsDBNull(8))
                                                    {
                                                        var3 = tempReader.GetString(8);
                                                    }
                                                    if (!tempReader.IsDBNull(9))
                                                    {
                                                        var4 = tempReader.GetString(9);
                                                    }
                                                    if (!tempReader.IsDBNull(10))
                                                    {
                                                        var5 = tempReader.GetString(10);
                                                    }
                                                    if (!tempReader.IsDBNull(11))
                                                    {
                                                        var6 = tempReader.GetString(11);
                                                    }
                                                    if (!tempReader.IsDBNull(12))
                                                    {
                                                        correctVar = tempReader.GetInt32(12);
                                                    }

                                                    getTest.Questions.Add(new Question()
                                                    {
                                                        Id = tempReader.GetInt32(0),
                                                        Name = tempReader.GetString(1),
                                                        TestId = tempReader.GetInt32(2),
                                                        QuestionText = tempReader.GetString(3),
                                                        IsTextBased = tempReader.GetBoolean(4),
                                                        TextAnswer = textAnswer,
                                                        Var1Answer = var1,
                                                        Var2Answer = var2,
                                                        Var3Answer = var3,
                                                        Var4Answer = var4,
                                                        Var5Answer = var5,
                                                        Var6Answer = var6,
                                                        CorrectVar = correctVar
                                                    });
                                                    
                                                }
                                            }
                                        }
                                        tests.Add(getTest);
                                    }
                                }
                            }

                            var getResponce = new MyResponce()
                            {
                                Tests = tests
                            };
                            bf.Serialize(ns, getResponce);
                            break;
                        case "GET-COMPLETED":
                            var completedTests = new List<CompletedTest>();
                            query = "select * from CompletedTests";
                            conn.Open();
                            using (var cmd = new SqlCommand(query, conn))
                            {
                                using (var reader = await cmd.ExecuteReaderAsync())
                                {
                                    while (await reader.ReadAsync())
                                    {
                                        CompletedTest getTest = new CompletedTest()
                                        {
                                            Id = reader.GetInt32(0),
                                            TestId = reader.GetInt32(1),
                                            UserLogin = reader.GetString(2),
                                            Correct = reader.GetInt32(3),
                                            Name = reader.GetString(4),
                                            Questions = new List<AnsweredQuestion>()
                                        };
                                        query = "select * from AnsweredQuestions where CompletedTestId = @id";
                                        using (var tempCmd = new SqlCommand(query, conn))
                                        {
                                            tempCmd.Parameters.AddWithValue("id", getTest.Id);
                                            using (var tempReader = await tempCmd.ExecuteReaderAsync())
                                            {
                                                while (await tempReader.ReadAsync())
                                                {
                                                    string textAnswer = null;
                                                    int varAnswer = 0;

                                                    if (!tempReader.IsDBNull(3))
                                                    {
                                                        textAnswer = tempReader.GetString(3);
                                                    }
                                                    if (!tempReader.IsDBNull(4))
                                                    {
                                                        varAnswer = tempReader.GetInt32(4);
                                                    }

                                                    getTest.Questions.Add(new AnsweredQuestion()
                                                    {
                                                        Id = tempReader.GetInt32(0),
                                                        CompletedTestId = tempReader.GetInt32(1),
                                                        IsTextBased = tempReader.GetBoolean(2),
                                                        TextAnswer = textAnswer,
                                                        VarAnswer = varAnswer,
                                                        IsCorrect = tempReader.GetBoolean(5),
                                                        Name = tempReader.GetString(6)
                                                    });

                                                }
                                            }
                                        }
                                        completedTests.Add(getTest);
                                    }
                                }
                            }

                            var getComResponce = new MyResponce()
                            {
                                CompletedTests = completedTests
                            };
                            bf.Serialize(ns, getComResponce);
                            break;
                        case "SET-AVAIVABILITY":
                            Test updTest = request.Test;
                            check = false;
                            query = "update Tests set IsAvaivable = @status where Id = @id";
                            message = string.Empty;
                            conn.Open();
                            using (var cmd = new SqlCommand(query, conn))
                            {
                                cmd.Parameters.AddWithValue("status", updTest.IsAvaivable);
                                cmd.Parameters.AddWithValue("id", updTest.Id);
                                try { await cmd.ExecuteNonQueryAsync(); message = "SUCCESS"; check = true; }
                                catch (Exception ex)
                                {
                                    Console.WriteLine($"[{DateTime.Now.ToLongTimeString()}] " +
                                        $"User-triggered exception during ExecuteNonQuery()/SetAvailability:\n{ex.Message}\n");
                                }
                            }
                            if (!check)
                                message = "FAILURE";

                            var setResponce = new MyResponce()
                            {
                                ServerMessage = message,
                            };
                            bf.Serialize(ns, setResponce);

                            Console.WriteLine($"[{DateTime.Now.ToLongTimeString()}] SetAvailability request | New status: {updTest.IsAvaivable} => {message}\n");
                            break;
                        case "REMOVE-QUESTION":
                            Question remQuestion = request.Question;
                            check = false;
                            message = string.Empty;
                            query = "delete from Questions where Id = @id";
                            conn.Open();
                            using (var cmd = new SqlCommand(query, conn))
                            {
                                cmd.Parameters.AddWithValue("id", remQuestion.Id);
                                try { await cmd.ExecuteNonQueryAsync(); message = "SUCCESS"; check = true; }
                                catch (Exception ex)
                                {
                                    Console.WriteLine($"[{DateTime.Now.ToLongTimeString()}] " +
                                        $"User-triggered exception during ExecuteNonQuery()/RemoveQuestion:\n{ex.Message}\n");
                                }
                            }
                            if (!check)
                                message = "FAILURE";

                            var remQuestionResponce = new MyResponce()
                            {
                                ServerMessage = message,
                            };
                            bf.Serialize(ns, remQuestionResponce);

                            Console.WriteLine($"[{DateTime.Now.ToLongTimeString()}] RemoveQuestion request => {message}\n");
                            break;
                        case "REMOVE-TEST":
                            Test remTest = request.Test;
                            check = false;
                            message = string.Empty;
                            query = "delete from Questions where TestId = @testId";
                            conn.Open();
                            using (var cmd = new SqlCommand(query, conn))
                            {
                                cmd.Parameters.AddWithValue("testId", remTest.Id);
                                try { await cmd.ExecuteNonQueryAsync(); message = "SUCCESS"; check = true; }
                                catch (Exception ex)
                                {
                                    Console.WriteLine($"[{DateTime.Now.ToLongTimeString()}] " +
                                        $"User-triggered exception during ExecuteNonQuery()/RemoveQuestion(before RemoveTest):\n{ex.Message}\n");
                                }
                            }
                            query = "delete from Tests where Id = @id";
                            using (var cmd = new SqlCommand(query, conn))
                            {
                                cmd.Parameters.AddWithValue("id", remTest.Id);
                                try { await cmd.ExecuteNonQueryAsync(); message = "SUCCESS"; check = true; }
                                catch (Exception ex)
                                {
                                    Console.WriteLine($"[{DateTime.Now.ToLongTimeString()}] " +
                                        $"User-triggered exception during ExecuteNonQuery()/RemoveTest:\n{ex.Message}\n");
                                }
                            }
                            if (!check)
                                message = "FAILURE";

                            var remTestResponce = new MyResponce()
                            {
                                ServerMessage = message,
                            };
                            bf.Serialize(ns, remTestResponce);

                            Console.WriteLine($"[{DateTime.Now.ToLongTimeString()}] RemoveTest request => {message}\n");
                            break;
                        case "COMPLETE-TEST":
                            CompletedTest ct = request.CompletedTest;
                            check = false;
                            message = string.Empty;
                            query = "insert CompletedTests values (@testId, @userLogin, @correct, @name)";
                            conn.Open();
                            using (var cmd = new SqlCommand(query, conn))
                            {
                                cmd.Parameters.AddWithValue("testId", ct.TestId);
                                cmd.Parameters.AddWithValue("userLogin", ct.UserLogin);
                                cmd.Parameters.AddWithValue("correct", ct.Correct);
                                cmd.Parameters.AddWithValue("name", ct.Name);
                                try { await cmd.ExecuteNonQueryAsync(); message = "SUCCESS"; check = true; }
                                catch (Exception ex)
                                {
                                    Console.WriteLine($"[{DateTime.Now.ToLongTimeString()}] " +
                                        $"User-triggered exception during ExecuteNonQuery()/CompleteTest:\n{ex.Message}\n");
                                }
                            }
                            query = "insert AnsweredQuestions values (@id, @comTestId, @isTextBased, @textAnswer, @varAnswer, @isCorrect, @name)";
                            foreach (var q in ct.Questions)
                            {
                                using (var cmd = new SqlCommand("select Id from CompletedTests where" +
                                    " TestId = @testId and UserLogin = @userLogin", conn))
                                {
                                    cmd.Parameters.AddWithValue("testId", ct.TestId);
                                    cmd.Parameters.AddWithValue("userLogin", ct.UserLogin);
                                    using (var reader = await cmd.ExecuteReaderAsync())
                                    {
                                        if (await reader.ReadAsync())
                                            q.CompletedTestId = reader.GetInt32(0);
                                    }
                                }
                                using (var cmd = new SqlCommand(query, conn))
                                {
                                    cmd.Parameters.AddWithValue("id", q.Id);
                                    cmd.Parameters.AddWithValue("comTestId", q.CompletedTestId);
                                    cmd.Parameters.AddWithValue("isTextBased", q.IsTextBased);
                                    cmd.Parameters.AddWithValue("textAnswer", q.TextAnswer);
                                    cmd.Parameters.AddWithValue("varAnswer", q.VarAnswer);
                                    cmd.Parameters.AddWithValue("isCorrect", q.IsCorrect);
                                    cmd.Parameters.AddWithValue("name", q.Name);
                                    try { await cmd.ExecuteNonQueryAsync(); message = "SUCCESS"; }
                                    catch (Exception ex)
                                    {
                                        Console.WriteLine($"[{DateTime.Now.ToLongTimeString()}] " +
                                            $"User-triggered exception during ExecuteNonQuery()/CompleteTest(AddQuestion):\n{ex.Message}\n");
                                        check = false;
                                    }
                                }
                            }

                            if (!check)
                                message = "FAILURE";

                            var comTestResponce = new MyResponce()
                            {
                                ServerMessage = message,
                            };
                            bf.Serialize(ns, comTestResponce);

                            Console.WriteLine($"[{DateTime.Now.ToLongTimeString()}] CompleteTest request => {message}\n");
                            break;
                    }

                    conn.Close();
                    acceptor.Close();
                    ns.Close();
                }

                
            }
            catch (Exception ex)
            {
                Console.WriteLine($"[{DateTime.Now.ToLongTimeString()}]Runtime error: " + ex.Message);
                return;
            }
            finally
            {
                if (conn.State == ConnectionState.Open)
                    conn.Close();
            }
        }
    }
}
