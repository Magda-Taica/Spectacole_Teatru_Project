namespace Spectacole_Teatru_Project.Models
{
    public class FelSpectacol
    {
        public int ID { get; set; }
        public int SpectacolID { get; set; }
        public Spectacol Spectacol { get; set; }
        public int FelID { get; set; }
        public FelSpectacol Categorie { get; set; }
    }
}
