namespace Microsoft.Management.WindowsUpdate
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using Interop;
    using System.Threading.Tasks;
    using System.Threading;

    public class WindowsUpdateClient
    {
        private UpdateSession session;

        public UpdateServer UpdateServerSelection { get; set; }

        public WindowsUpdateClient()
            : this(UpdateServer.Default)
        {
        }

        public WindowsUpdateClient(UpdateServer updateServerSelection)
            : this(
                  updateServerSelection,
                  new UpdateSession { ClientApplicationID = "Microsoft.Management.WindowsUpdate.Client" })
        {
        }

        public WindowsUpdateClient(UpdateServer updateServerSelection, UpdateSession session)
        {
            this.session = session;
            this.UpdateServerSelection = updateServerSelection;
        }

        public IEnumerable<WindowsUpdate> Search()
        {
            var criteria = new Dictionary<string, object>()
            {
                { "IsInstalled", false },
                { "IsHidden", false },
            };

            return this.Search(criteria);
        }

        public IEnumerable<WindowsUpdate> Search(IDictionary<string, object> criteria)
        {
            var updates = new List<WindowsUpdate>();

            try
            {
                var searcher = this.session.CreateUpdateSearcher();
                searcher.Online = true;
                searcher.ServerSelection = (ServerSelection)this.UpdateServerSelection;
                var searchResults = searcher.Search(GetCriteriaString(criteria));

                foreach (IUpdate update in searchResults.Updates)
                {
                    updates.Add(new WindowsUpdate(update));
                }

                return updates as IEnumerable<WindowsUpdate>;
            }
            catch
            {
                throw;
            }
        }

        public OperationResultCode Download(IEnumerable<WindowsUpdate> updates)
        {
            var downloader = this.session.CreateUpdateDownloader();
            downloader.Updates = new UpdateCollection();
            foreach (var update in updates)
            {
                downloader.Updates.Add(update.baseIUpdate);
            }

            var result = downloader.Download();
            return (OperationResultCode)result.ResultCode;
        }

        public OperationResultCode Install(IEnumerable<WindowsUpdate> updates)
        {
            var installer = this.session.CreateUpdateInstaller();

            installer.Updates = new UpdateCollection();
            foreach (var update in updates)
            {
                installer.Updates.Add(update.baseIUpdate);
            }

            var result = installer.Install();
            return (OperationResultCode)result.ResultCode;
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
    }
}