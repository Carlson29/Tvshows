
namespace Movies
{
    public class Movies: Genre
    {
        private string movieName;
        private double? rating;
        private string? description;
        private string? image;
        public Movies(string movieName, double rating, string[] genreName):base(genreName)
        {
            this.movieName = movieName;
            this.rating = rating;
            this.description = null;
        }

        public Movies(string movieName, double rating, string description, string image, string[] genreName) : base(genreName)
        {
            this.movieName = movieName;
            this.rating = rating;
            this.description = description;
            this.image = image;
        }
        public Movies(string movieName, string description, string image, string[] genreName) : base(genreName)
        {
            this.movieName = movieName;
            this.description = description;
            this.image = image;
        }

        public Movies():base()
        {
        }

        public string MovieName
        {
            get { return this.movieName; }
            set { this.movieName = value; }
        }
        public double? Rating
        {
            get { return this.rating; }
            set { this.rating = value; }
        }
        public string? Description
        {
            get { return this.description; }
            set { this.description = value; }
        }
        public string? Image
        {
            get { return this.image; }
            set { this.image = value; }
        }

        public override bool Equals(object? obj)
        {
            return base.Equals(obj);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public override string? ToString()
        {
            return base.ToString();
        }
    }
}
