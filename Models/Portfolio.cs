namespace PortfolioOfLaarragueZakarya.Models
{
    public class Portfolio
    {
        public int Id { get; set; }
        //this filed for a one lign presentation below the title    
        public string SmallPresentation { get; set; } = string.Empty;

        // image of work 
        public string ImageUrl { get; set; } = string.Empty;
        public IFormFile? File { get; set; }
        public string Title { get; set; } = string.Empty;
        public string Categorie { get; set; } = string.Empty;
        public DateTime DateCreation{ get; set; }


    }
}
