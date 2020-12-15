using CleanArch.Domain.Interfaces;
using CleanArch.Domain.Models;
using CleanArch.Infr.Data.Context;
using System;
using System.Collections.Generic;
using System.Text;

namespace CleanArch.Infr.Data.Repository
{
    public class CourseRepository : ICourseRepository
    {
        private UninersityDBContext _ctx;
        public CourseRepository(UninersityDBContext ctx)
        {
            _ctx = ctx;
        }

        public IEnumerable<Course> GetCourses()
        {
            return _ctx.Courses;
        }
    }
}
