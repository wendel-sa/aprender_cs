using System;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace aprender_cs.Models

{
    public class Heroi
    {
        public int Id { get; set; }

        [Required(ErrorMessage="O campo {0} é obrigaório!")]
        [StringLength(50, MinimumLength=1, ErrorMessage="O campo {0} deve ter no máximo {1} e no minimo {2}")]
        public string Nome { get; set; }

        public string Descricao { get; set; }  

        [Required(ErrorMessage="O campo {0} é obrigaório!")]
        [Display(Name="Arma")]
        public int ArmaId { get; set; }

        public Arma Arma { get; set; }
        }
}