using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using CountryManager_API.Data.Persistence;
using CountryManager_API.Models;
using CountryManager_API.Services;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace CountryManager_API.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class CountryController : ControllerBase
    {
        private readonly CountryService service;
        private readonly IMapper mapper;
        private readonly ILogger<CountryController> logger;

        public CountryController(CountryService service, IMapper mapper, ILogger<CountryController> logger)
        {
            this.service = service;
            this.mapper = mapper;
            this.logger = logger;
        }
        [HttpGet]
        
        public async Task<IActionResult> Get()
        {
            var countries = await service.GetAll();
            return Ok(mapper.Map<List<CountryViewModel>>(countries));
        }
        [HttpGet]
        [Route("{id}")]
        public async Task<IActionResult> Get([FromRoute]int id)
        {
            var country = await service.GetById(id);
            return Ok(mapper.Map<CountryViewModel>(country));
        }

        [HttpPost]
        public async Task<IActionResult> Post([FromBody]CountryViewModel model)
        {
            if (!ModelState.IsValid)
                return BadRequest();
            await service.Create(mapper.Map<Country>(model));
            return Ok();
        }

        [HttpPut]
        public async Task<IActionResult> Put([FromBody]CountryViewModel model)
        {
            if (!ModelState.IsValid)
                return BadRequest();
            await service.Update(mapper.Map<Country>(model));
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
            catch(Exception x)
            {
                var msg = x.InnerException?.Message ?? x.Message;
                logger.LogError(msg, "Error al borrar la entidad", $"Id: {id}");
                return ValidationProblem();
            }
            
        }
    }
}