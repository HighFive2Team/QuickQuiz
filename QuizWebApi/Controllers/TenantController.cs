using QuickQuiz.Domain;
using QuickQuiz.Service.CrudServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace QuizWebApi.Controllers
{
    public class TenantController : ApiController
    {
        // GET: api/Tenants
        public IEnumerable<Tenant> GetAllTenant()
        {
            CrudTenant CT = new CrudTenant();
            return CT.GetAllTenant();
        }

        // GET: api/Tenant/5
        public Tenant GetTenant(int id)
        {
            CrudTenant CT = new CrudTenant();
            return CT.GetTenant(id);
        }

        // POST: api/Tenant
        public void Post([FromBody]Tenant T)
        {
            CrudTenant CT = new CrudTenant();
            CT.CreateTenant(T);
        }

        // PUT: api/Tenant/5
        public void Put([FromBody]Tenant T)
        {
            CrudTenant CT = new CrudTenant();
            CT.UpdateTenant(T);

        }

        // DELETE: api/Tenant/5
        public void Delete(Tenant T)
        {
            CrudTenant CT = new CrudTenant();
            CT.DeleteTenant(T);
        }
    }
}
