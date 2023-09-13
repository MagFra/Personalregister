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
            personal.skapaNyPerson("Magnus", "Fransson", 30000);
            personal.skapaNyPerson("Kalle", "Petterson", 25000);
            personal.skapaNyPerson("Erik", "Bergsten", 300000);
            personal.skapaNyPerson("Lena", "Sötnos", 30000);

            string[] lista = personal.SkrivUtLista();

            foreach (var item in lista)
            {
                Console.WriteLine(item);
            }

        }
    }
}
