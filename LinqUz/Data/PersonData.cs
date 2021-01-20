using LinqUz.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqUz.Data
{
    public class PersonData
    {
        public List<Person> DataSeed => new List<Person> 
        {
            new Person{ FirstName = "Jonas", LastName = "Jonaitis", Birthday = new DateTime(1992, 12, 18)},
            new Person{ FirstName = "Petras", LastName = "Petraitis", Birthday = new DateTime(1996, 10, 19)},
            new Person{ FirstName = "Aiste", LastName = "Aistaite", Birthday = new DateTime(1997, 8, 15)},
            new Person{ FirstName = "Halkas", LastName = "Varzaitis", Birthday = new DateTime(2002, 12, 9)},
            new Person{ FirstName = "Azuolas", LastName = "Azuolaitis", Birthday = new DateTime(1972, 8, 1)},
            new Person{ FirstName = "Kestas", LastName = "Kestaitis", Birthday = new DateTime(1982, 2, 2)},
            new Person{ FirstName = "Valerija", LastName = "Stug", Birthday = new DateTime(1962, 3, 3)},
            new Person{ FirstName = "Ieva", LastName = "Ievaite", Birthday = new DateTime(2003, 4, 5)},
            new Person{ FirstName = "Karolis", LastName = "Karolaitis", Birthday = new DateTime(1999, 5, 2)},
            new Person{ FirstName = "Rasa", LastName = "Rasaite", Birthday = new DateTime(1945, 6, 1)},
            new Person{ FirstName = "Lukas", LastName = "Kelmas", Birthday = new DateTime(1969, 6, 9)},
            new Person{ FirstName = "Lina", LastName = "Linaite", Birthday = new DateTime(1992, 7, 19)},
            new Person{ FirstName = "Linas", LastName = "Linaitis", Birthday = new DateTime(1992, 6, 17)},
            new Person{ FirstName = "Kestutis", LastName = "Lukaitis", Birthday = new DateTime(1972, 6, 10)},
            new Person{ FirstName = "Jonas", LastName = "Petraitis", Birthday = new DateTime(2020, 4, 30)},
                             
        };
    }
}
