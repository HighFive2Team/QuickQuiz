using QuickQuiz.Data.Infrastructure;
using QuickQuiz.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuickQuiz.Service.CrudServices
{
    class CrudTenant
    {
        DatabaseFactory dbFactory = null;
        UnitOfWork unofWork = null;
        public CrudTenant()
        {
            dbFactory = new DatabaseFactory();
            unofWork = new UnitOfWork(dbFactory);

        }
        public void CreateTenant(Tenant t)
        {
            unofWork.TenantRepository.Add(t);
            unofWork.Commit();
        }
        public void UpdateTenant(Tenant t)
        {
            unofWork.TenantRepository.Update(t);
            unofWork.Commit();
        }
        public void DeleteTenant(Tenant t)
        {
            unofWork.TenantRepository.Delete(t);
            unofWork.Commit();
        }
        public Tenant GetTenant(int id)
        {
            var t = unofWork.TenantRepository.GetById(id);
            return t;
        }
        public void Dispose()
        {
            unofWork.Dispose();
        }
    }
}
