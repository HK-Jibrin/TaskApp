using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TaskApp.Models.ViewModels
{
    public class RegistcomViewModel 
    {
        public int Id { get; set; }
        [Display(Name="Staff Email")]
        public string StaffEmail { get; set; }
        public IEnumerable<SelectListItem> StaffEmailList { get; set; }
        [Display(Name ="Recommendation Task")]
        public string RecomTask { get; set; }
       
        public string Status  { get; set; }
        public string Submision { get; set; }

        public DateTime Date { get; set; }
    }
}
