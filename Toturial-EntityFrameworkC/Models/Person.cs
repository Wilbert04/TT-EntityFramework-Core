using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Toturial_EntityFrameworkC.Models
{
    public class Person
    {
        [Key]
        public int personId { get; set; }
        public string name { get; set; }
        public string lastName { get; set; }

        public Person()
        {
            personId = 0;
            name = string.Empty;
            lastName = string.Empty;
        }
    }
}
