using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geriatric_Status
{
    class Patient
    {
        private DateTime birthDate;

        private string name = "";

        private string surname = "";

        private string otchestvo = "";

        public DateTime BirthDate
        {
            get
            {
                return birthDate;
            }

            set
            {
                birthDate = value;
            }
        }

        public string Name
        {
            get
            {
                return name;
            }

            set
            {
                name = value;
            }
        }


        public string Surname
        {
            get
            {
                return surname;
            }

            set
            {
                surname = value;
            }
        }

        public string Otchestvo
        {
            get
            {
                return otchestvo;
            }

            set
            {
                otchestvo = value;
            }
        }




       /* public Patient(DateTime date, string name, string surname, string otchestvo)
        {
            this.birthDate = date;
            this.name = name;
            this.surname = surname;
            this.otchestvo = otchestvo;
        }*/


    }
}
