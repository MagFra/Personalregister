using System;
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
            personal.SkapaNyPerson("Magnus", "Fransson", 30000);
            personal.SkapaNyPerson("Kalle", "Petterson", 25000);
            personal.SkapaNyPerson("Erik", "Bergsten", 300000);
            personal.SkapaNyPerson("Lena", "Sötnos", 30000);


            List<string> list = personal.AlternativLista();
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }

        }
    }
}