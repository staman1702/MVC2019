using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Poklon.Models
{
    public class Poklon
    {
        [Key]
        public int Id { get; set; }
        
        [StringLength(25, ErrorMessage ="Naziv ne smije biti duži od 25")]
        public string Naziv { get; set; }

        public float Cijena { get; set; }

        public bool Naruceno { get; set; }


    }
}