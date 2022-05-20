using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InstitutoApp.Models
{
    public class Consulta
    {
        [Key]
        public int ConsultaId { get; set; }
        [Required]
        public DateTime Date { get; set; } = DateTime.Now;
        [Required]
        public Service Service { get; set; }
        [Required]
        public Client Client { get; set; }
        public bool Pacote { get; set; }
        public int ConsultaAmount { get; set; }
        public string Payment { get; set; }
        public string Obs{ get; set; }
    }
}
