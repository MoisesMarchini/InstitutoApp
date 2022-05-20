using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InstitutoApp.Models
{
    public class Service
    {
        [Key]
        public int ServiceId{ get; set; }
        [Required]
        public string ServiceName{ get; set; }
    }
}
