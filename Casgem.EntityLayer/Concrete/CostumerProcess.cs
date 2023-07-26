using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Casgem.EntityLayer.Concrete
{
    public class CostumerProcess
    {
        public int CostumerProcessId { get; set; }
        public int SenderId { get; set; }
        public int ReceiverId { get; set; }
        public decimal Amout { get; set; }
    }
}
