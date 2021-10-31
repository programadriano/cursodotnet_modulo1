using API.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        private readonly ILifecycleService _service;
        private readonly Lifecycle2Service _service2;

        public ValuesController(ILifecycleService service, Lifecycle2Service service2)
        {
            _service = service;
            _service2 = service2;
        }


        [HttpGet]
        public IActionResult Get()
        {
            var result = new List<DateTime>();
            result.Add(_service.DataAtual());
            result.Add(_service2.DataAtual());

            return Ok(result);
        }
    }
}
