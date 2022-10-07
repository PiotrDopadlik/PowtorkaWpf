using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PowtorkaWpf
{
    public class Pytanie
    {
        public int numerPytania {get; set;}
        public string tresc { get; set; }
        public List<string> odpowiedzi { get; set; }
        public int odpowiedzOk { get; set; }

        public Pytanie(int numerPytania, string tresc, List<string> odpowiedzi, int odpowiedzOk)
        {
            this.numerPytania = numerPytania;
            this.tresc = tresc;
            this.odpowiedzi = odpowiedzi;
            this.odpowiedzOk = odpowiedzOk;
        }
    }
}
