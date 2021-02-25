using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemTwo_CompilationError
{
    class DirectReport : Employee
        
    {
        private static int eID;
        private static string eName;
        private static int eLevel;
        private static DateTime eDoJ;
        
        public int id { get; set;}
   
        public Employee ReportsTo { get; set; }
        public string ProjectCode { get; set; }

        public DateTime dt { get; set; }

        public string branch { get; set; }

        public string status { get; set; }

        public DirectReport(int id, Employee managerEmpObj, string pCode, DateTime dt, string status, string branch) : base(eID, eName, eLevel, eDoJ)
        {
            ReportsTo = managerEmpObj;
            ProjectCode = pCode;
        }

        public DirectReport(int eID, string eName, int eLevel, DateTime eDoJ, object p, string v) : base(eID, eName, eLevel, eDoJ)
        {
        }
    }
}
