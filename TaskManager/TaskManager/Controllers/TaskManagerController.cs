using ApplicationLayer.Projects.Commands.DeleteProject;
using ApplicationLayer.Projects.Queries.ProjectListQuery;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TaskManager.Controllers
{
    public class TaskManagerController : HomeController
    {
        [HttpGet]
        public async Task<ActionResult<ProjectListViewModel>> GetAll()
        {
            var query = new GetProjectListQuery
            {
                
            };
            var vm = await Mediator.Send(query);
            return Ok(vm);
        }
        //[HttpPost]
        //Create project

        //[HttpPut]
        //Update project

        [HttpDelete("{id}")]
        //Delete project
        public async Task<IActionResult> Delete(int id)
        {
            var command = new DeleteProjectCommand
            {
                Id = id,
               
            };
            await Mediator.Send(command);
            return NoContent();
        }
    }
}
