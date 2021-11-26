using Microsoft.AspNetCore.Http.Extensions;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiAddressGetting.Controllers
{
    public class ServiceController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public string ClientIPAddress { get; private set; }


        public IActionResult GetIpAddress()
        {

            ClientIPAddress = HttpContext.Connection.RemoteIpAddress?.ToString();
            ViewBag.IpAddress = ClientIPAddress;
            return View();
        }

        public IActionResult GetPageInformation()
        {
            var url = HttpContext.Request.GetEncodedUrl();
            ViewBag.GetPageInfo = url;
            return View();
        }
    }
}
