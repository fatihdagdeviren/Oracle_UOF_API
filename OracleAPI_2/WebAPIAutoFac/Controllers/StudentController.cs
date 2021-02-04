using Domain.Entities;
using Domain.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebAPIAutoFac.Controllers
{
    public class StudentController : ApiController
    {
        private IStudentService _studentService;

        public void StudentsController(IStudentService studentService)
        {
            _studentService = studentService;
        }


        public IHttpActionResult GetStudents()
        {

            if (!_studentService.GetAll().Any())
            {
                _studentService.Create(new Student { Name = "Student 1" });
                _studentService.Create(new Student { Name = "Student 2" });
                _studentService.Create(new Student { Name = "Student 3" });
            }

            return Ok(_studentService.GetAll());
        }
    }
}
