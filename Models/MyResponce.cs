using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    [Serializable]
    public class MyResponce
    {
        public string ServerMessage { get; set; }
        public string UserName { get; set; }
        public List<Test> Tests { get; set; }
        public List<CompletedTest> CompletedTests { get; set; }
    }
}
