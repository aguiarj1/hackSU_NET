using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace HackSU.Models
{
    public class ClassesModel
    {
        public ClassesModel(String s)
        {
            this.Name = s;
        }

        public ClassesModel(String s, String b, int c)
        {
            this.Name = s;
            this.QuarterOffered = b;
            this.Credits = c;
        }
        public string Name { get; set; }
        public string QuarterOffered { get; set; }
        public int Credits { get; set; }
    }
}
