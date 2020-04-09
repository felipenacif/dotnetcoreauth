using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DotNetCoreAuth.Entities
{
    public class Restaurante
    {
        public int Id { get; set; }

        [Required, StringLength(200)]
        public string Nome { get; set; }

        [Required, StringLength(500)]
        public string Endereco { get; set; }

        [Required, StringLength(10)]
        public string Telefone { get; set; }

        [StringLength(250)]
        public string Email { get; set; }
    }
}
