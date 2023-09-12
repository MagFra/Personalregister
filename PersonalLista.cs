using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Personalregister
{
    internal class PersonalLista
    {
        private Person[] personer = Array.Empty<Person>();

        public PersonalLista() { }

        public void skapaNyPerson(string forNamn, string efterNamn)
        {
            this.personer.Append(new Person(forNamn, efterNamn));
        }
        public void skapaNyPerson(string forNamn, string efterNamn, int alder)
        {
            this.personer.Append(new Person(forNamn, efterNamn, alder));
        }

    }
}
