using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace TestA.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        [HttpGet]
        public void OnClick()
        {
            string text = "https://jsonplaceholder.typicode.com/posts";
        }
    }
}
