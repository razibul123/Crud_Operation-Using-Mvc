using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication4.Models
{
    
    
        public class Employee
        {

            public int Id { get; set; }

            [Required]
            public string Name { get; set; }

            [Required]
            public string Email { get; set; }

            [Required]
            public int Phone { get; set; }

            public string Address { get; set; }

            public string PostCode { get; set; }

            public string ZipCode { get; set; }


        }
    }

