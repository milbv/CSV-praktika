﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Studentai.Core.Models
{
    public class Studentas
    {
        public string  Vardas { get; set; }
        public string Pavarde { get; set; }
        public int Amzius { get; set; }
        public double Vidurkis { get; set; }

        public Studentas(string vardas, string pavarde, int amzius, double vidurkis)
        {
            Vardas = vardas;
            Pavarde = pavarde;
            Amzius = amzius;
            Vidurkis = vidurkis;
        }
        public Studentas()
        {

        }

    }
}
