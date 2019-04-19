using System.Collections.Generic;

namespace BunkerSoftServidor.Controllers
{

    [Route("api/[controller]")]
    [Produces("application/json")]
    public class ValuesController: Controller
    {
    private readonly IApplicationRepository  _repository;
    
        public ValuesController(IApplicationRepository repository)
        {
            _repository = repository;
        }
  
        // GET api/values
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            //var listado=_repository.FindAllAsync().ToList();
            return new string[] { "a", "b", "c", "Luis" };
            //return OK(listado);
        }

    
    }

 
}
