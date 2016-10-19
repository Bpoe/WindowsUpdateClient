namespace Microsoft.Management.WindowsUpdate
{
    using System;
    using Microsoft.Management.WindowsUpdate.Interop;

    public class WindowsUpdate : IUpdate
    {
        internal IUpdate baseIUpdate = null;

        public WindowsUpdate(IUpdate update)
        {
            this.baseIUpdate = update;
        }

        public void AcceptEula()
        {
            baseIUpdate.AcceptEula();
        }

        public void CopyFromCache(string path, bool toExtractCabFiles)
        {
            baseIUpdate.CopyFromCache(path, toExtractCabFiles);
        }

        public string Title
        {
            get { return baseIUpdate.Title; }
        }

        public bool AutoSelectOnWebSites
        {
            get { return baseIUpdate.AutoSelectOnWebSites; }
        }

        public UpdateCollection BundledUpdates
        {
            get { return baseIUpdate.BundledUpdates; }
        }

        public bool CanRequireSource
        {
            get { return baseIUpdate.CanRequireSource; }
        }

        public ICategoryCollection Categories
        {
            get { return baseIUpdate.Categories; }
        }

        public object Deadline
        {
            get { return baseIUpdate.Deadline; }
        }

        public bool DeltaCompressedContentAvailable
        {
            get { return baseIUpdate.DeltaCompressedContentAvailable; }
        }

        public bool DeltaCompressedContentPreferred
        {
            get { return baseIUpdate.DeltaCompressedContentPreferred; }
        }

        public string Description
        {
            get { return baseIUpdate.Description; }
        }

        public bool EulaAccepted
        {
            get { return baseIUpdate.EulaAccepted; }
        }

        public string EulaText
        {
            get { return baseIUpdate.EulaText; }
        }

        public string HandlerID
        {
            get { return baseIUpdate.HandlerID; }
        }

        public IUpdateIdentity Identity
        {
            get { return baseIUpdate.Identity; }
        }

        public IImageInformation Image
        {
            get { return baseIUpdate.Image; }
        }

        public IInstallationBehavior InstallationBehavior
        {
            get { return baseIUpdate.InstallationBehavior; }
        }

        public bool IsBeta
        {
            get { return baseIUpdate.IsBeta; }
        }

        public bool IsDownloaded
        {
            get { return baseIUpdate.IsDownloaded; }
        }

        public bool IsHidden
        {
            get { return baseIUpdate.IsHidden; }
            set { baseIUpdate.IsHidden = value; }
        }

        public bool IsInstalled
        {
            get { return baseIUpdate.IsInstalled; }
        }

        public bool IsMandatory
        {
            get { return baseIUpdate.IsMandatory; }
        }

        public bool IsUninstallable
        {
            get { return baseIUpdate.IsUninstallable; }
        }

        public StringCollection Languages
        {
            get { return baseIUpdate.Languages; }
        }

        public DateTime LastDeploymentChangeTime
        {
            get { return baseIUpdate.LastDeploymentChangeTime; }
        }

        public decimal MaxDownloadSize
        {
            get { return baseIUpdate.MaxDownloadSize; }
        }

        public decimal MinDownloadSize
        {
            get { return baseIUpdate.MinDownloadSize; }
        }

        public StringCollection MoreInfoUrls
        {
            get { return baseIUpdate.MoreInfoUrls; }
        }

        public string MsrcSeverity
        {
            get { return baseIUpdate.MsrcSeverity; }
        }

        public int RecommendedCpuSpeed
        {
            get { return baseIUpdate.RecommendedCpuSpeed; }
        }

        public int RecommendedHardDiskSpace
        {
            get { return baseIUpdate.RecommendedHardDiskSpace; }
        }

        public int RecommendedMemory
        {
            get { return baseIUpdate.RecommendedMemory; }
        }

        public string ReleaseNotes
        {
            get { return baseIUpdate.ReleaseNotes; }
        }

        public StringCollection SecurityBulletinIDs
        {
            get { return baseIUpdate.SecurityBulletinIDs; }
        }

        public StringCollection SupersededUpdateIDs
        {
            get { return baseIUpdate.SupersededUpdateIDs; }
        }

        public string SupportUrl
        {
            get { return baseIUpdate.SupportUrl; }
        }

        public UpdateType Type
        {
            get { return baseIUpdate.Type; }
        }

        public string UninstallationNotes
        {
            get { return baseIUpdate.UninstallationNotes; }
        }

        public IInstallationBehavior UninstallationBehavior
        {
            get { return baseIUpdate.UninstallationBehavior; }
        }

        public StringCollection UninstallationSteps
        {
            get { return baseIUpdate.UninstallationSteps; }
        }

        public StringCollection KBArticleIDs
        {
            get { return baseIUpdate.KBArticleIDs; }
        }

        public DeploymentAction DeploymentAction
        {
            get { return baseIUpdate.DeploymentAction; }
        }

        public DownloadPriority DownloadPriority
        {
            get { return baseIUpdate.DownloadPriority; }
        }

        public IUpdateDownloadContentCollection DownloadContents
        {
            get { return baseIUpdate.DownloadContents; }
        }
    }
}
