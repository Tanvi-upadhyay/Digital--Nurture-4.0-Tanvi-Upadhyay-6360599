using Microsoft.AspNetCore.Mvc;

namespace WebApiHandson.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ValuesController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get() => Ok("GET Request Success");

        [HttpPost]
        public IActionResult Post() => Ok("POST Request Success");

        [HttpPut]
        public IActionResult Put() => Ok("PUT Request Success");

        [HttpDelete]
        public IActionResult Delete() => Ok("DELETE Request Success");
    }
}
