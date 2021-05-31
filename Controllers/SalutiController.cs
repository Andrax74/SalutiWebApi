using System;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using saluti_web_api.Models;

namespace saluti_web_api.Controllers
{
    [ApiController]
    [Produces("application/json")]
    [Route("api/saluti")]
    public class SalutiController : Controller
    {
        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public IActionResult TestConnex()
        {
            return Ok(new InfoMsg(DateTime.Today, $"Saluti sono la tua prima web api in Azure App Services"));
        }
    }
}