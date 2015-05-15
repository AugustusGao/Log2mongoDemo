using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using log4net.Config;
using ConsoleApplication1;


namespace Log2Mongo.Controllers
{
    public class HomeController : Controller
    {
        private ILogger _logger;

        public ActionResult Index()
        {
            XmlConfigurator.Configure();
            _logger=new Logger("MVC3");
            _logger.Info("Home");
            return View();
        }

        public ActionResult About()
        {
            XmlConfigurator.Configure();
            _logger = new Logger("MVC3");
            ViewBag.Message = "Your application description page.";
            _logger.Info("About");
            return View();
        }

        public ActionResult Contact()
        {
            XmlConfigurator.Configure();
            _logger = new Logger("MVC3");
            ViewBag.Message = "Your contact page.";
            _logger.Info("Contact");
            return View();
        }
    }
}
