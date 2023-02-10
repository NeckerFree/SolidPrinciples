using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static SP.Validation.Models.Enumerations;

namespace SP.Validation.Models
{
        public class Employee
    {
        public string? Name { get; set; }
        public Gender Gender { get; set; }
        public Position Position { get; set; }
    }
}
