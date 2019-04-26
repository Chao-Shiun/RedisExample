using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
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
    }
}