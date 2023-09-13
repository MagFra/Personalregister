using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Personalregister
{
    internal class PersonalLista
    {
        private List<Person> personal = new List<Person>(0);

        // public PersonalLista() { }

        public void skapaNyPerson(string forNamn, string efterNamn, int lon)
        {
            this.personal.Append(new Person(forNamn, efterNamn,lon));
        }
        public void skapaNyPerson(string forNamn, string efterNamn, int lon, int alder)
        {
            this.personal.Append(new Person(forNamn, efterNamn, lon, alder));
        }

        public string[] SkrivUtLista()
        {
            string[] result = new string[personal.Count];

            for (int i = 0; i < personal.Count; i++)
            {
                result[i] = $"Namn: {personal[i].GetFullName}\tLön: {personal[i].Lon} kr/månad";
            }
            return result;
        }

    }
}
