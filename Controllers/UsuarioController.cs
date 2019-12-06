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
    public class UsuarioController : ControllerBase
    {
        // GET api/values
        [HttpGet ("{id?}")]
      public async Task<ActionResult> GetObtener(int? id){
          using(var db=new BlogContext()){
            if(id==null){
                var usuarios = await db.Usuario.ToListAsync(); 
                return Ok(usuarios);
            }else {
                var usuario = await db.Usuario.FindAsync(id);
                return Ok(usuario);
            }
          }
      }

        // POST api/values
        [HttpPost]
        public async Task<ActionResult> Post([FromBody] Usuario valor)
        {
            using(var db= new BlogContext()){
                try{
                    db.Add(new Usuario{Nombre=valor.Nombre,UsuarioId=valor.UsuarioId,Contraseña=valor.Contraseña});
                    await db.SaveChangesAsync();
                    return Ok();

                }catch(DbUpdateConcurrencyException){
                    return BadRequest();
                }
            }
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public async Task<ActionResult> Put(int id, [FromBody] Usuario valor)
        {
            using (var _db = new BlogContext())
            {
                if (!ModelState.IsValid || id < 0)
                {
                    return BadRequest(ModelState);
                }
                var usuario = await _db.Usuario.FindAsync(id);
                if (valor == null)
                {
                    return NotFound();
                }
                usuario.Nombre = valor.Nombre;
                usuario.UsuarioId = valor.UsuarioId;
                usuario.Contraseña = valor.Contraseña;
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