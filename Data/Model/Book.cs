using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace fullVersion.Data.Model
{
    public class Book
    {
        public int Id  { get; set; }

        public string  Title { get; set; }

        public string Author { get; set; }

        public DateTime AddDate { get; set;}

        public bool IsRead { get; set; }
    }
}
