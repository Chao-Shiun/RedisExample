using Microsoft.Extensions.Options;
using RedisWebAPI.DAL.Interface;
using RedisWebAPI.Model;

namespace RedisWebAPI.DAL
{
    public class RedisTools : IAccessInteface
    {
        private RedisSetting RedisSetting { get; }
        public RedisTools(IOptions<RedisSetting> redisSetting)
        {
            RedisSetting = redisSetting.Value;
        }
    }
}
