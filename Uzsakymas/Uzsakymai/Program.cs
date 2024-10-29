using Uzsakymas.Uzsakymai.Core.Models;
using Uzsakymas.Uzsakymai.Core.Repositories;

namespace Uzsakymas.Uzsakymai
{
    public class Program
    {
        public static void Main(string[] args) 
        {
            Filtravimas();
        }
        public static void Filtravimas()
        {
            FileRepository fileRepository = new FileRepository("Uzsakymai.csv");
            List<Uzsakyti> visiUzsakymai = fileRepository.GautiVisusUzsakymus();
            DateOnly diena = new DateOnly(2024,10,22);
            for(int i = 0; i < visiUzsakymai.Count; i++)
            {
                if (visiUzsakymai[i].UzsakymoData.Day >= diena.Day - 7 && visiUzsakymai[i].BendraSuma < 50)
                {
                    Console.WriteLine($"Uzsakymas {visiUzsakymai[i].UzsakymoNumeris} is kliento {visiUzsakymai[i].KlientoVardas} yra prioritetinis");   
                } else if (visiUzsakymai[i].PrekiuKiekis >= 10 && visiUzsakymai[i].BendraSuma < 50)
                {
                    Console.WriteLine($"Uzsakymas {visiUzsakymai[i].UzsakymoNumeris} is kliento {visiUzsakymai[i].KlientoVardas} turi dideli kieki, bet zema verte");
                } else
                {
                    Console.WriteLine($"Uzsakymas {visiUzsakymai[i].UzsakymoNumeris} is kliento {visiUzsakymai[i].KlientoVardas} neatitinka specialiu kriteriju ir nera prioritetinis");
                }
            }
        }
        


    }
}
