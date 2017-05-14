using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace _123456.Models
{
    public class Customer
    {
        public int Id { get; set; }

        public string ForeName { get; set; }
        public string Surname { get; set; }
        public byte[] Image { get; set; }
        public string Telephone { get; set; }

        [Required]
        public string Email { get; set; }
    }
}