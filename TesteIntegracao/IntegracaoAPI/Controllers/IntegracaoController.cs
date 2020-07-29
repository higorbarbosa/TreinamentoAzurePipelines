﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace IntegracaoAPI.Controllers
{
	[ApiController]
	[Route("[controller]")]
	public class IntegracaoController : ControllerBase
	{

        // GET api/Integracao
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/Integracao/5
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            return "value";
        }

        // POST api/Integracao
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/Integracao/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/Integracao/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }

    }
}