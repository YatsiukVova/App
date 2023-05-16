using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App
{
    public class Book
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Author { get; set; }
        public int Year { get; set; }
        public string Genre { get; set; }
        public string CoverType { get; set; }
        public bool AgeLimit { get; set; }
        public bool CoAuthor { get; set; }
        public double Rating { get; set; }
       

        public Book() { }

        public Book(int id, string name, string author, int year,
            string gener, string coverType, bool ageLimit, bool coAuthor, double rating)
        {
            Id = id;
            Name = name;
            Author = author;
            Year = year;
            Genre = gener;
            CoverType = coverType;
            AgeLimit = ageLimit;
            CoAuthor = coAuthor;
            Rating = rating;
        }
    }
}
