using ASPNET.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace ASPNET.Controllers
{
    public class EmpController : Controller
    {
        // GET: EmpController1
        public ActionResult Index()
        {
            List<Emp> emplist=EmpDbRepository.GetEmpList();
            return View(emplist);
        }

        // GET: EmpController1/Details/5
        public ActionResult Details(int id)
        {
            if (id <= 0)
            {
                return RedirectToAction("Index");
            }
            Emp emp=EmpDbRepository.GetEmpById(id);
            return View(emp);
        }

        // GET: EmpController1/Create
        public ActionResult Create()
        {
            Emp emp = new Emp(); 
            return View(emp);
        }

        // POST: EmpController1/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection,Emp pEmp)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    EmpDbRepository.AddNewEmp(pEmp);
                }
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: EmpController1/Edit/5
        public ActionResult Edit(int id)
        {
            if (id <= 0)
            {
                return RedirectToAction("Index");
            }
            Emp emp=EmpDbRepository.GetEmpById(id);
            return View(emp);
        }

        // POST: EmpController1/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection,Emp pEmp)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    EmpDbRepository.UpdateEmp(pEmp);
                }
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: EmpController1/Delete/5
        public ActionResult Delete(int id)
        {
            if (id <= 0)
            {
                return RedirectToAction("Index");
            }
            Emp emp = EmpDbRepository.GetEmpById(id);
            return View(emp);
        }

        // POST: EmpController1/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    EmpDbRepository.DeleteEmp(id);
                }
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
