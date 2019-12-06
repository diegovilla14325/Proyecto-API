/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using angular.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace angular.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class UsuariorolController : ControllerBase
    {
        // GET api/values
        [HttpGet ("{id?}")]
      public async Task<ActionResult> GetObtener(int? id){
          using(var db=new BlogContext()){
            if(id==null){
                var usurol = await db.Usuariorol.ToListAsync(); 
                return Ok(usurol);
            }else {
                var usuarols = await db.Usuariorol.FindAsync(id);
                return Ok(usuarols);
            }
          }
      }

        // POST api/values
        [HttpPost]
        public async Task<ActionResult> Post([FromBody] Usuariorol valor)
        {
            using(var db= new BlogContext()){
                try{
                    db.Add(new Usuariorol{UsuarioId=valor.UsuarioId,RolId=valor.RolId,Rol=valor.Rol,Usuario=valor.Usuario});
                    await db.SaveChangesAsync();
                    return Ok();

                }catch(DbUpdateConcurrencyException){
                    return BadRequest();
                }
            }
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public async Task<ActionResult> Put(int id, [FromBody] Usuariorol valor)
        {
            using (var _db = new BlogContext())
            {
                if (!ModelState.IsValid || id < 0)
                {
                    return BadRequest(ModelState);
                }
                var usurol = await _db.Usuariorol.FindAsync(id);
                if (valor == null)
                {
                    return NotFound();
                }
                usurol.UsuarioId = valor.UsuarioId;
                usurol.RolId = valor.RolId;
                usurol.Rol = valor.Rol;
                usurol.Usuario= valor.Usuario;
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
        public async Task<IActionResult> Delete(int Id)
        {
            using (var _db = new BlogContext())
            {
                try
                {
                    var usuario = await _db.Usuario.FindAsync(Id);
                    _db.Remove(usuario);
                    await _db.SaveChangesAsync();
                    return Ok(usuario);
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