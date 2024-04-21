using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    [Serializable]
    public class AnsweredQuestion
    {
        public int Id { get; set; }
        public int CompletedTestId { get; set; }
        public bool IsTextBased { get; set; }
        public string TextAnswer { get; set; }
        public int VarAnswer { get; set; }
        public bool IsCorrect { get; set; }
        public string Name { get; set; }

        public override string ToString()
        {
            return Name;
        }
    }
}
