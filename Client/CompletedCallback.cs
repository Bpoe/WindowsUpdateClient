namespace Microsoft.Management.WindowsUpdate.Client
{
    using System.Threading.Tasks;
    using Interop;

    public class SearchCompletedCallback : CompletedCallback<ISearchJob, ISearchCompletedCallbackArgs>, ISearchCompletedCallback
    {
    }

    public class DownloadCompletedCallback : CompletedCallback<IDownloadJob, IDownloadCompletedCallbackArgs>, IDownloadCompletedCallback
    {
    }

    public class InstallationCompletedCallback : CompletedCallback<IInstallationJob, IInstallationCompletedCallbackArgs>, IInstallationCompletedCallback
    {
    }

    public class CompletedCallback<TJob, TArgs>
    {
        private readonly TaskCompletionSource<bool> taskCompletionSource = new TaskCompletionSource<bool>();

        public TJob Job { get; private set; }

        public TArgs Arguments { get; private set; }

        public void Invoke(TJob job, TArgs args)
        {
            this.Job = job;
            this.Arguments = args;
            this.taskCompletionSource.TrySetResult(true);
        }

        public Task<bool> WaitAsync()
        {
            return this.taskCompletionSource.Task;
        }
    }
}
