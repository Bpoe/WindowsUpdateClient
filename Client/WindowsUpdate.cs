namespace Microsoft.Management.WindowsUpdate.Client
{
    using System;
    using Interop;

    public class WindowsUpdate : IUpdate
    {
        internal IUpdate BaseIUpdate;

        public WindowsUpdate(IUpdate update)
        {
            this.BaseIUpdate = update;
        }

        public void AcceptEula()
        {
            this.BaseIUpdate.AcceptEula();
        }

        public void CopyFromCache(string path, bool toExtractCabFiles)
        {
            this.BaseIUpdate.CopyFromCache(path, toExtractCabFiles);
        }

        public string Title
        {
            get { return this.BaseIUpdate.Title; }
        }

        public bool AutoSelectOnWebSites
        {
            get { return this.BaseIUpdate.AutoSelectOnWebSites; }
        }

        public UpdateCollection BundledUpdates
        {
            get { return this.BaseIUpdate.BundledUpdates; }
        }

        public bool CanRequireSource
        {
            get { return this.BaseIUpdate.CanRequireSource; }
        }

        public ICategoryCollection Categories
        {
            get { return this.BaseIUpdate.Categories; }
        }

        public object Deadline
        {
            get { return this.BaseIUpdate.Deadline; }
        }

        public bool DeltaCompressedContentAvailable
        {
            get { return this.BaseIUpdate.DeltaCompressedContentAvailable; }
        }

        public bool DeltaCompressedContentPreferred
        {
            get { return this.BaseIUpdate.DeltaCompressedContentPreferred; }
        }

        public string Description
        {
            get { return this.BaseIUpdate.Description; }
        }

        public bool EulaAccepted
        {
            get { return this.BaseIUpdate.EulaAccepted; }
        }

        public string EulaText
        {
            get { return this.BaseIUpdate.EulaText; }
        }

        public string HandlerID
        {
            get { return this.BaseIUpdate.HandlerID; }
        }

        public IUpdateIdentity Identity
        {
            get { return this.BaseIUpdate.Identity; }
        }

        public IImageInformation Image
        {
            get { return this.BaseIUpdate.Image; }
        }

        public IInstallationBehavior InstallationBehavior
        {
            get { return this.BaseIUpdate.InstallationBehavior; }
        }

        public bool IsBeta
        {
            get { return this.BaseIUpdate.IsBeta; }
        }

        public bool IsDownloaded
        {
            get { return this.BaseIUpdate.IsDownloaded; }
        }

        public bool IsHidden
        {
            get { return this.BaseIUpdate.IsHidden; }
            set { BaseIUpdate.IsHidden = value; }
        }

        public bool IsInstalled
        {
            get { return this.BaseIUpdate.IsInstalled; }
        }

        public bool IsMandatory
        {
            get { return this.BaseIUpdate.IsMandatory; }
        }

        public bool IsUninstallable
        {
            get { return this.BaseIUpdate.IsUninstallable; }
        }

        public StringCollection Languages
        {
            get { return this.BaseIUpdate.Languages; }
        }

        public DateTime LastDeploymentChangeTime
        {
            get { return this.BaseIUpdate.LastDeploymentChangeTime; }
        }

        public decimal MaxDownloadSize
        {
            get { return this.BaseIUpdate.MaxDownloadSize; }
        }

        public decimal MinDownloadSize
        {
            get { return this.BaseIUpdate.MinDownloadSize; }
        }

        public StringCollection MoreInfoUrls
        {
            get { return this.BaseIUpdate.MoreInfoUrls; }
        }

        public string MsrcSeverity
        {
            get { return this.BaseIUpdate.MsrcSeverity; }
        }

        public int RecommendedCpuSpeed
        {
            get { return this.BaseIUpdate.RecommendedCpuSpeed; }
        }

        public int RecommendedHardDiskSpace
        {
            get { return this.BaseIUpdate.RecommendedHardDiskSpace; }
        }

        public int RecommendedMemory
        {
            get { return this.BaseIUpdate.RecommendedMemory; }
        }

        public string ReleaseNotes
        {
            get { return this.BaseIUpdate.ReleaseNotes; }
        }

        public StringCollection SecurityBulletinIDs
        {
            get { return this.BaseIUpdate.SecurityBulletinIDs; }
        }

        public StringCollection SupersededUpdateIDs
        {
            get { return this.BaseIUpdate.SupersededUpdateIDs; }
        }

        public string SupportUrl
        {
            get { return this.BaseIUpdate.SupportUrl; }
        }

        public UpdateType Type
        {
            get { return this.BaseIUpdate.Type; }
        }

        public string UninstallationNotes
        {
            get { return this.BaseIUpdate.UninstallationNotes; }
        }

        public IInstallationBehavior UninstallationBehavior
        {
            get { return this.BaseIUpdate.UninstallationBehavior; }
        }

        public StringCollection UninstallationSteps
        {
            get { return this.BaseIUpdate.UninstallationSteps; }
        }

        public StringCollection KBArticleIDs
        {
            get { return this.BaseIUpdate.KBArticleIDs; }
        }

        public DeploymentAction DeploymentAction
        {
            get { return this.BaseIUpdate.DeploymentAction; }
        }

        public DownloadPriority DownloadPriority
        {
            get { return this.BaseIUpdate.DownloadPriority; }
        }

        public IUpdateDownloadContentCollection DownloadContents
        {
            get { return this.BaseIUpdate.DownloadContents; }
        }
    }
}
