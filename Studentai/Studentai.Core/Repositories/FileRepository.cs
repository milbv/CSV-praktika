using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Studentai.Core.Models;

namespace Studentai.Core.Repositories
{
    public class FileRepository
    {
        private string _fileLocation;
        public FileRepository(string fileLocation)
        {
            _fileLocation = fileLocation;
        }

        public List<Studentas> GautiVisusStudentus()
        {
            List<Studentas> studentai = new List<Studentas>();
            using (StreamReader sr = new StreamReader(_fileLocation))
            {
                while (!sr.EndOfStream)
                {
                    string line = sr.ReadLine();
                    if (string.IsNullOrEmpty(line))
                    {
                        break;
                    }
                    string[] foo = line.Split(",");
                    studentai.Add(new Studentas(foo[0], foo[1], int.Parse(foo[2]), double.Parse(foo[3], CultureInfo.InvariantCulture)));
                }
            }
            return studentai;
        }
        public void RasytiStudentusIFaila(List<Studentas> studentai)
        {
            using(StreamWriter sw = new StreamWriter(_fileLocation))
            {
                foreach(Studentas s in studentai)
                {
                    sw.WriteLine($"{s.Vardas},{s.Pavarde},{s.Amzius},{s.Vidurkis}");
                }
                sw.Close();
            }
        }
    }
}
