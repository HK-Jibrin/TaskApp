using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TaskApp.Models.ViewModels
{
    public class HomeViewModel
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public string Department { get; set; }
        public string MaritalStatus { get; set; }
        public string Address { get; set; }
        public DateTime Date { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public string Photo { get; set; }
        public IFormFile PhotoPath { get; set; }


    }
}
