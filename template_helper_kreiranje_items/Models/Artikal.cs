﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace _template_helper_kreiranje_items.Models
{
    public class Artikal
    {
        public string Kategorija { get; set; }
        public string Naziv { get; set; }
        public decimal Cijena { get; set; }
        public int Kolicina { get; set; }

    }
}