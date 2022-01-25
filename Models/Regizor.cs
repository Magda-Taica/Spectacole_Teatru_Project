namespace Spectacole_Teatru_Project.Models
{
    public class Regizor
    {
        public int ID { get; set; }
        public string Nume_Regizor { get; set; }
        public ICollection<Spectacol> Spectacole { get; set; }
    }
}
