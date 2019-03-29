﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace modeli_uvod.Models
{
    public class Osoba
    {
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public string Email { get; set; }
        public DateTime? DatumRodjenja { get; set; } //upitnik dozvoljava null vrijednosti
    }
}