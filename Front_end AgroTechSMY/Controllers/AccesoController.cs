using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;



namespace Front_end_AgroTechSMY.Controllers
{
    public class AccesoController : Controller
    {
        // GET: Acceso
        public ActionResult Login()
        {
            
            return View();
        }
        public ActionResult O_Registrar()
        {
            return View();
        }
        [HttpPost]
        public ActionResult RegistrarP()
        {
            return View();
        }
     
        public ActionResult RegistrarA()
        {
            return View();
        }
       
        public ActionResult RegistrarC()
        {
            return View();
        }
    }
}