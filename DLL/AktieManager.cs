using DLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DLL_Fortsat
{
    public class AktieManager
    {
        public static List<Aktie> AktieListe = new();

        public AktieManager()
        {

        }

        public void TilføjAktie(Aktie a) 
        {
            AktieListe.Add(a);
        }

        public int TotalAfkast() => AktieListe.Sum(aktie => aktie.Afkast());
    }
}
