
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using RestSharp;

namespace WebApplication1.Controllers
{
    public class LudoController : Controller
    {
        public IActionResult Index()
        {
            var client = new RestClient("http://ludogame2019.azurewebsites.net");

            var request = new RestRequest("api/Ludo", Method.GET);

            var ludoGameResponse = client.Execute<List<int>>(request);
            var gameName = ludoGameResponse.Data.ToArray();

            return View();
        }
    }

}