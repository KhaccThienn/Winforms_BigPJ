using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BigPJV2.Models
{
    public class EmployeeReport
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
        public string Gender { get; set; }
        public System.DateTime BirthDay { get; set; }
        public string Level { get; set; }
        public string Department { get; set; }
    }
}
