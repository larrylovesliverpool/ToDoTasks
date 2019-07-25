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
using TryItOut.API.Models;
using TryItOut.DataAccessEF;
using TryItOut.Domain.Models;

namespace TryItOut.API.Controllers
{
    public class LocomotiveTypesController : ApiController
    {
        private LocomotiveTypeEFContext db = new LocomotiveTypeEFContext();

        // GET: api/LocomotiveTypes
        public IQueryable<LocomotiveType> GetLocomotiveTypes()
        {
            return db.LocomotiveTypeEF;
        }

        // GET: api/LocomotiveTypes/5
        [ResponseType(typeof(LocomotiveType))]
        public IHttpActionResult GetLocomotiveType(int id)
        {
            LocomotiveType locomotiveType = db.LocomotiveTypeEF.Find(id);
            if (locomotiveType == null)
            {
                return NotFound();
            }

            return Ok(locomotiveType);
        }

        // PUT: api/LocomotiveTypes/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutLocomotiveType(int id, LocomotiveType locomotiveType)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != locomotiveType.TypeId)
            {
                return BadRequest();
            }

            db.Entry(locomotiveType).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!LocomotiveTypeExists(id))
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

        // POST: api/LocomotiveTypes
        [ResponseType(typeof(LocomotiveType))]
        public IHttpActionResult PostLocomotiveType(LocomotiveType locomotiveType)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.LocomotiveTypeEF.Add(locomotiveType);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = locomotiveType.TypeId }, locomotiveType);
        }

        // DELETE: api/LocomotiveTypes/5
        [ResponseType(typeof(LocomotiveType))]
        public IHttpActionResult DeleteLocomotiveType(int id)
        {
            LocomotiveType locomotiveType = db.LocomotiveTypeEF.Find(id);
            if (locomotiveType == null)
            {
                return NotFound();
            }

            db.LocomotiveTypeEF.Remove(locomotiveType);
            db.SaveChanges();

            return Ok(locomotiveType);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool LocomotiveTypeExists(int id)
        {
            return db.LocomotiveTypeEF.Count(e => e.TypeId == id) > 0;
        }
    }
}