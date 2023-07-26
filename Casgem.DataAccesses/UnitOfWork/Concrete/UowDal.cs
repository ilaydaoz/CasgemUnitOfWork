using Casgem.DataAccesses.Concrete;
using Casgem.DataAccesses.UnitOfWork.Absract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Casgem.DataAccesses.UnitOfWork.Concrete
{
    public class UowDal : IUowDal
    {
        private readonly Context _context;

        public UowDal(Context context)
        {
            _context = context;
        }

        public void Save()
        {
            _context.SaveChanges();
        }
    }
}
