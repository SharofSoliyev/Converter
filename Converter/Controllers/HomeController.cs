using Converter.BusinnesLogic.Models;
using Converter.Core.Entities;
using Converter.View.ViewModels;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Converter.View.Controllers
{
    public class HomeController : Controller
    {

        public async Task<ViewResult> Index()
        {
            var client = new RestClient($"https://cbu.uz/ru/arkhiv-kursov-valyut/json/");
            var request = new RestRequest(Method.GET);
            IRestResponse response = await client.ExecuteAsync(request);
            var t = JsonConvert.DeserializeObject<List<JObject>>(response.Content);
            IEnumerable<CurrencyModel> currencies = JsonConvert.DeserializeObject<IEnumerable<CurrencyModel>>(response.Content);

            HomeIndexViewModel viewModel = new HomeIndexViewModel()
            {
                CurrencyModels = currencies};

            return View(viewModel);
         }

        
       

    }

}
