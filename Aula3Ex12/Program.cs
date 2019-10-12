using System;

namespace MyInterFaces
{
    class Program
    {
        /*
         * Pesquisar IEquatable se for preciso
         */
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine("CompareTo experiments:");
            Console.WriteLine("Ola".CompareTo("Ola"));
            Console.WriteLine(3.1415f.CompareTo(19.4f));
            Console.WriteLine(4.CompareTo(2));
        }
    }
}
