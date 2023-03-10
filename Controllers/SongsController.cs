using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using api.Models;

namespace api.Controllers
{
    [Route("api/Songs")]
    [ApiController]
    public class SongsController : ControllerBase
    {
        //Create : POST
        //Read : GET
        //Update : PUT
        //Delete : DELETE

        // GET: api/Songs
        [HttpGet]
        public IEnumerable<Song> Get()
        {
            List<Song> songs = new List<Song>();
            Song mySong = new Song();
            mySong.Title = "Evan";
            mySong.Artist = "Cool Dude";
            mySong.ID = 0;
            mySong.Favorited = false;
            mySong.Deleted = false;
            mySong.DateTimeAdded = DateTime.Now;
            songs.Add(mySong);
            return songs;
            //return new string[] { "Title", "Artist" };
        }

        // GET: api/Songs/5
        [HttpGet("{id}", Name = "GetSong")]
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Songs
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT: api/Songs/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE: api/Songs/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
