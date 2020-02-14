using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Data.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AppReact.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AlbumController : ControllerBase
    {
        private AlbumService _albumService;

        public AlbumController(AlbumService albumService)
        {
            _albumService = albumService;
        }

        [HttpGet]
        [Route("getAlbums")]
        public IActionResult GetAlbums()
        {
            var albums = _albumService.GetAllAlbums();

            return Ok(albums);
        }
    }
}