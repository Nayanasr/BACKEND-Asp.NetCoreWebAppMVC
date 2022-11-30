using Asp.NetCoreEmpty.Modal;
using Asp.NetCoreEmpty.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Asp.NetCoreEmpty.Controllers
{
    [Route("[Controller]")]
    //add mvc but where as in add mvc core u can use only core methods
    public class HomeController : Controller
    {
        //public string Index() {
        //    //action method which returns a string;
        //    return "action controller in AspDotNetCoreEmpty";
        //}
        //public IActionResult Index() {
        //    return View();
        //}



        public IEmployeeRepository _employeeRepository;

        public HomeController(IEmployeeRepository employeeRepository) {
            _employeeRepository = employeeRepository;
        }

        //public string Index() {
        //    return _employeeRepository.GetEmployee(2).email;
        //}
        //public JsonResult Details() {
        //    Employee modal = _employeeRepository.GetEmployee(2);
        //    return Json(modal);
        //} 



        //view bag is a wrapper around view data
        //creates a loosly typed view
        //viewdata uses string keys to store and retrieve the data
        //viewbag will dynamically resolves in the runtime
        //no-compile time type checking and intellisense

        //VIEWDATA
        //public ViewResult Details() {
        //    Employee modal = _employeeRepository.GetEmployee(2);
        //    ViewData["Employee"] = modal;
        //    ViewData["Title"] = "Details of Employee";

        //    return View(); //action method name as parameter
        //}

        ////VIEWBAG
        //public ViewResult Details() {
        //    //Employee modal = _employeeRepository.GetEmployee(2);
        //    var modal = _employeeRepository.GetAllEmployee();
        //    ViewBag.Employee = modal;
        //    ViewBag.Title = "Details of Employee";
        //    //return View(); //action method name as parameter
        //    return View(modal);
        //    //}

        //STRICTLY TYPED VIEW


        //public string Index() {
        //    return _employeeRepository.GetEmployee(2).name;
        //}




        //passing the view(html page name) directly withoutmentioning the extension
        //Relative path (no need of file extension
        //Absolute path (wher the file is in the different folder) we need to mention the extension
        //public IActionResult Index() {
        //    //return View("Details");
        //    //return View("../Test/Testing");
        //    return View("MyViews/Test.cshtml");
        //}
        //public IActionResult AllEmployee() {
        //    var modal = _employeeRepository.GetAllEmployee();
        //    return View(modal);
        //}

        //[Route("Home/employee/{id?}")]

        //public IActionResult Employee(int? id) {
        //    HomeDetailsViewModel homeDetailsViewModel = new HomeDetailsViewModel() {
        //        employee = _employeeRepository.GetEmployee(id ?? 1),
        //        Title = "Detals of Employee"
        //    };
        //    return View(homeDetailsViewModel);
        //}
        [Route("")]

        //[Route("~")]

        [Route("[action]")]

        [Route("Index/{id?}")]

        public string Index(int? id) {
            return _employeeRepository.GetEmployee(id ?? 2).name;
        }

        //public IActionResult Index() {
        //    return View("MyViews/Test.cshtml");
        //}

        [Route("")]
        [Route("Details/{id?}")]
        public ViewResult Details(int? id) {
            HomeDetailsViewModel homeDetailsViewModel = new HomeDetailsViewModel() {
                employee = _employeeRepository.GetEmployee(id??2),
                Title = "Details of Employee",

            };

            return View(homeDetailsViewModel);

        }

        [Route("AllEmployee")]
        public IActionResult AllEmployee() {
            var modal = _employeeRepository.GetAllEmployee();
            return View(modal);
        }
      


        //public IActionResult Employee() {
        //    return View();
        //}
    }

    
}


    
