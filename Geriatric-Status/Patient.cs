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

        private string name;

        private string surname;

        private string otchestvo;

        private int overallResilience;

        public DateTime BirthDate { get => birthDate; set => birthDate = value; }
        public string Name { get => name; set => name = value; }
        public string Surname { get => surname; set => surname = value; }
        public string Otchestvo { get => otchestvo; set => otchestvo = value; }
        public int OverallResilience { get => overallResilience; set => overallResilience = value; }

        



    }
}
