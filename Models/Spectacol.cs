namespace Spectacole_Teatru_Project.Models


{
    using System.Threading.Tasks;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    public class Spectacol

    {
        public int ID { get; set; }
        [Display(Name = "Nume Piesa")]
        public string Nume_Piesa { get; set; }
        public string Autor { get; set; }

        [Column(TypeName = "decimal(6, 2)")]
        public decimal Pret { get; set; }


        [DataType(DataType.Date)]
        public DateTime SpectacolDate  { get; set; }

        public int RegizorID { get; set; }
        public Regizor Regizor { get; set; }

        public ICollection<Categorie> CategoriiSpectacol { get; set; }
    }

}

