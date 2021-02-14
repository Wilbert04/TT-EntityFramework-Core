using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Toturial_EntityFrameworkC.Models
{
    public class Student
    {
        [Key]
        public int StudentId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Name { get; internal set; }

        public Student()
        {
            StudentId = 0;
            FirstName = string.Empty;
            LastName = string.Empty;
        }
    }
}

