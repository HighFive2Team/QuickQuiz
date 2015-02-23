using QuickQuiz.Data.Infrastructure;
using QuickQuiz.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuickQuiz.Service.CrudServices
{
    class CrudEndUser
    {
        DatabaseFactory dbFactory = null;
        UnitOfWork unofWork = null;
        public CrudEndUser()
        {
            dbFactory = new DatabaseFactory();
            unofWork = new UnitOfWork(dbFactory);

        }
        public void CreateEndUser(EndUser E)
        {
            unofWork.EndUserRepository.Add(E);
            unofWork.Commit();
        }
        public void UpdateEndUser(EndUser E)
        {
            unofWork.EndUserRepository.Update(E);
            unofWork.Commit();
        }
        public void DeleteEndUser(EndUser E)
        {
            unofWork.EndUserRepository.Delete(E);
            unofWork.Commit();
        }
        public EndUser GetEndUser(int id)
        {
            var E = unofWork.EndUserRepository.GetById(id);
            return E;
        }
        public void Dispose()
        {
            unofWork.Dispose();
        }
    }
}
