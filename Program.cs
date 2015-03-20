using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Configuration;

namespace WcfWindowService
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        static void Main()
        {
            if (Environment.UserInteractive)
            {
                var server = ConfigurationManager.AppSettings["DatabaseServerInfo"].ToString();

            }
            else
            {
                ServiceBase[] ServicesToRun;
                ServicesToRun = new ServiceBase[] { new Service1()} ;
                ServiceBase.Run(ServicesToRun);
            }
        }

        private static 
    }
}
