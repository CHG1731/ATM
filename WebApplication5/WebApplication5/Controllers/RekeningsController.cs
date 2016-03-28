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
    public class RekeningsController : ApiController
    {
        private OP3Context db = new OP3Context();

        // GET: api/Rekenings
        public IQueryable<Rekening> GetRekening()
        {
            return db.Rekening;
        }

        // GET: api/Rekenings/5
        [ResponseType(typeof(Rekening))]
        public IHttpActionResult GetRekening(int id)
        {
            Rekening rekening = db.Rekening.Find(id);
            if (rekening == null)
            {
                return NotFound();
            }

            return Ok(rekening);
        }

        // PUT: api/Rekenings/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutRekening(int id, Rekening rekening)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != rekening.RekeningID)
            {
                return BadRequest();
            }

            db.Entry(rekening).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!RekeningExists(id))
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

        // POST: api/Rekenings
        [ResponseType(typeof(Rekening))]
        public IHttpActionResult PostRekening(Rekening rekening)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Rekening.Add(rekening);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = rekening.RekeningID }, rekening);
        }

        // DELETE: api/Rekenings/5
        [ResponseType(typeof(Rekening))]
        public IHttpActionResult DeleteRekening(int id)
        {
            Rekening rekening = db.Rekening.Find(id);
            if (rekening == null)
            {
                return NotFound();
            }

            db.Rekening.Remove(rekening);
            db.SaveChanges();

            return Ok(rekening);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool RekeningExists(int id)
        {
            return db.Rekening.Count(e => e.RekeningID == id) > 0;
        }
    }
}