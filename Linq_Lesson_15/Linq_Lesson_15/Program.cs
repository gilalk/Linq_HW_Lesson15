using System;
using System.Linq;

namespace Linq_Lesson_15
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[] { 10, 12, 5, 9, 87, -15, 3000, 29 };

            var query = from number in numbers
                        where number == numbers[0] || number == numbers[1] || number == numbers[2]
                        select number;

            foreach (var item in query)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine();
            string[] names = new string[] { "Gil", "Or", "Avia", "Ziv", "Shaltiel", "Efraim" };

            var query1 = from name in names
                         where name.Length >= 4
                         select name;

            foreach (var item in query1)
            {
                Console.WriteLine(item);
            }


            Console.WriteLine("++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++");

            var query2 = from name in names
                         where name.Contains('i')
                         select name;

            foreach (var item in query2)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++");

            //var query3 = from name in names
            //             select Array.Reverse(name.ToCharArray());

            //foreach (var item in query3)
            //{
            //    Console.WriteLine(item);
            //}
        }
    }
}
