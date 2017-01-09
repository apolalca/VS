using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.ModelBinding;
using System.Web.Http.OData;
using System.Web.Http.OData.Routing;
using WebApi.Models;
using WebApi_Ent;

//https://www.youtube.com/watch?v=jF38zIiX4uE

namespace WebApi.Controllers
{
    /*
    The WebApiConfig class may require additional changes to add a route for this controller. Merge these statements into the Register method of the WebApiConfig class as applicable. Note that OData URLs are case sensitive.

    using System.Web.Http.OData.Builder;
    using System.Web.Http.OData.Extensions;
    using WebApi_Ent;
    ODataConventionModelBuilder builder = new ODataConventionModelBuilder();
    builder.EntitySet<Persona>("Persona");
    config.Routes.MapODataServiceRoute("odata", "odata", builder.GetEdmModel());
    */
    public class PersonaController : ODataController
    {
        private PersonaContext db = new PersonaContext();

        // GET: odata/Persona
        [EnableQuery]
        public IQueryable<Persona> GetPersona()
        {
            return db.Personas;
        }

        // GET: odata/Persona(5)
        [EnableQuery]
        public SingleResult<Persona> GetPersona([FromODataUri] int key)
        {
            return SingleResult.Create(db.Personas.Where(persona => persona.id == key));
        }

        // PUT: odata/Persona(5)
        public IHttpActionResult Put([FromODataUri] int key, Delta<Persona> patch)
        {
            Validate(patch.GetEntity());

            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            Persona persona = db.Personas.Find(key);
            if (persona == null)
            {
                return NotFound();
            }

            patch.Put(persona);

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!PersonaExists(key))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return Updated(persona);
        }

        // POST: odata/Persona
        public IHttpActionResult Post(Persona persona)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Personas.Add(persona);
            db.SaveChanges();

            return Created(persona);
        }

        // PATCH: odata/Persona(5)
        [AcceptVerbs("PATCH", "MERGE")]
        public IHttpActionResult Patch([FromODataUri] int key, Delta<Persona> patch)
        {
            Validate(patch.GetEntity());

            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            Persona persona = db.Personas.Find(key);
            if (persona == null)
            {
                return NotFound();
            }

            patch.Patch(persona);

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!PersonaExists(key))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return Updated(persona);
        }

        // DELETE: odata/Persona(5)
        public IHttpActionResult Delete([FromODataUri] int key)
        {
            Persona persona = db.Personas.Find(key);
            if (persona == null)
            {
                return NotFound();
            }

            db.Personas.Remove(persona);
            db.SaveChanges();

            return StatusCode(HttpStatusCode.NoContent);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool PersonaExists(int key)
        {
            return db.Personas.Count(e => e.id == key) > 0;
        }
    }
}
