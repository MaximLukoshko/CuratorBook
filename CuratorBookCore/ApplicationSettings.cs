using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Text;

namespace CuratorBookCore
{
    public sealed class ApplicationSettings
    {
        #region SingletonImplementation

        private static ApplicationSettings instance;
        public static ApplicationSettings Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new ApplicationSettings();
                }
                return instance;
            }
        }

        #endregion SingletonImplementation

        
        #region Configure
        
        private IConfiguration Configuration { get; set; }
        public void Configure(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        #endregion Configure

        #region Settings

        public string ConnectionString
        {
            get
            {
                return Configuration.GetConnectionString("CuratorBookConnection");
            }
        }

        #endregion Settings
    }
}
