using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using CountryManager_API.Data.Persistence;
using CountryManager_API.Models;
using CountryManager_API.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace CountryManager_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SubdivisionController : ControllerBase
    {
        private readonly SubdivisionService service;
        private readonly IMapper mapper;
        private readonly ILogger<SubdivisionController> logger;

        public SubdivisionController(SubdivisionService service, IMapper mapper, ILogger<SubdivisionController> logger)
        {
            this.service = service;
            this.mapper = mapper;
            this.logger = logger;
        }
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var subdivisions = await service.GetAll();
            return Ok(mapper.Map<List<SubdivisionModel>>(subdivisions));
        }
        [HttpGet]
        [Route("{id}")]
        public async Task<IActionResult> Get([FromRoute]int id)
        {
            var subdivision = await service.GetById(id);
            return Ok(mapper.Map<SubdivisionModel>(subdivision));
        }

        [HttpGet]
        [Route("seek")]
        public async Task<IActionResult> Get([FromQuery]SubdivisionModel filter)
        {
            var result = await service.Seek(mapper.Map<Subdivision>(filter));
            return Ok(mapper.Map<SubdivisionModel>(result));
        }

        [HttpPost]
        public async Task<IActionResult> Post([FromBody]SubdivisionModel model)
        {
            if (!ModelState.IsValid)
                return BadRequest();
            await service.Create(mapper.Map<Subdivision>(model));
            return Ok();
        }

        [HttpPut]
        public async Task<IActionResult> Put([FromBody]SubdivisionModel model)
        {
            if (!ModelState.IsValid)
                return BadRequest();
            await service.Update(mapper.Map<Subdivision>(model));
            return Ok();
        }

        [HttpDelete]
        [Route("{id}")]
        public async Task<IActionResult> Delete([FromRoute]int id)
        {
            if (id <= 0)
            {
                return BadRequest();
            }
            try
            {
                await service.Delete(id);
                return Ok();
            }
            catch (Exception x)
            {
                var msg = x.InnerException?.Message ?? x.Message;
                logger.LogError(msg, "Error al borrar la entidad", $"Id: {id}");
                return ValidationProblem();
            }

        }
    }
}