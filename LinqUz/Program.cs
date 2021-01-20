using System;
using LinqUz.Models;
using LinqUz.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqUz
{
    class Program
    {
        static void Main(string[] args)
        {
            var vyrAsmenys = PersonData.DataSeed.Where(v => v.Age > 20);
            Console.WriteLine("Asmenys vyresni negu 20m. yra: {0}", string.Join("", vyrAsmenys.Select(v => $"{Environment.NewLine} {v.FirstName} {v.LastName} {v.Age}")));
            var list = PersonData.DataSeed.Select(p => new PersonViewModel { FirstName = p.FirstName, LastName = p.LastName, Age = p.Age });
            foreach (var person in list)
            {
                Console.WriteLine($"Asmuo: {person.FirstName} {person.LastName} {person.Age}m.");
            }
            Console.Read();
        }
    }
}
