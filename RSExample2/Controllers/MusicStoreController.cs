using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Data.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace RSExample2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MusicStoreController : ControllerBase
    {
        private AlbumService _albumService;
        private DummyGeneratorService _dummyGeneratorService;

        public MusicStoreController(AlbumService albumService, DummyGeneratorService dummyGeneratorService)
        {
            _albumService = albumService;
            _dummyGeneratorService = dummyGeneratorService;
        }

        [HttpGet]
        [Route("getAlbums")]
        public IActionResult GetAlbums()
        {
            var albums = _albumService.GetAllAlbums();

            return Ok(albums);
        }
        [HttpGet]
        [Route("generateData")]
        public IActionResult GenerateData()
        {
            try
            {
                int totalData = 0;
                _dummyGeneratorService.GenerateLabelRandom(totalData);
                _dummyGeneratorService.GeneratArtistRandom(totalData);
                _dummyGeneratorService.GenerateAlbumRandom(totalData);

                return Ok(true);
            }
            catch (Exception ex)
            {
                return Ok(false);
            }

        }
    }
}