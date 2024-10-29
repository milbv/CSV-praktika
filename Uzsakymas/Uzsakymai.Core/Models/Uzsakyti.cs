using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uzsakymas.Uzsakymai.Core.Models
{
    public class Uzsakyti
    {
        public int UzsakymoNumeris { get; set; }
        public string KlientoVardas { get; set; }
        public int PrekiuKiekis { get; set; }
        public double BendraSuma { get; set; }
        public DateOnly UzsakymoData { get; set; }

        public Uzsakyti(int uzsakymoNumeris, string klientoVardas, int prekiuSkaicius, double bendraSuma, DateOnly uzsakymoData)
        {
            UzsakymoNumeris = uzsakymoNumeris;
            KlientoVardas = klientoVardas;
            PrekiuKiekis = prekiuSkaicius;
            BendraSuma = bendraSuma;
            UzsakymoData = uzsakymoData;
        }
        public Uzsakyti()
        {

        }
    }
}
