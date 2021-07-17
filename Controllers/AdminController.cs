using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using TaskApp.Models;
using TaskApp.Models.ViewModels;

namespace TaskApp.Controllers
{
    public class AdminController : Controller
    {
        private readonly IWebHostEnvironment hostingEnviroment;
        private readonly AppDbContext context;

        public AdminController(IWebHostEnvironment hostingEnviroment, AppDbContext context)
        {
            this.hostingEnviroment = hostingEnviroment;
            this.context = context;
        }

        [HttpGet]
        public ViewResult SubmitTask()
        {
            List<SelectListItem> EmailList = context.AdminModels.Select(x => new SelectListItem { Text = x.Email, Value = x.Email }).ToList();


            var email = new UserViewModel
            {
                StaffEmailList = EmailList,

            };
            //ViewBag.Email = 
            return View(email);
        }
        [HttpGet]
        public ViewResult TaskDetails(int id)
        {

            var data = context.RegistCom.Find(id);
            if (data == null)
            {

            }
            TaskDetailsViewModel taskDetailsViewModel = new TaskDetailsViewModel   
            {
                Id = data.Id,
                StaffEmail = data.StaffEmail,
                RecomTask = data.RecomTask,
                Status = data.Status
            };
            return View(taskDetailsViewModel);
        }
        [HttpGet]
        public ViewResult TaskView()
        {
            var details = context.RegistCom.ToList();
            return View(details);

        }
        [HttpGet]
        public ViewResult TaskRecommendation()
        {
            List<SelectListItem> EmailList = context.AdminModels.Select(x => new SelectListItem { Text = x.Email, Value = x.Email }).ToList();


            var email = new RegistcomViewModel
            {
                StaffEmailList = EmailList
            };
            //ViewBag.Email = 
            return View(email);
        }
        [HttpPost]
        public async Task<IActionResult> TaskRecommendation(RegistcomViewModel model)
        {
            if (ModelState.IsValid)
            {

                RegistCom registCom = new RegistCom
                {
                    StaffEmail = model.StaffEmail,
                    RecomTask = model.RecomTask
                };
                context.RegistCom.Add(registCom);
                var result = await context.SaveChangesAsync();
                //return RedirectToAction("index");
                return RedirectToAction("taskdetails", new { id = registCom.Id });
            }

            return View(model);
        }
        [HttpGet]
        public ViewResult TaskEdit(int id)
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
        public IActionResult TaskEdit(TaskEditViewModel model)
        {
            if (ModelState.IsValid)
            {


                var task = context.RegistCom.Find(model.Id);
                if (model == null)
                {

                } 
                task.StaffEmail =  model.StaffEmail;
                task. RecomTask = model.RecomTask;
                task.Status = model.Status;

                context.RegistCom.Update(task);
                context.SaveChanges();
                return RedirectToAction("taskView", new { id = task.Id });

            }
            return View();
        }
        [HttpGet]
        public ViewResult Details()
        {
            var details = context.AdminModels.ToList();
            return View(details);

        }
        [HttpGet]
        public IActionResult AdminView()
        {
            return View();
        }
        [HttpGet]
        public IActionResult Edit(int id)
        {
            var model = context.AdminModels.Find(id);
            if (model == null)
            {

            }
            AdminEditViewModel adminEditViewModel = new AdminEditViewModel
            {
                FullName = model.FullName,
                Gender = model.Gender,
                Age = model.Age,
                Date = model.Date.Date,
                Email = model.Email,
                Address = model.Address,
                Department = model.Department,
                Speciality = model.Speciality,
                Level = model.Level,
                PhoneNumber = model.PhoneNumber,
                Picture = model.Picture
            };
            return View(adminEditViewModel);
        }
        [HttpPost]
        public IActionResult Edit(AdminEditViewModel model)
        {
            if (ModelState.IsValid)
            {
                var user = context.AdminModels.Find(model.Id);
                if (model == null)
                {

                }
                user.FullName = model.FullName;
                user.Gender = model.Gender;
                user.Age = model.Age;
                user.Date = model.Date.Date;
                user.Email = model.Email;
                user.Address = model.Address;
                user.Department = model.Department;
                user.Speciality = model.Speciality;
                user.Level = model.Level;
                user.PhoneNumber = model.PhoneNumber;
                if (model.Picture != null)
                {
                    if (model.MyPictures != null)
                    {
                        string filePath = Path.Combine(hostingEnviroment.WebRootPath, "assets", "images", model.Picture);
                        System.IO.File.Delete(filePath);
                    }

                    user.Picture = ProcessUploadedFile(model);
                }
                // user.Picture = model.Picture;

                context.AdminModels.Update(user);
                context.SaveChanges();
                return RedirectToAction("details", new { id = user.Id });

            }
            return View();
        }

        private string ProcessUploadedFile(AdminEditViewModel model)
        {
            string uniqueFileName = null;
            if (model.MyPictures != null)
            {
                string uploadsFolder = Path.Combine(hostingEnviroment.WebRootPath, "assets", "images");
                uniqueFileName = Guid.NewGuid().ToString() + "_" + model.MyPictures.FileName;
                string filePath = Path.Combine(uploadsFolder, uniqueFileName);
                using (var fileStream = new FileStream(filePath, FileMode.Create))
                {
                    model.MyPictures.CopyTo(fileStream);
                }

            }
            return uniqueFileName;
        }

        [HttpGet]
        public ViewResult AdminDetails(int id)
        {

            var data = context.AdminModels.Find(id);
            if (data == null)
            {

            }
            AdminViewModel admindetailsViewModel = new AdminViewModel
            {
                Id = data.Id,
                Department = data.Department,
                Speciality = data.Speciality,
                Address = data.Address,
                FullName = data.FullName,
                Picture = data.Picture,
                Email = data.Email
            };
            return View(admindetailsViewModel);
        }
        [HttpPost]
        public IActionResult AdminView(AdminViewModel model)
        {
            if (ModelState.IsValid)
            {
                string uniqueFileName = ProcessUploadedFile(model);

                AdminModel admin = new AdminModel
                {
                    FullName = model.FullName,
                    Gender = model.Gender,
                    Age = model.Age,
                    Date = model.Date.Date,
                    Email = model.Email,
                    Address = model.Address,
                    Department = model.Department,
                    Speciality = model.Speciality,
                    Level = model.Level,
                    PhoneNumber = model.PhoneNumber,
                    Picture = uniqueFileName

                };
                context.AdminModels.Add(admin);
                context.SaveChanges();
                return RedirectToAction("admindetails", new { id = admin.Id });
            }

            return View();
        }

        private string ProcessUploadedFile(AdminViewModel model)
        {
            string uniqueFileName = null;
            if (model.MyPictures != null)
            {
                string uploadsFolder = Path.Combine(hostingEnviroment.WebRootPath, "assets", "images");
                uniqueFileName = Guid.NewGuid().ToString() + "_" + model.MyPictures.FileName;
                string filePath = Path.Combine(uploadsFolder, uniqueFileName);
                using (var fileStream = new FileStream(filePath, FileMode.Create))
                {
                    model.MyPictures.CopyTo(fileStream);
                }

            }
            return uniqueFileName;
        }
    }

}
