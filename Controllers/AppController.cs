using BapProject.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BapProject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AppController : ControllerBase
    {
        private IAppRepository appRepository;

        public AppController(IAppRepository appRepository)
        {
            this.appRepository = appRepository;
        }

        [HttpGet]
        [Route("apps")]
        public IActionResult GetBapApps()
        {
            try
            {
                var messages = appRepository.GetBapApps();
                if (messages == null)
                {
                    return NotFound();
                }

                return Ok(messages);
            }
            catch (Exception)
            {
                return BadRequest();
            }
        }
    }
}
