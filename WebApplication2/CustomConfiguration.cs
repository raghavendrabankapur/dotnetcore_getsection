using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication2
{
    public class CustomConfiguration
    {
        IConfiguration config = null;

        public CustomConfiguration()
        {
            config = new ConfigurationBuilder()
                .SetBasePath($"{Directory.GetCurrentDirectory()}")
                .AddJsonFile($"data.json").Build();
        }

        public string Section(string key)
        {
            var data = config.GetSection(key);
            return data.Value;
        }
    }
}
