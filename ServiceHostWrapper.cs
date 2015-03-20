using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ServiceModel;
using System.ServiceModel.Description;

namespace WcfWindowService
{
    public class ServiceHostWrapper : MarshalByRefObject
    {
        private ServiceHost _serviceHost;
        
        public void CreateHost(Type serviceType, Type serviceType2, Uri address, string address1)
        {
            _serviceHost = new ServiceHost(serviceType, address);
            _serviceHost.AddServiceEndpoint(serviceType2, new BasicHttpBinding(), address1);

            var serviceMetadataBehavior = new ServiceMetadataBehavior
            {
                HttpGetEnabled = true,
                MetadataExporter =
                {
                    PolicyVersion = PolicyVersion.Policy15
                }
            };

            _serviceHost.Description.Behaviors.Add(serviceMetadataBehavior);
        }

        public void Open()
        {
            _serviceHost.Open();
        }

        public void Close()
        {
            _serviceHost.Close();
        }

        public void Abort()
        {
            _serviceHost.Abort();
        } 
    }
}
