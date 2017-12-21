namespace Microsoft.Management.WindowsUpdate.Client
{
    using Interop;

    public class InstallationProgressChangedCallback : IInstallationProgressChangedCallback
    {
        public IInstallationProgress Progress { get; private set; }

        public void Invoke(IInstallationJob installationJob, IInstallationProgressChangedCallbackArgs callbackArgs)
        {
            this.Progress = callbackArgs.Progress;
        }
    }
}
