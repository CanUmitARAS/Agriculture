using BusinessLayer.Concrete;
using DataAccessLayer.Contrete.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace AgricultureUI.Controllers
{
    public class DefaultController : Controller
    {
        ServiceManager serviceManager = new ServiceManager(new EFServiceDal());
        public IActionResult Index()
        {
            var values = serviceManager.GetListAll();
            return View(values);
        }
    }
}
