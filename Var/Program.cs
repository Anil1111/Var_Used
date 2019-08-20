using System;

namespace Var_Used_As_Array
{
    class Program
    {
        class Person
        {
            public string Name { get; set; }
            public string City { get; set; }
            public int Age { get; set; }
        }
        static void Main(string[] args)
        {
            var people = new Person[] {
                new Person{ Name="Anil",City="Pune",Age=23},
                new Person{ Name="Amit",City="Mumbai",Age=24},
                new Person{ Name="Amar",City="Nanded",Age=25},
                new Person{ Name="Aakash",City="Latur",Age=26},
                new Person{ Name="Akshay",City="Pune",Age=28},
                new Person{ Name="Aftaab",City="Pune",Age=29},
                new Person{ Name="Arbaaz",City="Pune",Age=23},
                new Person{ Name="Arun",City="Pune",Age=25},
                new Person{ Name="Ashish",City="Mumai",Age=27},
                new Person{ Name="Anand",City="Pune",Age=21}
            };

            foreach (var per in people)
                Console.WriteLine("    person Name      " + per.Name + "      City   " + per.City + "  Age=    " + per.Age);

            Console.WriteLine("Finished processing. Press a key to end.");
            Console.ReadLine();

        }
    }
}