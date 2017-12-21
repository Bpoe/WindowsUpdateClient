namespace Microsoft.Management.WindowsUpdate.Client
{
    using System.Collections.Generic;
    using System.Text;
    using Interop;
    using System.Threading.Tasks;
    using System.Threading;

    public class WindowsUpdateClient
    {
        private string DefaultCriteria = "IsInstalled=0 AND IsHidden=0";

        private readonly IUpdateSession3 session;

        public UpdateServer UpdateServerSelection { get; set; }

        public WindowsUpdateClient()
            : this(UpdateServer.Default)
        {
        }

        public WindowsUpdateClient(UpdateServer updateServerSelection)
            : this(updateServerSelection,
                  new UpdateSession { ClientApplicationID = "Microsoft.Management.WindowsUpdate.Client" })
        {
        }

        public WindowsUpdateClient(UpdateServer updateServerSelection, IUpdateSession3 session)
        {
            this.session = session;
            this.UpdateServerSelection = updateServerSelection;
        }

        public ISearchResult Search()
        {
            return this.Search(DefaultCriteria);
        }

        public ISearchResult Search(string criteria)
        {
            var searcher = GetUpdateSearcher();
            return searcher.Search(criteria);
        }

        public async Task<ISearchResult> SearchAsync(CancellationToken cancellationToken)
        {
            return await this.SearchAsync(DefaultCriteria, cancellationToken);
        }

        public async Task<ISearchResult> SearchAsync(IDictionary<string, object> criteria, CancellationToken cancellationToken)
        {
            return await this.SearchAsync(GetCriteriaString(criteria), cancellationToken);
        }

        public async Task<ISearchResult> SearchAsync(string criteria, CancellationToken cancellationToken)
        {
            var searcher = GetUpdateSearcher();

            var callback = new SearchCompletedCallback();
            var job = searcher.BeginSearch(criteria, callback, null);

            if(await callback.WaitAsync() == false)
            {
                job.RequestAbort();
            }

            if(cancellationToken.IsCancellationRequested)
            {
                job.RequestAbort();
            }

            return searcher.EndSearch(job);
        }

        public IDownloadResult Download(UpdateCollection updates)
        {
            var downloader = this.session.CreateUpdateDownloader();
            downloader.Updates = updates;
            return downloader.Download();
        }

        public async Task<IDownloadResult> DownloadAsync(UpdateCollection updates, CancellationToken cancellationToken)
        {
            var downloader = this.session.CreateUpdateDownloader();
            downloader.Updates = updates;

            var completedCallback = new DownloadCompletedCallback();
            var progressCallback = new DownloadProgressChangedCallback();

            var job = downloader.BeginDownload(progressCallback, completedCallback, null);

            if(await completedCallback.WaitAsync() == false)
            {
                job.RequestAbort();
            }

            if(cancellationToken.IsCancellationRequested)
            {
                job.RequestAbort();
            }

            return downloader.EndDownload(job);
        }

        public IInstallationResult Install(UpdateCollection updates)
        {
            var installer = this.session.CreateUpdateInstaller();
            installer.Updates = updates;
            return installer.Install();
        }

        public async Task<IInstallationResult> InstallAsync(UpdateCollection updates, CancellationToken cancellationToken)
        {
            var installer = this.session.CreateUpdateInstaller();
            installer.Updates = updates;

            var completedCallback = new InstallationCompletedCallback();
            var progressCallback = new InstallationProgressChangedCallback();

            var job = installer.BeginInstall(progressCallback, completedCallback, null);

            if(await completedCallback.WaitAsync() == false)
            {
                job.RequestAbort();
            }

            if(cancellationToken.IsCancellationRequested)
            {
                job.RequestAbort();
            }

            return installer.EndInstall(job);
        }

        private static string GetCriteriaString(IDictionary<string, object> criteria)
        {
            var criteriaString = new StringBuilder();

            foreach (var pair in criteria)
            {
                if (criteriaString.Length != 0)
                {
                    criteriaString.Append(" AND ");
                }

                string stringValue;
                var boolValue = pair.Value as bool?;
                if (boolValue.HasValue)
                {
                    stringValue = boolValue.Value ? "1" : "0";
                }
                else
                {
                    stringValue = pair.Value.ToString();
                }

                criteriaString.AppendFormat("{0}={1}", pair.Key, stringValue);
            }

            return criteriaString.ToString();
        }

        private IUpdateSearcher GetUpdateSearcher()
        {
            var searcher = this.session.CreateUpdateSearcher();
            searcher.Online = true;
            searcher.ServerSelection = (ServerSelection)this.UpdateServerSelection;
            return searcher;
        }
    }
}