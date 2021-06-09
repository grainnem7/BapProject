using BapProject.Repositories;
using Microsoft.AspNetCore.Mvc;
using System;

namespace BapProject.Controllers
{
    [Route("api/app")]
    [ApiController]
    public class AppController : ControllerBase
    {
        private IAppRepository appRepository;

        public AppController(IAppRepository appRepository)
        {
            this.appRepository = appRepository;
        }

        [HttpGet]
        //[Route("apps")]
        public IActionResult Index()
        {
            try
            {
                var messages = appRepository.GetBapApps();
                return Ok(messages);
            }
            catch (Exception)
            {
                return BadRequest();
            }
        }
        [HttpGet("{appId}")]
        public IActionResult indexByAppId(int appId)
        {
            try
            {
                ViewModels.AppViewModel app = appRepository.GetBapApp(appId);
                if (app == null)
                {
                    return NotFound();
                }
                return Ok(app);
            }
            catch (Exception)
            {
                return BadRequest();
            }
        }

    }
}
