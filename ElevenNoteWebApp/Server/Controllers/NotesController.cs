using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ElevenNoteWebApp.Server.Services.Note;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ElevenNoteWebApp.Server.Controllers
{
    [Route("api/[controller]")]
    public class NotesController : Controller
    {
        private readonly INoteService noteService;
        public NotesController(INoteService noteService)
        {
            _noteService = noteService;
        }
        // GET: api/values
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}

