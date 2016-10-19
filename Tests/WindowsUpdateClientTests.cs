namespace Microsoft.Management.WindowsUpdate.Tests
{
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading;
    using Microsoft.Management.WindowsUpdate;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class WindowsUpdateClientTests
    {
        [TestMethod]
        public void Search()
        {
            var client = new WindowsUpdateClient(UpdateServer.WindowsUpdate);
            var results = client.Search();
            Assert.IsNotNull(results);
            Assert.IsTrue(results.Any());
        }

        [TestMethod]
        public void Download()
        {
            var client = new WindowsUpdateClient(UpdateServer.WindowsUpdate);
            var results = client.Search();
            Assert.IsNotNull(results);
            Assert.IsTrue(results.Any());

            var downloadResult = client.Download(results);
            Assert.AreEqual(OperationResultCode.Succeeded, downloadResult);
        }

        [TestMethod]
        public void GetAllUpdates()
        {
            var criteria = new Dictionary<string, object>()
            {
                { "IsHidden", false },
                { "DeploymentAction", "*" },
            };

            var client = new WindowsUpdateClient(UpdateServer.WindowsUpdate);
            var results = client.Search(criteria);
            Assert.IsNotNull(results);
            Assert.IsTrue(results.Any());
        }
    }
}
