using AFS.NET_Test.DataAccess;
using AFS.NET_Test.Services;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace AFS.NET_Test.Controllers
{
    public class RecordController : Controller
    {
        private CRUD_Record _cRUD;

        public RecordController(CRUD_Record cRUD)
        {
            _cRUD = cRUD;
        }
        public IActionResult Delete(int id)
        {
            try
            {
                _cRUD.DeleteRecord(id);
                return (IActionResult)Results.Ok();
            }
            catch (Exception ex)
            {
                Results.Problem(ex.Message);
                return RedirectToAction("Home", "Index");
            }
        }

        public IActionResult GetAll()
        {
            try
            {
                var records = _cRUD.GetAllRecords();
                return View(records);
            }
            catch (Exception ex)
            {
                Results.Problem(ex.Message);
                return RedirectToAction("Home", "Index");
            }
        }
    }
}
