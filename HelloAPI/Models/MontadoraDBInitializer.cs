using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace HelloAPI.Models
{
    public class MontadoraDBInitializer : DropCreateDatabaseAlways<MontadoraContext>
    {
        protected override void Seed(MontadoraContext context)
        {
            //Dados iniciais da tabela Marca
            context.Marcas.Add(new Marca() { Nome = "Audi" });
            context.Marcas.Add(new Marca() { Nome = "Ford" });

            //Dados iniciais da tabela Modelo
            context.Modelos.Add(new Modelo() { Nome = "A3", Ano = 2016, Placa = "EGG4345", MarcaId = 1 });
            context.Modelos.Add(new Modelo() { Nome = "A5", Ano = 2017, Placa = "FDF2134", MarcaId = 1 });
            context.Modelos.Add(new Modelo() { Nome = "Fusion", Ano = 2015, Placa = "ABC1234", MarcaId = 2 });
            context.Modelos.Add(new Modelo() { Nome = "Edge", Ano = 2016, Placa = "PRE8534", MarcaId = 2 });

            base.Seed(context);
        }
    }
}