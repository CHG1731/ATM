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
using WebApplication5.Models;

namespace WebApplication5.Controllers
{
    public class TransactiesController : ApiController
    {
        private OP3Context db = new OP3Context();

        // GET: api/Transacties
        public IQueryable<Transactie> GetTransacties()
        {
            return db.Transacties;
        }

        // GET: api/Transacties/5
        [ResponseType(typeof(Transactie))]
        public IHttpActionResult GetTransactie(int id)
        {
            Transactie transactie = db.Transacties.Find(id);
            if (transactie == null)
            {
                return NotFound();
            }

            return Ok(transactie);
        }

        // PUT: api/Transacties/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutTransactie(int id, Transactie transactie)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != transactie.TransactieID)
            {
                return BadRequest();
            }

            db.Entry(transactie).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TransactieExists(id))
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

        // POST: api/Transacties
        [ResponseType(typeof(Transactie))]
        public IHttpActionResult PostTransactie(Transactie transactie)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Transacties.Add(transactie);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = transactie.TransactieID }, transactie);
        }

        // DELETE: api/Transacties/5
        [ResponseType(typeof(Transactie))]
        public IHttpActionResult DeleteTransactie(int id)
        {
            Transactie transactie = db.Transacties.Find(id);
            if (transactie == null)
            {
                return NotFound();
            }

            db.Transacties.Remove(transactie);
            db.SaveChanges();

            return Ok(transactie);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool TransactieExists(int id)
        {
            return db.Transacties.Count(e => e.TransactieID == id) > 0;
        }
    }
}