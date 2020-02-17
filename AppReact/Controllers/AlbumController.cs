﻿using System;
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
        private DummyGeneratorService _dummyGeneratorService;

        public AlbumController(AlbumService albumService, DummyGeneratorService dummyGeneratorService)
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
        [Route("generateData/{totalData}")]
        public IActionResult GenerateData(int totalData)
        {
            try
            {
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