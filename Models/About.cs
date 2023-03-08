namespace PortfolioOfLaarragueZakarya.Models
{
    public class About
    {
        public string Name { get; set; } = string.Empty;
        public string Profile { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string Phone { get; set; } = string.Empty;   
        public string DescriptionAboutMe { get; set; } = string.Empty;
        public IList<Skills>? Skills { get; set; }

    }
}
