namespace Microsoft.Management.WindowsUpdate.Tests.Mocks
{
    using System;
    using Interop;

    public class MockUpdateSearcher : IUpdateSearcher3
    {
        public bool CanAutomaticallyUpgradeService { get; set; }

        public string ClientApplicationID { get; set; }

        public bool IncludePotentiallySupersededUpdates { get; set; }

        public ServerSelection ServerSelection { get; set; }

        public bool Online { get; set; }

        public string ServiceID { get; set; }

        public bool IgnoreDownloadPriority { get; set; }

        public SearchScope SearchScope { get; set; }

        public ISearchJob BeginSearch(string criteria, object onCompleted, object state)
        {
            throw new NotImplementedException();
        }

        public ISearchResult EndSearch(ISearchJob searchJob)
        {
            throw new NotImplementedException();
        }

        public string EscapeString(string unescaped)
        {
            throw new NotImplementedException();
        }

        public IUpdateHistoryEntryCollection QueryHistory(int startIndex, int count)
        {
            throw new NotImplementedException();
        }

        public ISearchResult Search(string criteria)
        {
            throw new NotImplementedException();
        }

        public int GetTotalHistoryCount()
        {
            throw new NotImplementedException();
        }
    }
}
