using Studentai.Core.Models;
using Studentai.Core.Repositories;
using System;
namespace Studentai
{
    //1 uzduotis
    public class Program
    {
        public static void Main(string[] args)
        {
            FileRepository fileRepository = new FileRepository("Studentai.csv");
            List<Studentas> visiStudentai = fileRepository.GautiVisusStudentus();

            Console.WriteLine("Iveskite kiek zmoniu noreite prideti: ");
            int zmoniuSkaicius = int.Parse(Console.ReadLine());
            for (int i = 0; i < zmoniuSkaicius; i++)
            {

                Console.WriteLine("Iveskite varda:");
                string vardas = Console.ReadLine();
                Console.WriteLine("Iveskite pavarde:");
                string pavarde = Console.ReadLine();
                Console.WriteLine("Iveskite amziu:");
                int amzius = int.Parse(Console.ReadLine());
                Console.WriteLine("Iveskite vidurki:");
                double vidurkis = double.Parse(Console.ReadLine());

                visiStudentai.Add(new Studentas(vardas, pavarde, amzius, vidurkis));

                fileRepository.RasytiStudentusIFaila(visiStudentai);
            }
            for (int i = 0; i < visiStudentai.Count; i++)
            {
                if (visiStudentai[i].Amzius > 20 && visiStudentai[i].Vidurkis > 7.0)
                {
                    Console.WriteLine($"Studentas {visiStudentai[i].Vardas} {visiStudentai[i].Pavarde} atitinka kriterijus");
                } else
                {
                    Console.WriteLine($"Studentas {visiStudentai[i].Vardas} {visiStudentai[i].Pavarde} neatitinka kriteriju");
                }
            }

        }
    }
}
