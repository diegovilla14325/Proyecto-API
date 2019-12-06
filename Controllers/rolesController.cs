/*using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using angular.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace angular.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class rolesController : ControllerBase
    {
        // GET api/values
        [HttpGet ("{id?}")]
      public async Task<ActionResult> Getroles(int? id){
          using(var db=new BlogContext()){
            if(id==null){
                var rols = await db.Rol.ToListAsync(); 
                return Ok(rols);
            }else {
                var rol = await db.Rol.FindAsync(id);
                return Ok(rol);
            }
          }
      }

        // POST api/values
        [HttpPost]
        public async Task<ActionResult> Postroles([FromBody] Rol valor)
        {
            using(var db= new BlogContext()){
                try{
                    db.Add(new Rol{Nombrerol=valor.Nombrerol,Usuariorol=valor.Usuariorol});
                    await db.SaveChangesAsync();
                    return Ok();

                }catch(DbUpdateConcurrencyException){
                    return BadRequest();
                }
            }
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public async Task<ActionResult> Putroles(int id, [FromBody] Rol valor)
        {
            using (var _db = new BlogContext())
            {
                if (!ModelState.IsValid || id < 0)
                {
                    return BadRequest(ModelState);
                }
                var rol = await _db.Rol.FindAsync(id);
                if (valor == null)
                {
                    return NotFound();
                }
                rol.Nombrerol = valor.Nombrerol;
                rol.Usuariorol = valor.Usuariorol;
            
                try
                {
                    await _db.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    return BadRequest();
                }

                return Ok();
            }
        }

    [HttpDelete("{id}")]
        public async Task<IActionResult> Deleteroles(int Id)
        {
            using (var _db = new BlogContext())
            {
                try
                {
                    var rol = await _db.Rol.FindAsync(Id);
                    _db.Remove(rol);
                    await _db.SaveChangesAsync();
                    return Ok(rol);
                }
                catch (DbUpdateConcurrencyException)
                {
                    return BadRequest();
                }
            }

        }
    }
}
*/