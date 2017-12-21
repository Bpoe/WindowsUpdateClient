namespace Microsoft.Management.WindowsUpdate.Tests.Mocks
{
    using Interop;

    public class MockUpdateSession : IUpdateSession3
    {
        public string ClientApplicationID { get; set; }

        public bool ReadOnly { get; }

        public WebProxy WebProxy { get; set; }

        public uint UserLocale { get; set; }

        public IUpdateSearcher CreateUpdateSearcher()
        {
            return new MockUpdateSearcher();
        }

        public UpdateDownloader CreateUpdateDownloader()
        {
            return new MockUpdateDownloader();
        }

        public IUpdateInstaller CreateUpdateInstaller()
        {
            return new MockUpdateInstaller();
        }

        public UpdateServiceManager CreateUpdateServiceManager()
        {
            return new MockUpdateServiceManager();
        }

        public IUpdateHistoryEntryCollection QueryHistory(string criteria, int startIndex, int count)
        {
            return new MockUpdateHistoryEntryCollection();
        }
    }
}
