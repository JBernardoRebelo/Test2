using System;

namespace TupleFun
{
    public class Program
    {
        static void Main(string[] args)
        {
            // Vars out and ref
            int i; // out
            double d = default; // ref
            bool b;

            // Objects and array
            object[] array = new object[3];
            ClassStruct cs;
            Random rnd = new Random();

            Console.WriteLine("1 return with array:");
            returnArray(array, rnd);
            Console.WriteLine
                (array[0] + " " + array[1] + " " + array[2] + "\n");

            // 2 return with struct
            Console.WriteLine("2 return with struct/class:");
            cs = returnStructClass(rnd);
            Console.WriteLine(cs.I + " " + cs.D + " " + cs.B + "\n");

            // 3 Return with class
            Console.WriteLine("3 return with out and ref:");
            returnOutRef(out i, ref d, out b, rnd);
            Console.WriteLine(i + " " + d + " " + b + "\n");

            // 4 return tuple
            Console.WriteLine("4 return tuple:");
            Console.WriteLine(returnTuple(rnd));
        }

        // 1 - return values with array
        private static object returnArray(object[] array1, Random rnd)
        {
            // Variables to be assigned
            int i = rnd.Next();
            double d = rnd.NextDouble();
            bool b = rnd.NextDouble() > 0.5;

            // Assign positions
            array1[0] = i;
            array1[1] = d;
            array1[2] = b;

            // Return the array
            return array1;
        }

        // 2 - return with class
        private static ClassStruct returnStructClass(Random rnd)
        {
            ClassStruct cs1 = new ClassStruct();
            cs1.I = rnd.Next();
            cs1.D = rnd.NextDouble();
            cs1.B = rnd.NextDouble() > 0.5;

            return cs1;
        }

        // 3 - return with out and ref
        private static void returnOutRef
            (out int i, ref double d, out bool b, Random rnd)
        {
            // Variables to return
            i = rnd.Next();
            d = rnd.NextDouble();
            b = rnd.NextDouble() > 0.5;
        }

        // 4 - return with Tuples
        private static Tuple<int, double, bool> returnTuple(Random rnd)
        {
            Tuple<int, double, bool> tuple;
            tuple = new Tuple<int, double, bool>
                (rnd.Next(), rnd.NextDouble(), rnd.NextDouble() > 0.5);

            return tuple;
        }
    }
}

/*
 * Class returning values explanation
 * 1 - Method that creates the class
 * 2 - Assign values in method
 * 3 - In main assigning returned value from method to the class we want
 */
