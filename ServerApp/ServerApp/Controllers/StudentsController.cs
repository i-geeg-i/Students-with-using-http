using HTTP_APi;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ServerApp.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class StudentsController : ControllerBase
    {

        private readonly ILogger<WeatherForecastController> _logger;
        private KnowledgeCenter _knowledgeCenter;

        public StudentsController(ILogger<WeatherForecastController> logger, KnowledgeCenter knowledgeCenter)
        {
            _logger = logger;
            _knowledgeCenter = knowledgeCenter;
        }

        [HttpGet("students")]
        public List<Student> Get()
        {
            return _knowledgeCenter.students;
        }
        [HttpGet("student/{id}")]
        public Student GetStudent([FromRoute] int id)
        {
            return _knowledgeCenter.GetStudent(id);
        }
        [HttpPost("students")]
        public Student NewStudent([FromBody] Student student)
        {
            return _knowledgeCenter.AddStudent(student);
        }
        [HttpPost("students/{id}")]
        public void NewStudent([FromRoute] int id, [FromBody] Mark mark)
        {
            _knowledgeCenter.AddMark(id, mark);
        }
        [HttpPost("teachers")]
        public Teacher NewTeacher([FromBody] Teacher teacher)
        {
            return _knowledgeCenter.AddTeacher(teacher);
        }
    }
}
