using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Uzsakymas.Uzsakymai.Core.Models;

namespace Uzsakymas.Uzsakymai.Core.Repositories
{
    public class FileRepository
    {
        private string _fileLocation;
        public FileRepository(string fileLocation)
        {
            _fileLocation = fileLocation;
        }
        public List<Uzsakyti> GautiVisusUzsakymus() {
            List<Uzsakyti> uzsakymai = new List<Uzsakyti>();
            using(StreamReader sr = new StreamReader(_fileLocation))
            {
                while(!sr.EndOfStream)
                {
                    string line = sr.ReadLine();
                    if(string.IsNullOrEmpty(line))
                    {
                        break;
                    }
                    string[] foo = line.Split(",");
                    uzsakymai.Add(new Uzsakyti(int.Parse(foo[0]), foo[1], int.Parse(foo[2]), double.Parse(foo[3], CultureInfo.InvariantCulture), DateOnly.Parse(foo[4])));
                }
            }
            return uzsakymai;
        }
        public void RasytiUzsakymusIFaila(List<Uzsakyti> uzsakymai)
        {
            using(StreamWriter sw = new StreamWriter(_fileLocation))
            {
                foreach(Uzsakyti u in uzsakymai)
                {
                    sw.WriteLine($"{u.UzsakymoNumeris},{u.KlientoVardas},{u.PrekiuKiekis},{u.BendraSuma},{u.UzsakymoData}");
                }
                sw.Close();
            }
        }
    }
}
