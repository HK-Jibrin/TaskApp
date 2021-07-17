using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TaskApp.Models.ViewModels
{
    public class AdminDetailViewModel
    {
        public AdminModel  Admin { get; set; }
        public string PageTitle { get; set; }
        public IFormFile  MyPictures { get; set; }
    }
}
