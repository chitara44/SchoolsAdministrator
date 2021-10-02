using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using SchoolsAdministrator.Core.Entities;
using SchoolsAdministrator.Core.Interfaces.Services;
using SchoolsAdministrator.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace SchoolsAdministrator.Web.Controllers
{
    [Route(template:"api/[controller]")]
    [ApiController]
    public class ClassroomController : ControllerBase
    {
        private readonly IClassroomService _classroomService;
        private readonly IMapper _mapper;
        public ClassroomController(IClassroomService classroomService, IMapper mapper)
        {
            _classroomService = classroomService;
            _mapper = mapper;
        }

        // GET: api/<ClassroomController>
        [HttpGet]
        public async Task<ActionResult<IEnumerable<ClassroomModel>>> Get()
        {
            var classrooms = await _classroomService.GetAll();
            var mappedClassrooms = _mapper.Map<IEnumerable<Classroom>, IEnumerable<ClassroomModel>>(classrooms);
            return Ok(mappedClassrooms);
        }

        // GET api/<ClassroomController>/5
        [HttpGet("{id}")]
        public async Task<ActionResult<ClassroomModel>> Get(int id)
        {
            var classroom = await _classroomService.GetClassroomById(id);
            var mappedClassroom = _mapper.Map<Classroom, ClassroomModel>(classroom);
            return Ok(mappedClassroom);
        }

        // POST api/<ClassroomController>
        [HttpPost]
        public async Task<ActionResult<ClassroomModel>> Post([FromBody] ClassroomSaveModel classroom)
        {
            try
            {
                var createdClassroom = await _classroomService.CreateClassroom(_mapper.Map<ClassroomSaveModel, Classroom>(classroom));
                return Ok(_mapper.Map<Classroom, ClassroomModel>(createdClassroom));
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        // PUT api/<ClassroomController>/5
        [HttpPut("{id}")]
        public async Task<ActionResult<ClassroomModel>> Put(int id, [FromBody] ClassroomSaveModel classroom)
        {
            try
            {
                var updatedClassroom = await _classroomService.UpdateClassroom(id, _mapper.Map<ClassroomSaveModel, Classroom>(classroom));
                return Ok(_mapper.Map<Classroom, ClassroomModel>(updatedClassroom));

            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        // DELETE api/<ClassroomController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
