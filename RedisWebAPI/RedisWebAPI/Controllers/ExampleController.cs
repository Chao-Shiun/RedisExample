using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using RedisWebAPI.Model;

namespace RedisWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ExampleController : ControllerBase
    {
        private RedisSetting RedisSetting { get; set; }
        public ExampleController(IOptions<RedisSetting> redisSetting)
        {
            RedisSetting = redisSetting.Value;
        }

        [HttpGet]
        public string GetConnectionString()
        {
            return RedisSetting.ConnectionString;
        }
    }
}