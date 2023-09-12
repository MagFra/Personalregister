using System.Runtime.CompilerServices;

namespace Personalregister
{
    internal class Program
    {
            private PersonalLista personal = new PersonalLista();

        static void Main(string[] args)
        {

            Console.WriteLine("");

            // fösök att skapa en ny person.
            personal.skapaNyPerson("Magnus","Fransson");

        }
    }
}