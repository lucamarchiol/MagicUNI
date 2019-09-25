using System.ComponentModel.DataAnnotations;

namespace MagicUNI.Models
{
    public class Studente
    {
        [Key]
        public int Matricola { get; set; }
        public string Cognome { get; set; }
        public string Nome { get; set; }
        public string Facolta { get; set; }
    }
}