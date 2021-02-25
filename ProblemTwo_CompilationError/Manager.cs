using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemTwo_CompilationError
{
    class Manager
    {
        private static int eID;
        private static string eName;
        private static int eLevel;
        private static DateTime eDoJ;
        public List<Employee> DirectReports { get; set; }
        public string CostCode { get; set; }
        public int roll;
        private int v1;
        private string v2;
        private int v3;
        private DateTime dateTime;
        private List<Employee> lstDirectReports;
        private string v4;

        public Manager(int roll,List<Employee> drEmployeesLst, string cCode, DateTime dt, string status, string branch) :base(eID, eName, eLevel, eDoJ)
        {
            DirectReports = drEmployeesLst;
            CostCode = cCode;

        }

        public Manager(int v1, string v2, int v3, DateTime dateTime, List<Employee> lstDirectReports, string v4)
        {
            this.v1 = v1;
            this.v2 = v2;
            this.v3 = v3;
            this.dateTime = dateTime;
            this.lstDirectReports = lstDirectReports;
            this.v4 = v4;
        }

        public List<string> GetMyReports()
        {
            return DirectReports.Select(x => x.EmpName).ToList();
        }

    }
}
