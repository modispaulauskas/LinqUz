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
            new Person{ firstname = "Jonas", lastName = "Jonaitis", birthday = new DateTime(1992, 12, 18)},
            new Person{ firstname = "Petras", lastName = "Petraitis", birthday = new DateTime(1996, 10, 19)},
            new Person{ firstname = "Aiste", lastName = "Aistaite", birthday = new DateTime(1997, 8, 15)},
            new Person{ firstname = "Halkas", lastName = "Varzaitis", birthday = new DateTime(2002, 12, 9)},
            new Person{ firstname = "Azuolas", lastName = "Azuolaitis", birthday = new DateTime(1972, 8, 1)},
            new Person{ firstname = "Kestas", lastName = "Kestaitis", birthday = new DateTime(1982, 2, 2)},
            new Person{ firstname = "Valerija", lastName = "Stug", birthday = new DateTime(1962, 3, 3)},
            new Person{ firstname = "Ieva", lastName = "Ievaite", birthday = new DateTime(2003, 4, 5)},
            new Person{ firstname = "Karolis", lastName = "Karolaitis", birthday = new DateTime(1999, 5, 2)},
            new Person{ firstname = "Rasa", lastName = "Rasaite", birthday = new DateTime(1945, 6, 1)},
            new Person{ firstname = "Lukas", lastName = "Kelmas", birthday = new DateTime(1969, 6, 9)},
            new Person{ firstname = "Lina", lastName = "Linaite", birthday = new DateTime(1992, 7, 19)},
            new Person{ firstname = "Linas", lastName = "Linaitis", birthday = new DateTime(1992, 6, 17)},
            new Person{ firstname = "Kestutis", lastName = "Lukaitis", birthday = new DateTime(1972, 6, 10)},
            new Person{ firstname = "Jonas", lastName = "Petraitis", birthday = new DateTime(2020, 4, 30)},

        };
    }
}
