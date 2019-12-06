using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using angular.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace angular.Controllers
{
    [Route("[controller]/[action]")]
    [ApiController]
    public class postController : ControllerBase
    {
        // GET api/values
        [HttpGet ("{id?}")]
        public async Task<ActionResult> Getpost(int? id){
            using(var db=new BlogContext()){
                if(id==null){
                    var pot = await db.Post.ToListAsync(); 
                    return Ok(pot);
                }else {
                    var pott = await db.Post.FindAsync(id);
                    return Ok(pott);
                }
            }
        }

        // POST api/values
        [HttpPost]
        public async Task<ActionResult> Post([FromBody] Post valor)
        {
            using(var db= new BlogContext()){
                try{
                    db.Add(new Post{post1=valor.post1});
                    await db.SaveChangesAsync();
                    return Ok();

                }catch(DbUpdateConcurrencyException){
                    return BadRequest();
                }
            }
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public async Task<ActionResult> Put(int id, [FromBody] Post valor)
        {
            using (var _db = new BlogContext())
            {
                if (!ModelState.IsValid || id < 0)
                {
                    return BadRequest(ModelState);
                }
                var p = await _db.Post.FindAsync(id);
                if (valor == null)
                {
                    return NotFound();
                }
                //p.UsuarioId = valor.UsuarioId;
                p.post1 = valor.post1;
               // p.Usuario = valor.Usuario;
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
                    var p = await _db.Post.FindAsync(Id);
                    _db.Remove(p);
                    await _db.SaveChangesAsync();
                    return Ok(p);
                }
                catch (DbUpdateConcurrencyException)
                {
                    return BadRequest();
                }
            }

        }
    }
}
