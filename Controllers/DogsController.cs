using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Description;
using DogApp.Models;

namespace DogApp.Controllers
{
    public class DogsController : ApiController
    {
        private DogAppContext db = new DogAppContext();

        // GET: api/Dogs
        public IQueryable<Dog> GetDogs()
        {
            return db.Dogs;
        }

        // GET: api/Dogs/5
        [ResponseType(typeof(Dog))]
        public async Task<IHttpActionResult> GetDog(int id)
        {
            Dog dog = await db.Dogs.FindAsync(id);
            if (dog == null)
            {
                return NotFound();
            }

            return Ok(dog);
        }

        // PUT: api/Dogs/5
        [ResponseType(typeof(void))]
        public async Task<IHttpActionResult> PutDog(int id, Dog dog)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != dog.Id)
            {
                return BadRequest();
            }

            db.Entry(dog).State = EntityState.Modified;

            try
            {
                await db.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!DogExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return StatusCode(HttpStatusCode.NoContent);
        }

        // POST: api/Dogs
        [ResponseType(typeof(Dog))]
        public async Task<IHttpActionResult> PostDog(Dog dog)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Dogs.Add(dog);
            await db.SaveChangesAsync();

            return CreatedAtRoute("DefaultApi", new { id = dog.Id }, dog);
        }

        // DELETE: api/Dogs/5
        [ResponseType(typeof(Dog))]
        public async Task<IHttpActionResult> DeleteDog(int id)
        {
            Dog dog = await db.Dogs.FindAsync(id);
            if (dog == null)
            {
                return NotFound();
            }

            db.Dogs.Remove(dog);
            await db.SaveChangesAsync();

            return Ok(dog);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool DogExists(int id)
        {
            return db.Dogs.Count(e => e.Id == id) > 0;
        }
    }
}