using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;
using fazendoPassos.Models;

namespace fazendoPassos.Controllers
{
    public class passosController : ApiController
    {
        private passocontext db = new passocontext();

        // GET: api/passos
        public IQueryable<passos> Getpassoss()
        {
            return db.passoss;
        }

        // GET: api/passos/5
        [ResponseType(typeof(passos))]
        public IHttpActionResult Getpassos(int id)
        {
            passos passos = db.passoss.Find(id);
            if (passos == null)
            {
                return NotFound();
            }

            return Ok(passos);
        }

        // PUT: api/passos/5
        [ResponseType(typeof(void))]
        public IHttpActionResult Putpassos(int id, passos passos)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != passos.id)
            {
                return BadRequest();
            }

            db.Entry(passos).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!passosExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return StatusCode(HttpStatusCode.NoContent);
        }

        // POST: api/passos
        [ResponseType(typeof(passos))]
        public IHttpActionResult Postpassos(passos passos)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.passoss.Add(passos);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = passos.id }, passos);
        }

        // DELETE: api/passos/5
        [ResponseType(typeof(passos))]
        public IHttpActionResult Deletepassos(int id)
        {
            passos passos = db.passoss.Find(id);
            if (passos == null)
            {
                return NotFound();
            }

            db.passoss.Remove(passos);
            db.SaveChanges();

            return Ok(passos);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool passosExists(int id)
        {
            return db.passoss.Count(e => e.id == id) > 0;
        }
    }
}