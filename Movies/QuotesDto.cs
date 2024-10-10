
namespace Movies
{
    public class QuotesDto
    {
        private string quote;
        private string author;

        public QuotesDto(string quote, string author)
        {
            this.quote = quote;
            this.author = author;
        }

        public QuotesDto()
        {
        }

        public string Quote
        {
            get { return quote; }
            set { this.quote = value; }
        }
        public string Author
        {
            get { return author; }
            set { this.author = value; }
        }

        public override bool Equals(object? obj)
        {
            return obj is QuotesDto dto &&
                   quote == dto.quote &&
                   author == dto.author;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(quote, author);
        }

        public override string? ToString()
        {
            return "[quote= "+Quote + ", author="+ Author +"]";
        }
    }
}
