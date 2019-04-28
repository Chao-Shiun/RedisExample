using Microsoft.AspNetCore.Mvc;
using RedisWebAPI.DAL.Interface;
using RedisWebAPI.Model;

namespace RedisWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ExampleController : ControllerBase
    {
        private readonly IAccessInteface dbTools;
        public ExampleController(IAccessInteface dbTools)
        {
            this.dbTools = dbTools;
        }

        [HttpGet]
        public string GetConnectionString()
        {
            return "test";
        }

        [HttpPost]
        [Route("[action]")]
        public void SaveString(SaveStringModel model)
        {
            dbTools.StringSet(model.Key, model.Value);
        }
    }
}