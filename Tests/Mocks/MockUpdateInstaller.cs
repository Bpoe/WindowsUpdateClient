namespace Microsoft.Management.WindowsUpdate.Tests.Mocks
{
    using System;
    using Interop;

    public class MockUpdateInstaller : IUpdateInstaller
    {
        public object parentWindow { get; set; }

        public UpdateCollection Updates { get; set; }

        public bool IsBusy { get; }

        public bool AllowSourcePrompts { get; set; }

        public bool RebootRequiredBeforeInstallation { get; }

        public string ClientApplicationID { get; set; }

        public bool IsForced { get; set; }

        public IInstallationJob BeginInstall(object onProgressChanged, object onCompleted, object state)
        {
            throw new NotImplementedException();
        }

        public IInstallationJob BeginUninstall(object onProgressChanged, object onCompleted, object state)
        {
            throw new NotImplementedException();
        }

        public IInstallationResult EndInstall(IInstallationJob value)
        {
            throw new NotImplementedException();
        }

        public IInstallationResult EndUninstall(IInstallationJob value)
        {
            throw new NotImplementedException();
        }

        public IInstallationResult Install()
        {
            throw new NotImplementedException();
        }

        public IInstallationResult RunWizard(string dialogTitle = "")
        {
            throw new NotImplementedException();
        }

        public IInstallationResult Uninstall()
        {
            throw new NotImplementedException();
        }

        public IntPtr get_ParentHwnd()
        {
            throw new NotImplementedException();
        }

        public void set_ParentHwnd(ref _RemotableHandle retval)
        {
            throw new NotImplementedException();
        }
    }
}
