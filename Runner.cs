﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Personalregister
{
    internal class Runner
    {
        private PersonalLista personal;

        public Runner()
        {
            personal = new();
        }

        public void start() 
        {

            // fösök att skapa en ny person.
            personal.skapaNyPerson("Magnus", "Fransson");

        }
    }
}