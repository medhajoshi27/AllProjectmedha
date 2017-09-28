using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Project_Web1
{
    [assembly: OwinStartup(typeof(Project_Web1.App_Start.Startup))]
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}