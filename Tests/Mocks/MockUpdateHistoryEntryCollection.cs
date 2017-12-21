namespace Microsoft.Management.WindowsUpdate.Tests.Mocks
{
    using System;
    using System.Collections;
    using Interop;

    public class MockUpdateHistoryEntryCollection : IUpdateHistoryEntryCollection
    {
        public int Count { get; }

        public IUpdateHistoryEntry this[int index]
        {
            get { throw new NotImplementedException(); }
        }

        public IEnumerator GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}
