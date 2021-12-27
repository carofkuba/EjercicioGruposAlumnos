using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ClassLibraryGrupos;
using System.Data;



namespace WebApplicationGrupos.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GruposController : ControllerBase
    {

        private Aplicacion app = new Aplicacion();


        [HttpPost("insert")]

        public IActionResult PostGrupo(Grupo oGrupo)
        {
             bool result = app.InsertGrupo(oGrupo);  
             return Ok(result);        
        }

        [HttpPut("update")]

        public IActionResult PutGrupo(Grupo grupo)
        {
            app.UpdateGrupo(grupo);
            return Ok();
        }


        [HttpGet("grupos")]

        public IActionResult GetGrupos()
        {
            return Ok(app.GetGrupos());
        }

        [HttpGet("alumnos")]

        public IActionResult GetAlumnos()
        {
            return Ok(app.GetAlumnos());
        }

        [HttpGet("alumnosSinGrupo")]

        public IActionResult GetAlumnosSinGrupo()

        {
            return Ok(app.GetAlumnosSinGrupo());
        }

        [HttpGet("alumnosGrupoSeleccionado/{groupId}")]

        public IActionResult GetAlumnosById(string groupId)

        {
            Grupo grupo = new Grupo(groupId,"");
            return Ok(app.GetAlumnosById(grupo));
        }

        
    }   
}
