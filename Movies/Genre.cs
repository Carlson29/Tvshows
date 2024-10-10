
namespace Movies
{
    public abstract class Genre: Interface
    {
        private string [] genreName;
        private string? genreDescription;

        public Genre(string[] genreName, string genreDescription)
        {
            this.genreName = genreName;
            this.genreDescription = genreDescription;
        }

        public Genre()
        {
        }

        public Genre(string[] genreName)
        {
            this.genreName = genreName;
            this.genreDescription = null;
        }

        public string[] GenreName
        {
            get { return this.genreName; }
            set { this.genreName = value; }

        }
        public string? GenreDescription
        {
            get { return this.genreDescription; }
            set { this.genreDescription = value;}
        }

        public override bool Equals(object? obj)
        {
            return obj is Genre genre &&
                   genreName == genre.genreName &&
                   genreDescription == genre.genreDescription &&
                   GenreName == genre.GenreName &&
                   GenreDescription == genre.GenreDescription;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(genreName, genreDescription, GenreName, GenreDescription);
        }

        public override string? ToString()
        {
            string val = "";
            for (int i=0; i<genreName.Length; i++)
            {
                val +=  "," + genreName[i];
            }

            return "[Genre Description=" + GenreDescription + ", GenreName=[" +val + "]]";
        }
    }
}
