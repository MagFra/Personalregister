using System.Runtime.CompilerServices;

namespace Personalregister
{
    internal class Program
    {
            private Personer personer = new Personer();
        static void Main(string[] args)
        {

            Console.WriteLine("");

            // fösök att skapa en ny person.
            personer.skapaNyPerson("Magnus","Fransson");
        }
    }
}