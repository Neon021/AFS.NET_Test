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
        private CRUD_Record _cRUD;
        private ITranslateService _translateService;

        public HomeController(ITranslateService translateService, CRUD_Record cRUD)
        {
            _cRUD = cRUD;
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
