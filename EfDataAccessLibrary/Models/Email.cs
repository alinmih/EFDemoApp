using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace EfDataAccessLibrary.Models
{
    public class Email
    {
        public int Id { get; set; }
        [Required]
        [MaxLength(200)]
        public string EmailAddress { get; set; }


    }
}
