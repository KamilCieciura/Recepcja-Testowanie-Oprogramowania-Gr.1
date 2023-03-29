using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patient_handling
{
    public class Patient
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public string PhoneNumber { get; set; }
        public string EmailAddress { get; set; }
        public string ResidentialAddress { get; set; }
        public string PESEL { get; set; }
        public string Status { get; set; }
    }
}
