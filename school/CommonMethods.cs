using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Text;

namespace school
{
    static public class CommonMethods
    {
        public static string getConnectionString(string connectionString)
        {
            string res = string.Empty;

            var builder = new ConfigurationBuilder()
                .SetBasePath(@"C:\C#\OOP\school\school\")
                .AddJsonFile("appSettings.json");

            var config = builder.Build();
            res = config.GetConnectionString(connectionString);

            return res;
        }
    }
}
