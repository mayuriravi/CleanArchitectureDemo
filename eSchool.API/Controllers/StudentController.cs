using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using eSchool.Application;
using eSchool.Domain;
using Microsoft.AspNetCore.Mvc;

namespace eSchool.Presentation
{
    [Route("api/students")]
    public sealed class StudentController : BaseController
    {


        public StudentController()
        {

        }

        [HttpGet]
        public async Task<ActionResult> GetList([FromBody] GetStudentsListQuery query)
        {
            var result = await Processor.Send(query);
            if (result.Success)
                return Ok(result.Items);
            else
                return BadRequest(result.Message);
        }

        [HttpPost]
        public async Task<ActionResult> Register([FromBody] RegisterRequest command)
        {
            var result = await Processor.Send(command);
            return ProcessResult(result);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> UnregisterAsync(int id)
        {
            var cmd = new UnregisterRequest();
            cmd.Id = id;
            var result = await Processor.Send(cmd);
            return ProcessResult(result);

        }

        [HttpPost("{id}/enrollments")]
        public async Task<ActionResult> Enroll(long id, [FromBody] EnrollRequest command)
        {
            var result = await Processor.Send(command);
            return ProcessResult(result);
        }

        

        [HttpPost("{id}/enrollments/{enrollmentNumber}/deletion")]
        public async Task<ActionResult> Disenroll(long id, int enrollmentNumber, [FromBody] DisenrollRequest command)
        {
            Result result = await Processor.Send(command);
            return ProcessResult(result);
        }

        [HttpPut("{id}")]
        public async Task<ActionResult> EditPersonalInfo(long id, [FromBody] EditPersonalInfoRequest command)
        {
            Result result = await Processor.Send(command);
            return ProcessResult(result);
        }

        private ObjectResult ProcessResult(Result result)
        {
            
            if (result.Success)
                return Ok(result);
            else
                return BadRequest(result.Message);
        }
    }
}