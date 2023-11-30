using System.Text;
using DependencyInjectionChallenge.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DependencyInjectionChallenge.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class InjectionsController : Controller
    {
        private readonly ITransientService? _transientService;
        private readonly ISingletonService? _singletonService;
        private readonly IScopedService? _scopedService;

        public InjectionsController(ITransientService transientService, ISingletonService singletonService, IScopedService scopedService)
        {
            _transientService = transientService;
            _singletonService = singletonService;
            _scopedService = scopedService;
        }

        [HttpGet("transient")]
        public IActionResult TransientStatus()
        {
            string message = _transientService!.Get();
            return Ok(message);
        }

        [HttpGet("singleton")]
        public IActionResult SingletonStatus()
        {
            string message = _singletonService!.Get();
            return Ok(message);
        }

        [HttpGet("scoped")]
        public IActionResult ScopedStatus()
        {
            string message = _scopedService!.Get();
            return Ok(message);
        }
    }
}
