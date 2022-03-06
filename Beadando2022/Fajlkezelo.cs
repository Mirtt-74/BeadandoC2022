using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Beadando2022
{
    interface IFajl
    {
        void FajlBeolvasas(string s);
    }

    class Adatok
    {
        public string tanarneve;
        public DateTime ido;
        public DateTime foglalasideje;

    }

    class AdatFeldolgozas:IFajl
    {
        public List<Adatok> adatok = new List<Adatok>();

        public AdatFeldolgozas() 
        {
          
        }

        //public bool Vanilyentanar(string nev)
        //{
        //    bool volt = false;
        //    int i = 0;

        //    while (nev != adatok[i].tanarneve && i < AdatokSzama() - 1)
        //    {
        //        i++;
        //    }

        //    if (i < AdatokSzama() - 1)
        //    {
        //        volt = true;
        //    }
        //    return volt;
        //}

        public string TanarKeres(string nev)
        {
            int db = 0;
            string ki;
   
            for (int i = 0; i < AdatokSzama() - 1; i++)
            {
                if (nev == adatok[i].tanarneve) db++;
            }

            if (db == 0)
            {
                ki = "A megadott néven nincs időpontfoglalás";
            }
            else
            {
                ki = nev + " néven " + db.ToString() + " időpontfoglalás van.";
            }
            return ki;
        }

        public int AdatokSzama()
        {
            return adatok.Count;
        }

        public void FajlBeolvasas(string fajlnev)
        {
            string sor;

            using (StreamReader f = new StreamReader(fajlnev))
            {
                while (!f.EndOfStream)
                {
                    sor = f.ReadLine();
                    var szo = sor.Split(' ');
                    //int len = adatok.Count;

                    Adatok adat = new Adatok();

                    adat.tanarneve = szo[0] + " " + szo[1];
                    adat.ido = DateTime.Parse(szo[2]);
                    szo[3] = szo[3].Replace("-", " ");
                    adat.foglalasideje = DateTime.Parse(szo[3]);

                    adatok.Add(adat);
                }
            }
        }
        
    }
}
