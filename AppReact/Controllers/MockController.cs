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
    public class MockController : ControllerBase
    {
        private DummyGeneratorService _dummyGeneratorService;

        public MockController(DummyGeneratorService dummyGeneratorService)
        {
            _dummyGeneratorService = dummyGeneratorService;
        }

        [HttpGet]
        [Route("generateData")]
        public IActionResult GenerateData()
        {
            try
            {
                int totalData = 10;
                _dummyGeneratorService.GenerateLabelRandom(totalData);
                _dummyGeneratorService.GeneratArtistRandom(totalData);
                _dummyGeneratorService.GenerateAlbumRandom(totalData);

                return Ok(true);
            }
            catch(Exception ex)
            {
                return Ok(false);
            }
           
        }

    }
}