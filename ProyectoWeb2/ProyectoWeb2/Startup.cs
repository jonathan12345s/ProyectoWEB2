﻿using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ProyectoWeb2.Startup))]
namespace ProyectoWeb2
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
