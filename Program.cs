using System.Runtime.CompilerServices;

namespace Personalregister
{
    internal class Program
    {
            private readonly PersonalLista personal = new();

        static void Main(string[] args)
        {

            Console.WriteLine("");

            // fösök att skapa en ny person.
            personal.skapaNyPerson("Magnus","Fransson");

        }
    }
}