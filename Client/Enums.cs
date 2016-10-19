namespace Microsoft.Management.WindowsUpdate
{
    using System.Collections.Generic;

    public enum UpdateServer
    {
        Default = 0,
        ManagedServer = 1,
        WindowsUpdate = 2,
        Others = 3
    }

    public enum OperationResultCode
    {
        NotStarted = 0,
        InProgress = 1,
        Succeeded = 2,
        SucceededWithErrors = 3,
        Failed = 4,
        Aborted = 5
    }
}
