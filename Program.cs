using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Configuration;
using System.IO;
using System.Reflection;

namespace WcfWindowService
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        static void Main()
        {
            var _dllFiles = Directory.GetFiles(Environment.CurrentDirectory, "*.dll");
            Assembly[] assemblies = new Assembly[_dllFiles.Length];
            int i = 0;
            foreach (var a in _dllFiles)
            {
                assemblies[i++] = Assembly.Load(a.ToString());

            }
            if (Environment.UserInteractive)
            {
                
                var server = ConfigurationManager.AppSettings["DatabaseServerInfo"].ToString();
                var server1 = ConfigurationManager.AppSettings["DatabaseServerInfo1"].ToString();

            }
            else
            {
                ServiceBase[] ServicesToRun;
                ServicesToRun = new ServiceBase[] { new Service1()} ;
                ServiceBase.Run(ServicesToRun);
            }
        }

        //private static 
    }
}
