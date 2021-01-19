using System;
using System.Linq;
using System.Threading.Tasks;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace aprender_cs.Models

{
    public class Arma
    {
        public int Id { get; set; }

        [Required(ErrorMessage="O campo {0} é obrigaório!")]
        public string Nome { get; set; }

        [Required(ErrorMessage="O campo {0} é obrigaório!")]
        public string Descricao { get; set; }

        public List<Heroi> Heroi { get; set; }
    }
}