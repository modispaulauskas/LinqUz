using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqUz.Models
{
    public class Person
    {
        public string firstname { get; set; }
        public string lastName { get; set; }
        public string email { get; set; }
        public DateTime? birthday { get; set; }
        public string biology { get; set; }
        public int? age
        {
            get
            {
                if(birthday == null) return null;
                var timeSpan = DateTime.Now.Subtract((DateTime)birthday);
                return new DateTime(timeSpan.Ticks).Year - 1;
            }
        }

    }
}
