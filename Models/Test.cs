using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    [Serializable]
    public class Test
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string TeacherName { get; set; }
        public bool IsAvaivable { get; set; }

        public List<Question> Questions { get; set; }

        public override string ToString()
        {
            return Name;
        }
    }
}
