using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrzedSprawdzianem
{
    public class ksiazka
    {
        public string ?tytul { get; set; }
        public string ?autor { get; set; }
        public ksiazka(string tytul, string autor) {
            tytul = this.tytul;
            autor = this.autor; 
        }
        public override string ToString()
        {
            return tytul + " " + autor;
        }
        

    }
}
