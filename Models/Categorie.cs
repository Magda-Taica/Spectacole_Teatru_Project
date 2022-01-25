namespace Spectacole_Teatru_Project.Models
{
    public class Categorie
    {
        public int ID { get; set; }
        public string Nume_Categorie { get; set; }
        public ICollection<Spectacol> CategoriiSpectacol { get; set; }
    }
}
