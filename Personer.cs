﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Personalregister
{
    internal class Personer
    {
        private Person[] personer = Array.Empty<Person>();

        Personer() { }

        public void skapaNyPerson(string forNamn, string efterNamn)
        {
            this.personer.Append(new Person(forNamn, efterNamn));
        }

    }
}