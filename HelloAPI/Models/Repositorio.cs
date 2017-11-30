using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace HelloAPI.Models
{
    public class Repositorio
    {
        private MontadoraContext _context;

        public Repositorio()
        {
            _context = new MontadoraContext();
        }

        public IEnumerable<Modelo> GetModelos()
        {
            return _context.Modelos;
        }

        public Modelo GetModeloById(int id)
        {
            return _context.Modelos.Find(id);
        }

        public void InsertModelo(Modelo modelo)
        {
            _context.Modelos.Add(modelo);
            _context.SaveChanges();
        }

        public void DeleteModelo(int id)
        {
            var m = _context.Modelos.Find(id);
            _context.Modelos.Remove(m);
            _context.SaveChanges();

        }

        public void UpdateModelo(Modelo modelo)
        {
            _context.Entry(modelo).State = EntityState.Modified;
            _context.SaveChanges();
        }

    }
}