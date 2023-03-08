namespace PortfolioOfLaarragueZakarya.Models
{
    public class Blog
    {
        public int Id { get; set; }
        public string smallpresentation { get; set; } = string.Empty;
        public string ImageUrl { get; set; } = string.Empty;
        public IFormFile? File { get; set; }  
        public string Categorie { get; set; } = string.Empty;
        public string Title { get; set; } = string.Empty;    
        public string Description { get; set; } = string.Empty;
        public string Author { get; set; } = string.Empty;
        public DateTime DatePosted { get; set; }
    }
}
