using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using webschool.Data;
using webschool.Models;

namespace webschool.Helpers
{
    public class Combos : IDisposable
    {
        private static webschoolContext db = new webschoolContext();

        public static List<Course> GetCourses()
        {
            var courses = db.Courses.ToList();
            courses.Add(new Course
            {
                CourseID = 0,
                Name = "[Selecionar um curso]"
            });

            return courses.OrderBy(n => n.Name).ToList();
        }

        public void Dispose()
        {
            db.Dispose();
        }
    }
}