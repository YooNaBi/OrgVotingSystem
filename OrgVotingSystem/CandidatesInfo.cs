using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrgVotingSystem
{
    internal class CandidatesInfo
    {
        public string name { get; set; }
        public string yearlevel { get; set; }
        public string course { get; set; }
        public string position { get; set; }


        public CandidatesInfo(string Name, string YearLevel, string Course, string Position)
        {
            name = Name;
            yearlevel = YearLevel;
            course = Course;
            position = Position;
        }
    }
}
