using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    [Serializable]
    public class MyRequest
    {
        public string Header { get; set; }
        public User AuthUser { get; set; }
        public Test Test { get; set; }
        public Question Question { get; set; }
        public CompletedTest CompletedTest { get; set; }
    }
}
