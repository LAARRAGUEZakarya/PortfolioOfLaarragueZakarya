namespace PortfolioOfLaarragueZakarya.Models
{
    public class Services
    {

        public int Id { get; set; }
        //this filed for a one lign presentation below the title    
        public string  SmallPresentation { get; set; } = string.Empty;

        //the icon for the service 
        public string Icon { get; set; } = string.Empty;
        public string Title { get; set; } = string.Empty;
        public string Discription { get; set; } = string.Empty;
        public int WorksCompleted { get; set; }
        public int YearsOfExperiences { get; set;}
        public int TotalClients { get; set; }
        public int AwordWon { get; set; }

    }
}
