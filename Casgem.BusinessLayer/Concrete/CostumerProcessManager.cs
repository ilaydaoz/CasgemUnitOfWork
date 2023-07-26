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
            _customerProcessDAL.Delete(t);
            _uowDal.Save();
        }

        public CostumerProcess TGetByID(int id)
        {
            return _customerProcessDAL.GetByID(id);
        }

        public List<CostumerProcess> TGetList()
        {
            return _customerProcessDAL.GetList();
        }

        public void TInsert(CostumerProcess t)
        {
            _customerProcessDAL.Insert(t);
            _uowDal.Save();
        }

        public void TMultiUpdate(List<CostumerProcess> t)
        {
            _customerProcessDAL.MultiUpdate(t);
            _uowDal.Save();
        }

        public void TUpdate(CostumerProcess t)
        {
            _customerProcessDAL.Update(t);
            _uowDal.Save();
        }
    }
}
