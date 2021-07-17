using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using TaskApp.Models;
using TaskApp.Models.ViewModels;

namespace TaskApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly IWebHostEnvironment hostingEnviroment;
        private readonly AppDbContext context;

        //private readonly ITask _task;

        public HomeController(IWebHostEnvironment hostingEnviroment, AppDbContext context)
        {
            this.hostingEnviroment = hostingEnviroment;
            this.context = context;
        }
        public ViewResult Index()
        {
            var details = context.RegistCom.ToList();
             return View(details);
        }

        [HttpGet]
        public async Task<IActionResult> Index(string StSearch)
        {
            ViewData["index"] = StSearch;
            var staff = from x in context.RegistCom select x;
            if (StSearch != null)
            {
                staff = staff.Where(x => x.StaffEmail.Contains(StSearch));
            }
            return View(await staff.AsNoTracking().ToListAsync());

        }
        [HttpGet]
        public ViewResult Users(int id)
        {

            var data = context.RegistCom.Find(id);
            if (data == null)
            {

            }
            List<SelectListItem> EmailList = context.AdminModels.Select(x => new SelectListItem { Text = x.Email, Value = x.Email }).ToList();
            TaskEditViewModel taskEditViewModel = new TaskEditViewModel
            {
                Id = data.Id,
                StaffEmailList = EmailList,
                StaffEmail = data.StaffEmail,
                RecomTask = data.RecomTask,
                Status = data.Status
            };
            return View(taskEditViewModel);

        }
        [HttpPost]
        public IActionResult Users(TaskEditViewModel model) 
        {
            if (ModelState.IsValid)
            {


                var task = context.RegistCom.Find(model.Id);
                if (model == null)
                {

                }
                task.StaffEmail = model.StaffEmail;
                task.RecomTask = model.RecomTask;
                task.Submision = model.Submision;
                if(model.Submision != null)
                {
                    task.Status = "Delivered";
                }
                else
                {
                    task.Status = "In Progress";
                }

                context.RegistCom.Update(task);
                
                context.SaveChanges();
                return RedirectToAction("index");

            }
            return View();
        }
        [HttpGet]
        public ViewResult Notification() 
        {

            var notification = context.RegistCom.ToList();
            return View(notification);
        }

        //[HttpGet]
        //public ViewResult Users()
        //{

        //    List<SelectListItem> EmailList = context.AdminModels.Select(x => new SelectListItem { Text = x.Email, Value = x.Email }).ToList();
        //    TaskEditViewModel taskEditViewModel = new TaskEditViewModel
        //    {
        //        Id = .Id,
        //        StaffEmail = data.StaffEmail,
        //        RecomTask = data.RecomTask,
               
        //    };
        //    return View(taskEditViewModel);
        //}

    }
}