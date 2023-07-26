using Casgem.BusinessLayer.Abstract;
using Casgem.EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace Casgem.PresentationLayer.Controllers
{
    public class DefaultController : Controller
    {
        private readonly ICostumerProcessService _costumerProcessService;
        private readonly ICustomerService _customerService;
        public DefaultController(ICostumerProcessService costumerProcessService,
            ICustomerService customerService)
        {
            _costumerProcessService = costumerProcessService;
            _customerService = customerService;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(CostumerProcess costumerProcessss)
        {
            var valueSender = _customerService.TGetByID(costumerProcessss.SenderId);
            var valueReceiver = _customerService.TGetByID(costumerProcessss.ReceiverId);

            valueReceiver.CostumerBalance += costumerProcessss.Amout;
            valueReceiver.CostumerBalance -= costumerProcessss.Amout;

            List<Costumer> modifiedCustomer = new List<Costumer>
            {
                valueSender,
                valueReceiver
            };
            _customerService.TMultiUpdate(modifiedCustomer);
            return RedirectToAction("CustomerProcessList");
        }
    }
}
