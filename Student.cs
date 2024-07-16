using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjectAAS
{
    public class Student
    {
        private int fnumber;
        private int specialtyId;
        private string fname;
        private string mname;
        private string lname;
        private string address;
        private string phone;
        private string eMail;
        public int Id { get => fnumber; set => fnumber = value; }
        public int SpecialtyId { get => specialtyId; set => specialtyId = value; }
        public string FName { get => fname; set => fname = value; }
        public string MName { get => mname; set => mname = value; }
        public string LName { get => lname; set => lname = value; }
        public string Address { get => address; set => address = value; }
        public string Phone { get => phone; set => phone = value; }
        public string EMail { get => eMail; set => eMail = value; }


    }
}