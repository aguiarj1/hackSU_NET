using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HackSU.Models;

namespace HackSU.ViewModels
{
    public class StudentClassesViewModel
    {
        public GuestResponsecs Student { get; set; }
        public List<ClassesModel> ClassesAvailable { get; set;}
    }
}
