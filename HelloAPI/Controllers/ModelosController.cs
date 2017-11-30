using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using HelloAPI.Models;

namespace HelloAPI.Controllers
{
    public class ModelosController : ApiController
    {
        private Repositorio db = new Repositorio();

        // GET: api/Modelos
        public IEnumerable<Modelo> Get()
        {
            return db.GetModelos();
        }

        // GET: api/Modelos/5
        public Modelo Get(int id)
        {
            return db.GetModeloById(id);
        }

        // POST: api/Modelos
        public void Post([FromBody]Modelo value)
        {
            db.InsertModelo(value);
        }

        // PUT: api/Modelos/5
        public void Put(int id, [FromBody]Modelo value)
        {
            db.UpdateModelo(value);
        }

        // DELETE: api/Modelos/5
        public IHttpActionResult Delete(int id)
        {
            db.DeleteModelo(id);
            return Ok();
        }
    }
}
