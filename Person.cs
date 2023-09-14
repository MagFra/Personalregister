using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Personalregister
{
    internal class Person
    {
        private string forNamn;
        public string ForNamn { get => forNamn;  set => forNamn = VerifyNamn(value); }

        private string efterNamn;
        public string EfterNamn { get => efterNamn; set => efterNamn = VerifyNamn(value); }

        private int lon;
        public int Lon { get => lon; set => lon = VerifyLon(value); }

        private int alder;
        public int Alder { get => alder; set => alder = VerifyAlder(value); }




        public Person(string forNamn, string efterNamn,int lon)
        {
            this.forNamn = forNamn;   //VerifyNamn(forNamn);
            this.efterNamn = efterNamn;    //VerifyNamn(efterNamn);
            this.lon = VerifyLon(lon);
        }
        public Person(string forNamn, string efterNamn, int lon, int alder)
        {
            this.forNamn = VerifyNamn(forNamn);
            this.efterNamn = VerifyNamn(efterNamn);
            this.lon = VerifyLon(lon);
            this.alder = alder;
        }

        public string GetFullName() => $"{this.forNamn} {this.efterNamn}";

        public void OkaAlder() { this.alder++; }

        private static string VerifyNamn(string namn)
        {
            // return namn;
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
