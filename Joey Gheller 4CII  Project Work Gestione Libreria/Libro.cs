using Newtonsoft.Json;

namespace Joey_Gheller_4CII__Project_Work_Gestione_Libreria
{
    public class Libro
    {
        [JsonConstructor]
        public Libro(string isbn, string title, string authors, string subtitle, string categories, string thumbnail, string description, double published_year, double average_rating, double num_pages, double ratings_count, double qta, double prestati, double prestiti_totali)
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
            this.prestati = prestati;
            this.prestiti_totali = prestiti_totali;
        }

        public Libro()
        {

        }

        public string isbn { get; }
        public string title { get; }
        public string authors { get; }
        public string subtitle { get; }
        public string categories { get; }
        public string thumbnail { get; }
        public string description { get; }
        public double published_year { get; }
        public double average_rating { get; set; }
        public double num_pages { get; }
        public double ratings_count { get; set; }
        public double qta { get; set; }
        public double prestati { get; set; }
        public double prestiti_totali { get; set; }
    }
}
