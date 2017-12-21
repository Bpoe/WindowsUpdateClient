namespace Microsoft.Management.WindowsUpdate.Client
{
    using Interop;

    public class DownloadProgressChangedCallback : IDownloadProgressChangedCallback
    {
        public IDownloadProgress Progress { get; private set; }

        public void Invoke(IDownloadJob downloadJob, IDownloadProgressChangedCallbackArgs callbackArgs)
        {
            this.Progress = callbackArgs.Progress;
        }
    }
}
