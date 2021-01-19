using System;
using System.Linq;
using System.Threading.Tasks;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace aprender_cs.Models
{
    public class HeroiBatalha
    {
        public int id { get; set;}

        [Required(ErrorMessage="O campo {0} é obrigaório!")]
        public int HeroiId { get; set; }

        [Required(ErrorMessage="O campo {0} é obrigaório!")]
        public int BatalhaId { get; set; }

        public Heroi Heroi { get; set; }
        public Batalha Batalha { get; set; }
    }
}