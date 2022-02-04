using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MyFirstApplication.Models
{
    public class StringConcate
    {
        public int Id { get; set; }

        [Required(ErrorMessage="Please Enter FirstName")]
        public string FirstName { get; set; }
        [StringLength(7, ErrorMessage = "Last Name must not be more than 7 char")]
        public string LastName { get; set; }
    }
}