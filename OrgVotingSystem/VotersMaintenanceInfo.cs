using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrgVotingSystem
{
    internal class VotersMaintenanceInfo
    {
        public string studentID { get; set; }
        public string Fname { get; set; }
        public string course { get; set; }
        public string yearlevel { get; set; }
       
        


        public VotersMaintenanceInfo(string StudentID, string FullName, string Course, string YearLevel)
        {
            studentID = StudentID;
            Fname = FullName;
            course = Course;
            yearlevel = YearLevel;
            
            
        }
    }
}
