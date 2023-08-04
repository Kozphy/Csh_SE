using DI_Container.Interface;
using DI_Container.SampleDI;
using Microsoft.AspNetCore.Mvc;

namespace DI_Container.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class SampleController : Controller
    {
        private readonly SampleService _sampleService;
        private readonly ITransient _transient;
        private readonly IScoped _scoped;
        private readonly ISingleton _singleton;
        public SampleController(SampleService service,ITransient transient, IScoped scoped, ISingleton singleton)
        {
            _sampleService = service;
            _transient = transient;
            _scoped = scoped;
            _singleton = singleton;
        }

        [HttpGet]
        public ActionResult<IDictionary<string, string>> Get()
        { 
            var serviceHashCode = _sampleService.GetSampleHashCode();
            var contollerHashCode = $"Transient: {_transient.GetHashCode()}, "
                + $"Scoped: {_scoped.GetHashCode()}, "
                +$"Singleton: {_singleton.GetHashCode()}";
            return new Dictionary<string, string> {
                { "Service", serviceHashCode },
                {"Contoller", contollerHashCode }
            };
        }
    }
}
