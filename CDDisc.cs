using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1
{
    public class CDDisc
    {
        public int ID { get; set; }
        public string Nazev { get; set; }
        public string Artist { get; set; }
        public DateTime DatumVydani { get; set; }
        public int PocetSkladeb { get; set; }
        public string Zanr { get; set; }
        public string Vydavatelstvi { get; set; }
        public DateTime DatumPridani { get; set; }
    }
}
