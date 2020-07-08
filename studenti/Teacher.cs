using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace studenti
{
    public class Teacher : Person
    {
        public string firstName;
        public string lastName;
        public string birthDate;
        public int years;
        public string egn;
        public string subject;

        public Teacher(string firstName, string lastName, string birthDate, int years, string egn, string gender1, string subject)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.birthDate = birthDate;
            this.years = years;
            this.egn = egn;
            this.gender1 = gender1;
            this.subject = subject;
        }
    }
}
