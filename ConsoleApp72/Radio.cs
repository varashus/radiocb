using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp72
{
    class Radio
    {
        

        public TimeSpan ora { get; set; }
        public int adatsb { get; set; }
        public string nev { get; set; }
        public int IdoPercben => (int)ora.TotalSeconds;

        public Radio(string sor)
        {
            var r = sor.Split(';');
            ora = new TimeSpan(
                hours: int.Parse(r[0]),
                minutes: int.Parse(r[1]),
                seconds: 0);
            this.adatsb = int.Parse(r[2]);
            this.nev = r[3];

        }

    }
}
