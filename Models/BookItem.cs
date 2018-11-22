using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookAPI.Models
{
    public class BookItem
    {
        public int Id { get; set; }
        public string Title { get; set; }
        //public string Url { get; set; }
        public string Characters { get; set; }
        public int PublicationYear { get; set; }
        public string Description { get; set; }
        public string Author { get; set; }
    }
}
