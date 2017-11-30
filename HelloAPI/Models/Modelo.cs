using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HelloAPI.Models
{
    public class Modelo
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public int Ano { get; set; }
        public string Placa { get; set; }

        public int MarcaId { get; set; } //FK
        public virtual Marca Marca { get; set; } //Propriedade de Navegacao
    }
}