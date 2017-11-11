using Coins.Application.Contracts;
using Coins.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Web;
using System.Web.Mvc;



namespace Coins.Presentation.Controllers
{
    
    public class TypeCoinController : Controller
    {
        private readonly ITypeCoinServices _ITypeCoinServices;
        public TypeCoinController(ITypeCoinServices _typeCoinServices ) {
            _ITypeCoinServices = _typeCoinServices;
        }
        public ActionResult Index()
        {
            return View();
        }
        
        [HttpPost]
        public ActionResult Create(int? id) {
            Stream req = Request.InputStream;
            req.Seek(0, System.IO.SeekOrigin.Begin);
            string json = new StreamReader(req).ReadToEnd();
            TypeCoin typecoint = JsonConvert.DeserializeObject<TypeCoin>(json);
            _ITypeCoinServices.Save(typecoint);
            return Json("OK");
        }
        

    }
}