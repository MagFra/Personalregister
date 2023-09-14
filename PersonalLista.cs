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

        //public PersonalLista() { personal = new List<Person>[12]; }

        public void SkapaNyPerson(string forNamn, string efterNamn, int lon)
        {
            Person temp = new Person(forNamn, efterNamn, lon);
            this.personal.Add(temp);
        }
        public void SkapaNyPerson(string forNamn, string efterNamn, int lon, int alder)
        {
            this.personal.Append(new Person(forNamn, efterNamn, lon, alder));
        }

        internal List<string> AlternativLista()
        {
            List<string> list = new();
            foreach (var item in personal)
            {
                list.Add(item.ToString());
            }
            return list;
        }

    }
}