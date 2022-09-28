using AFS.NET_Test.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RestSharp;
using unirest_net.http;

namespace AFS.NET_Test.Controllers
{
    public class HomeController : Controller
    {
        // GET: HomeController
        public ActionResult Index()
        {
            return View();  
        }

        [HttpPost]
        public ActionResult Translate(TranslateViewModel _viewModel)
        {
            var request = new RestRequest($"{Method.Get}");
            //request.AddParameter("text", translate.input);

            var client = new RestClient($"https://api.funtranslations.com/translate/shakespeare.json?text={@_viewModel.input}");
            var response = client.ExecuteGet(request);

            return View(new TranslateViewModel { output = response.Content});
        }
    }
}
