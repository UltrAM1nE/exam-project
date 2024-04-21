using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    [Serializable]
    public class CompletedTest
    {
        public int Id { get; set; }
        public int TestId { get; set; }
        public string UserLogin { get; set; }
        public int Correct {  get; set; }
        public string Name { get; set; }

        public List<AnsweredQuestion> Questions { get; set; }

        public override string ToString()
        {
            return Name + " | " + UserLogin;
        }
    }
}
