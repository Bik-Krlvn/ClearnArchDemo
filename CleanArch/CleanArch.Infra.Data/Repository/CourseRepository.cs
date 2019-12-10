using System;
using System.Collections.Generic;
using System.Text;
using CleanArch.Domain.Entities;
using CleanArch.Domain.Interfaces;
using CleanArch.Infra.Data.Context;

namespace CleanArch.Infra.Data.Repository
{
    public class CourseRepository:ICourseRepository
    {
        private CleanDBContext _cleanDbContext;

        public CourseRepository(CleanDBContext cleanDbContext)
        {
            _cleanDbContext = cleanDbContext;

        }
        public IEnumerable<Course> GetCourses()
        {
            return _cleanDbContext.Courses;
        }
    }
}
