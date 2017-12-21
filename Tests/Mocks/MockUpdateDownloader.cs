namespace Microsoft.Management.WindowsUpdate.Tests.Mocks
{
    using System;
    using Interop;

    public class MockUpdateDownloader : UpdateDownloader
    {
        public string ClientApplicationID { get; set; }

        public bool IsForced { get; set; }

        public DownloadPriority Priority { get; set; }

        public UpdateCollection Updates { get; set; }

        public IDownloadJob BeginDownload(object onProgressChanged, object onCompleted, object state)
        {
            throw new NotImplementedException();
        }

        public IDownloadResult Download()
        {
            throw new NotImplementedException();
        }

        public IDownloadResult EndDownload(IDownloadJob value)
        {
            throw new NotImplementedException();
        }
    }
}
