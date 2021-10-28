using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace Linq_Lambda_HW_Lesson15
{
    class Program
    {
        static void Main(string[] args)
        {
            #region integer numbers

            // Q1 

            Console.WriteLine("\n************************ Q 1 ******************************\n");

            int[] numbers = new int[] { 10, 12, 5, 9, 87, -15, 3000, 29 };

            var query = from number in numbers
                        where number < 0
                        select number;

            var lst = numbers.Where(number => number < 0);

            foreach (var item in lst)
            {
                Console.WriteLine(item);
            }

            // Q2

            Console.WriteLine("************************ Q 2 ******************************");

            var query1 = from number in numbers
                         where number % 2 == 0
                         orderby number descending
                         select number;

            

            var lst1 = numbers.OrderByDescending(number => number).Where(number => number % 2 == 0);

            foreach (var item in lst1)
            {
                Console.WriteLine(item);
            }

            // Q3

            Console.WriteLine("************************ Q 3 ******************************");

            var query2 = from number in numbers
                         where number > 5 && number % 3 != 0
                         select number * 3;


            var lst2 = numbers.Where(number => number > 5 && number % 3 != 0).Select(number => 3 * number);

            foreach (var item in lst2)
            {
                Console.WriteLine(item);
            }
            #endregion

            #region Cities

            string[] cities = new string[] { "Beit Shean", "Beit Shemesh", "Rosh Ha'Ain", "Rosh Hanikra", "Beit Horon", "Beer Sheva" };

            Console.WriteLine("\n************************ Q 4 ******************************\n");

            var query3 = from city in cities
                         where city.Contains("Beer")
                         select city;

            var lst3 = cities.Where(city => city.Contains("Rosh"));
            foreach (var item in lst3)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("\n************************ Q 5 ******************************\n");

            var pattern = @"^Beit";
            var regex = new Regex(pattern);

            var query4 = from city in cities
                         where !regex.IsMatch(city)
                         select city;

            var lst4 = cities.Where(city => !regex.IsMatch(city));

            foreach (var item in lst4)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("\n************************ Q 6 ******************************\n");

            var query5 = (from city in cities
                          where city.Contains('o')
                          select city).Take(1);

            var lst5 = cities.Where(city => city.Contains('H')).Take(1);

            foreach (var item in lst5)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("\n************************ Q 7 ******************************\n");

            var query6 = (from city in cities
                          orderby city 
                          select city).Take(3);

            var lst6 = cities.OrderBy(city => city).Take(3);

            foreach (var item in lst6)
            {
                Console.WriteLine(item);
            }


            #endregion

            #region Cities Class

            List<City> citiesList = new List<City>()
            {
                new City(32, "Beit Shean", 22000),
                new City(43, "Beit Horon", 3000),
                new City(12, "Tveria", 40000),
                new City(76, "Jerusalem", 874186),
                new City(73, "Tel Aviv", 435855),
                new City(91, "Modi'in", 92406),
            };

            Console.WriteLine("\n************************ Q 8 ******************************\n");

            var lcity = citiesList.OrderBy(city => city.NumberOfPopulation).Where(city => city.NumberOfPopulation > 25000);

            var queryCity = from city in citiesList
                            where city.NumberOfPopulation > 25000
                            select city;

            foreach (var item in lcity)
            {
                Console.WriteLine(item.Name);
            }

            Console.WriteLine("\n************************ Q 9 ******************************\n");

            var lcity1 = citiesList.Where(city => city.NumberOfPopulation > 25000).Select(city => city.Name);

            var queryCity1 = from city in citiesList
                            where city.NumberOfPopulation > 25000
                            select city.Name;

            foreach (var item in lcity1)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("\n************************ Q 10 *****************************\n");

            var queryCity2 = from city in citiesList
                             select (city.NumberOfPopulation > 25000 ? new { Name = city.Name, definition = "City" } : new { Name = city.Name, definition = "settlement" });

            var lcity2 = citiesList.Select(city => city.NumberOfPopulation > 25000 ? new { Name = city.Name, definition = "City" } : new { Name = city.Name, definition = "settlement" });

            foreach (var item in lcity2)
            {
                Console.WriteLine(item);
            }
            #endregion
        }
    }
}
