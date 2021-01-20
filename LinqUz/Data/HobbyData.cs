using LinqUz.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqUz.Data
{
    public class HobbyData
    {
        public List<Hobby> DataSeed => new List<Hobby>
        {
            new Hobby{Text = "Astrology"},
            new Hobby{Text = "Art"},
            new Hobby{Text = "Animation"},
            new Hobby{Text = "Games"},
            new Hobby{Text = "Puzzle"},
            new Hobby{Text = "Coding"},
            new Hobby{Text = "Dancing"},
            new Hobby{Text = "Music"},
            new Hobby{Text = "Yoga"},
            new Hobby{Text = "Movies"},
            new Hobby{Text = "Card Games"},
            new Hobby{Text = "Boxing"},
            new Hobby{Text = "Karaoke"},
            new Hobby{Text = "Football"},
            new Hobby{Text = "BasketBall"},
        };
    }
}
