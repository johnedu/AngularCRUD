namespace AngularCRUD.Web.Controllers
{
    using System.Web.Mvc;

    public class HomeController : AngularCRUDControllerBase
    {
        public ActionResult Index()
        { 
            return this.View("~/App/Main/views/layout/layout.cshtml"); //Layout of the angular application.
        }
	}
}