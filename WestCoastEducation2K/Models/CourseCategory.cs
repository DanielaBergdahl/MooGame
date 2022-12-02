using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WestCoastEducation2K.Models
{
    public class CourseCategory
    {
        public int Id { get; set; }
        public string? CategoryName { get; set; }

        //TODO -Gör så att relationen till Course blir- optional many
        //TODO - Gör så att relationen till Teacher är - optional many to many 
    }
}