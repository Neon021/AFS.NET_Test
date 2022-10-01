using AFS.NET_Test.DataAccess;
using AFS.NET_Test.Services;
using AFS.NET_Test.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace AFS.NET_Test.Controllers
{
    public class HomeController : Controller
    {
        private readonly ITranslateService _translateService;

        public HomeController(ITranslateService translateService)
        {
            _translateService = translateService;
        }
        public ActionResult Index()
        {
            return View();  
        }

        public async Task<TranslateViewModel> Translate(TranslateViewModel vm)
        {
            try
            {
                var result = await _translateService.Translate(vm);
                return await Task.FromResult(result);
            }
            catch(Exception ex)
            {
                Results.Problem(ex.Message);
                return new TranslateViewModel();
            }
        }
    }
}
