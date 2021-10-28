using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq_Lambda_HW_Lesson15
{
    class City
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int NumberOfPopulation { get; set; }

        public City()
        {

        }

        public City(int id, string name, int numberOfPopulation)
        {
            Id = id;
            Name = name;
            NumberOfPopulation = numberOfPopulation;
        }
    }


}
