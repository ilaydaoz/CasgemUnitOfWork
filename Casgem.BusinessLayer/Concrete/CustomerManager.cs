using Casgem.BusinessLayer.Abstract;
using Casgem.DataAccesses.Abstract;
using Casgem.DataAccesses.UnitOfWork.Absract;
using Casgem.EntityLayer.Concrete;

namespace Casgem.BusinessLayer.Concrete
{
    public class CustomerManager : ICustomerService
    {
        private readonly ICustomerDal _customerDal;
        private readonly IUowDal _uowDal;

        public CustomerManager(ICustomerDal customerDal, IUowDal uowDal)
        {
            _customerDal = customerDal;
            _uowDal = uowDal;
        }

        public void TDelete(Costumer t)
        {
            _customerDal.Delete(t);
            _uowDal.Save();
        }

        public Costumer TGetByID(int id)
        {
            return _customerDal.GetByID(id);
        }

        public List<Costumer> TGetList()
        {
            return _customerDal.GetList();
        }

        public void TInsert(Costumer t)
        {
            _customerDal.Insert(t);
            _uowDal.Save();
        }

        public void TMultiUpdate(List<Costumer> t)
        {
            _customerDal.MultiUpdate(t);
            _uowDal.Save();
        }

        public void TUpdate(Costumer t)
        {
            _customerDal.Update(t);
            _uowDal.Save();
        }
    }
}
