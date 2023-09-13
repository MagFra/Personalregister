using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Personalregister
{
    internal class Person
    {
        public string ForNamn { get => ForNamn; set => VerifyNamn(value); }
        public string EfterNamn { get => EfterNamn; set => VerifyNamn(value); }
        public int Lon { get => Lon; set => VerifyLon(value); }
        public int Alder { get => Alder; set => VerifyAlder(value); }

        public Person(string forNamn, string efterNamn,int lon)
        {
            ForNamn = VerifyNamn(forNamn);
            EfterNamn = VerifyNamn(efterNamn);
            Lon = VerifyLon(lon);
        }
        public Person(string forNamn, string efterNamn, int lon, int alder)
        {
            ForNamn = VerifyNamn(forNamn);
            EfterNamn = VerifyNamn(efterNamn);
            Lon = VerifyLon(lon);
            Alder = alder;
        }

        public string GetFullName() { return $"{this.ForNamn} {this.EfterNamn}"; }

        public void OkaAlder() { this.Alder++; }

        private static string VerifyNamn(string namn)
        {
            if (namn.Length == 0) 
            {
                throw new ArgumentException("Ett namn saknas!"); // ToDo: Skapa en bättre hantering av detta fel. (Be användaren att mata in igen.)
            }
            return namn.Trim();
        }

        private static int VerifyLon(int lon)
        {
            if (lon < 0)
            {
                return 0;
            }
            return lon;
        }

        private static int VerifyAlder(int alder)
        {
            if (alder < 0)
            {
                return 0;
            }
            return alder;
        }

    }
}
