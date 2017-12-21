namespace Microsoft.Management.WindowsUpdate.Tests.Mocks
{
    using System;
    using Interop;

    public class MockUpdateServiceManager : UpdateServiceManager
    {
        public IUpdateServiceCollection Services { get; }

        public string ClientApplicationID { get; set; }

        public IUpdateService AddService(string serviceId, string authorizationCabPath)
        {
            throw new NotImplementedException();
        }

        public IUpdateServiceRegistration AddService2(string serviceId, int flags, string authorizationCabPath)
        {
            throw new NotImplementedException();
        }

        public void RegisterServiceWithAU(string serviceId)
        {
            throw new NotImplementedException();
        }

        public void RemoveService(string serviceId)
        {
            throw new NotImplementedException();
        }

        public void UnregisterServiceWithAU(string serviceId)
        {
            throw new NotImplementedException();
        }

        public IUpdateService AddScanPackageService(string serviceName, string scanFileLocation, int flags)
        {
            throw new NotImplementedException();
        }

        public void SetOption(string optionName, object optionValue)
        {
            throw new NotImplementedException();
        }

        public IUpdateServiceRegistration QueryServiceRegistration(string serviceId)
        {
            throw new NotImplementedException();
        }
    }
}
