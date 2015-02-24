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
using QuickQuiz.Domain;
using quizapi.Models;

namespace quizapi.Controllers
{
    public class TenantsController : ApiController
    {
        private quizapiContext db = new quizapiContext();

        // GET: api/Tenants
        public IQueryable<Tenant> GetTenants()
        {
            return db.Tenants;
        }

        // GET: api/Tenants/5
        [ResponseType(typeof(Tenant))]
        public IHttpActionResult GetTenant(string id)
        {
            Tenant tenant = db.Tenants.Find(id);
            if (tenant == null)
            {
                return NotFound();
            }

            return Ok(tenant);
        }

        // PUT: api/Tenants/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutTenant(string id, Tenant tenant)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != tenant.IdUser)
            {
                return BadRequest();
            }

            db.Entry(tenant).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TenantExists(id))
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

        // POST: api/Tenants
        [ResponseType(typeof(Tenant))]
        public IHttpActionResult PostTenant(Tenant tenant)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Tenants.Add(tenant);

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateException)
            {
                if (TenantExists(tenant.IdUser))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtRoute("DefaultApi", new { id = tenant.IdUser }, tenant);
        }

        // DELETE: api/Tenants/5
        [ResponseType(typeof(Tenant))]
        public IHttpActionResult DeleteTenant(string id)
        {
            Tenant tenant = db.Tenants.Find(id);
            if (tenant == null)
            {
                return NotFound();
            }

            db.Tenants.Remove(tenant);
            db.SaveChanges();

            return Ok(tenant);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool TenantExists(string id)
        {
            return db.Tenants.Count(e => e.IdUser == id) > 0;
        }
    }
}