using LinqUz.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqUz.Data
{
    public static class ProfessionData
    {
        static public List<Profession> DataSeed => new List<Profession>
        {
            new Profession{Text = "Actor"},
            new Profession{Text = "Baker"},
            new Profession{Text = "Animator"},
            new Profession{Text = "Programmer"},
            new Profession{Text = "Model"},
            new Profession{Text = "Engineer"},
            new Profession{Text = "Designer"},
            new Profession{Text = "Taxi driver"},
            new Profession{Text = "Yoga instructor"},
            new Profession{Text = "CEO"},
            new Profession{Text = "Accountant"},
            new Profession{Text = "Judge"},
            new Profession{Text = "Cleaner"},
            new Profession{Text = "Farmer"},
            new Profession{Text = "Medic"},
        };
    }
}
