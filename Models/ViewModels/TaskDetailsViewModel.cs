using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TaskApp.Models.ViewModels
{
    public class TaskDetailsViewModel 
    {
        public int Id { get; set; }
        //  [Display(Name = "Staff Email")]
      
        public IEnumerable<SelectListItem> StaffEmailList { get; set; }
        public string StaffEmail { get; set; }

       
        public string RecomTask { get; set; }

        public string Status { get; set; }
    }
}
