using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Book
    {
        public string Name { get; set; } = "book name";
        public int Pages { get; set; }
        public int Progress { get; set; }

        public Book()
        {
            var random = new Random();
            Pages = random.Next(100, 1001);
            Progress = random.Next(101);
        }
    }
}
