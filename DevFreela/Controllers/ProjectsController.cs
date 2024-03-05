using DevFreela.Models;
using Microsoft.AspNetCore.Mvc;

namespace DevFreela.Controllers
{
    [Route("api/projects")]
    public class ProjectsController : ControllerBase
    {
        // api/projects?query=net core
        [HttpGet]
        public ActionResult Get(string query)
        {
            //Filtrar ou buscar projeto
            return Ok();
        }

        // api/projects/3
        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            // return NotFound();

            //Buscar Projeto
            return Ok();
        }

        [HttpPost]
        public IActionResult Post([FromBody] CreateProjectModel createProject)
        {
            if(createProject.Title.Length > 50)
            {
                return BadRequest();
            }

            //Cadastrar o projeto
            return CreatedAtAction(nameof(GetById), new {id = createProject.Id}, createProject);
        }

        // api/projects/2
        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] UpdateProjectModel updateProject)
        {
            if (updateProject.Description?.Length > 200)
            {
                return BadRequest();
            }

            //Atualizo o Objeto
            return NoContent();
        }

        // api/projects/3  -> DELETE
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            // Buscar, se não existir, retorna NotFound

            //Remove
            return NoContent();
        }
    }
}
