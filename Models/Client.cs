using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InstitutoApp.Models
{
    public class Client
    {
        [Key]
        public int ClientId { get; set; }
        [Required]
        public string FullName { get; set; }
        public string Cpf { get; set; }
        public DateTime BirthDate { get; set; } = DateTime.Now;
        public string Tel { get; set; }
        public string TutorName { get; set; }
        public DateTime CreatedAt{ get; set; } = DateTime.Now;
    }
}
