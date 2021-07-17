using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TaskApp.Models.ViewModels
{
    public class AdminViewModel
    {
        public int  Id { get; set; }
        public string FullName { get; set; }
        public string Gender { get; set; }
        public string Age { get; set; }
        public DateTime Date { get; set; }
        public string Department { get; set; }
        public string Speciality { get; set; }
        public string Level { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string Address { get; set; }
        public string Picture { get; set; }
        public IFormFile MyPictures { get; set; }
    }

}
