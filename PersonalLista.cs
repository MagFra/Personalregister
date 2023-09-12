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

        public PersonalLista() { }

        public void skapaNyPerson(string forNamn, string efterNamn)
        {
            this.personal.Append(new Person(forNamn, efterNamn));
        }
        public void skapaNyPerson(string forNamn, string efterNamn, int alder)
        {
            this.personal.Append(new Person(forNamn, efterNamn, alder));
        }

    }
}
