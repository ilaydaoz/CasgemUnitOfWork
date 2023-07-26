using Casgem.BusinessLayer.Abstract;
using Casgem.DataAccesses.Abstract;
using Casgem.DataAccesses.UnitOfWork.Absract;
using Casgem.EntityLayer.Concrete;

namespace Casgem.BusinessLayer.Concrete
{
    public class CostumerProcessManager : ICostumerProcessService
    {
        private readonly ICustomerProcessDAL _customerProcessDAL;
        private readonly IUowDal _uowDal;

        public CostumerProcessManager(ICustomerProcessDAL customerProcessDAL, IUowDal uowDal)
        {
            _customerProcessDAL = customerProcessDAL;
            _uowDal = uowDal;
        }

        public void TDelete(CostumerProcess t)
        {
            throw new NotImplementedException();
        }

        public CostumerProcess TGetByID(int id)
        {
            throw new NotImplementedException();
        }

        public List<CostumerProcess> TGetList()
        {
            throw new NotImplementedException();
        }

        public void TInsert(CostumerProcess t)
        {
            throw new NotImplementedException();
        }

        public void TMultiUpdate(List<CostumerProcess> t)
        {
            throw new NotImplementedException();
        }

        public void TUpdate(CostumerProcess t)
        {
            throw new NotImplementedException();
        }
    }
}
