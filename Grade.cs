using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Xml.Linq;

namespace ProjectAAS
{
    public class Grade
    {
        private int fnumber;
        private int subjectid;
        private int finalgrade;
        public int Id { get => fnumber; set => fnumber = value; }
        public int SubjectId { get => subjectid; set => subjectid = value; }
        public int FinalGrade { get => finalgrade; set => finalgrade = value; }
    }
}