using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WestCoastEducation2K.Models
{
    public class Course
    {
        public int Id { get; set; }
        public int CourseNumber { get; set; } // 4 siffror
        public string? CourseName { get; set; }
        public string? CourseLength { get; set; } // t ex 3 dagar, 40 timmar
        public string? Description { get; set; }
        public string? Details { get; set; }
        public int CourseCategoryId { get; set; } // Är det rätt typ? Ska det stå så här?

        //TODO -Gör koppling till CourseCategory -en mandatory one relation
        //TODO - Gör koppling till Student - många till många relation

    }
}