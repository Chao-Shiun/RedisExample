using Microsoft.Extensions.Options;
using RedisWebAPI.DAL.Interface;
using RedisWebAPI.Model;
using StackExchange.Redis;
using System;

namespace RedisWebAPI.DAL
{
    public class RedisTools : IAccessInteface
    {
        private RedisSetting RedisSetting { get; }
        private Lazy<ConnectionMultiplexer> RedisConn { get; }
        private IDatabase RedisDB { get; }

        public RedisTools(IOptions<RedisSetting> redisSetting)
        {
            RedisSetting = redisSetting.Value;

            RedisConn = new Lazy<ConnectionMultiplexer>(() =>
             {
                 if (string.IsNullOrEmpty(RedisSetting.ConnectionString)) throw new InvalidOperationException("Please set Redis connection string.");
                 return ConnectionMultiplexer.Connect(RedisSetting.ConnectionString); ;
             });
            RedisDB = RedisConn.Value.GetDatabase();
        }

        public void StringSet(string key, string value, TimeSpan? expiry = null, When when = When.Always, CommandFlags flags = CommandFlags.None)
        {
            RedisDB.StringSet(key, value, expiry: expiry, when: when, flags: flags);
        }
    }
}
