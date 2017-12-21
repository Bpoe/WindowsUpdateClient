namespace Microsoft.Management.WindowsUpdate.Tests
{
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading;
    using Client;
    using Interop;
    using VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class WindowsUpdateClientTests
    {
        [TestMethod]
        public void Search()
        {
            var client = new WindowsUpdateClient(UpdateServer.Default);
            var results = client.Search("IsInstalled=1");
            Assert.IsNotNull(results);
            Assert.IsNotNull(results.Updates);
            Assert.IsTrue(ToArray(results.Updates).Any());
        }

        [TestMethod]
        public void SearchAsync()
        {
            var client = new WindowsUpdateClient(UpdateServer.Default);
            var results = client.SearchAsync("IsInstalled=1", CancellationToken.None).Result;
            Assert.IsNotNull(results);
            Assert.IsNotNull(results.Updates);
            Assert.IsTrue(ToArray(results.Updates).Any());
        }

        [TestMethod]
        public void Download()
        {
            var client = new WindowsUpdateClient(UpdateServer.WindowsUpdate);
            var results = client.Search();
            Assert.IsNotNull(results);
            Assert.IsNotNull(results.Updates);
            Assert.IsTrue(ToArray(results.Updates).Any());

            var downloadResult = client.Download(results.Updates);
            Assert.AreEqual((int)Client.OperationResultCode.Succeeded, (int)downloadResult.ResultCode);
        }

        [TestMethod]
        public void DownloadAsync()
        {
            var client = new WindowsUpdateClient(UpdateServer.WindowsUpdate);
            var results = client.SearchAsync(CancellationToken.None).Result;
            Assert.IsNotNull(results);
            Assert.IsNotNull(results.Updates);
            Assert.IsTrue(ToArray(results.Updates).Any());

            var downloadResult = client.DownloadAsync(results.Updates, CancellationToken.None).Result;
            Assert.AreEqual((int)Client.OperationResultCode.Succeeded, (int)downloadResult.ResultCode);
        }

        [TestMethod]
        public void GetAllUpdates()
        {
            const string Criteria = "IsHidden=0 AND DeploymentAction=*";

            var client = new WindowsUpdateClient(UpdateServer.WindowsUpdate);
            var results = client.Search(Criteria);
            Assert.IsNotNull(results);
            Assert.IsNotNull(results.Updates);
            Assert.IsTrue(ToArray(results.Updates).Any());
        }

        private static IEnumerable<IUpdate> ToArray(IUpdateCollection updates)
        {
            var updatesArray = new IUpdate[updates.Count];
            for (var i = 0; i < updates.Count; i++)
            {
                updatesArray[i] = updates[i];
            }

            return updatesArray;
        }
    }
}
