using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Joey_Gheller_4CII__Project_Work_Gestione_Libreria
{
    public class Libro
    {
        public Libro(string isbn, string title, string authors, string subtitle, string categories, string thumbnail, string description, double published_year, double average_rating, double num_pages, double ratings_count, double qta)
        {
            this.isbn = isbn;
            this.title = title;
            this.authors = authors;
            this.subtitle = subtitle;
            this.categories = categories;
            this.thumbnail = thumbnail;
            this.description = description;
            this.published_year = published_year;
            this.average_rating = average_rating;
            this.num_pages = num_pages;
            this.ratings_count = ratings_count;
            this.qta = qta;
        }

        public string isbn {get; }
        public string title {get; } 
        public string authors {get; } 
        public string subtitle {get; } 
        public string categories {get; } 
        public string thumbnail {get; } 
        public string description {get; } 
        public double published_year {get; }
        public double average_rating {get; }
        public double num_pages {get; }
        public double ratings_count { get; }
        public double qta {get; } 

    }
}
