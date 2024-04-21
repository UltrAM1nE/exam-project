using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    [Serializable]
    public class Question
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int TestId { get; set; }
        public string QuestionText { get; set; }
        public bool IsTextBased { get; set; }
        public string TextAnswer { get; set; }
        public string Var1Answer { get; set; }
        public string Var2Answer { get; set; }
        public string Var3Answer { get; set; }
        public string Var4Answer { get; set; }
        public string Var5Answer { get; set; }
        public string Var6Answer { get; set; }
        public int CorrectVar { get; set; }

        public override string ToString()
        {
            return Name;
        }
    }
}
