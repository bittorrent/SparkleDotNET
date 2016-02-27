using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SparkleDotNET {

    public class SUConstants {

        public const string SULastCheckTimeKey = "SULastCheckTime";
        public const string SULastProfileSubmitDateKey = "SULastProfileSubmitDate";
        public const string SUPublicRSAKeyKey = "SUPublicRSAKey";
        public const string SUPublicRSAKeyFileKey = "SUPublicRSAKeyFile";
        public const string SUNoUpdateError = "com.Sparkle.NoUpdate";
        public const string SUNoFeedURLError = "com.Sparkle.NoFeedURL";
        public const string SUFeedLoadError = "FeedLoadError";
        public const string SUSignatureError = "com.Sparkle.SignatureError";
        public const string SUNoInstallerError = "com.Sparkle.NoInstallerError";
        public const string SUInstallerFailedToLaunchError = "com.Sparkle.InstallerFailedToLaunch";

        public const string SUNoUnarchiverError = "com.Sparkle.NoUnarchiverError";
        public const string SUExtractionFailedError = "com.Sparkle.ExtractionFailedError";
        public const string SUSkippedVersionKey = "SUSkippedVersion";
        public const string SUUpdateDriverFinishedNotification = "SUUpdateDriverFinished";
        public const string SURecentlyCheckedNotification = "SURecentlyCheckedNotification";
        public const string SUTerminateNotification = "SUTerminateNotification";
        public const string SU1stLaunchNotification = "SU1stLaunchNotification";

        //for bench stats
        public const string Updated = "Updated";
        public const string DownloadCancelled = "DownloadCancelled";
        public const string DownloadClicked = "DownloadClicked";

        public const string SUFeedURLKey = "SUFeedURL";
        public const string SUEnableAutomaticChecksKey = "SUEnableAutomaticChecks";
        public const string SUScheduledCheckIntervalKey = "SUScheduledCheckInterval";
        public const string SUHasLaunchedBeforeKey = "SUHasLaunchedBefore";
        public const string SUSendProfileInfoKey = "SUSendProfileInfo";
        public const string SUExtractedFilesForCleanupKey = "SUExtractedFilesForCleanup";

        public const string SUProfileItemKeyKey = "SUProfileItemKey";
        public const string SUProfileItemDisplayKeyKey = "SUProfileItemDisplayKey";
        public const string SUProfileItemValueKey = "SUProfileItemValue";
        public const string SUProfileItemDisplayValueKey = "SUProfileItemDisplayValue";
        

        public const double SU_DEFAULT_CHECK_INTERVAL = 60 * 60 * 24; // A day
        public const double SU_MIN_CHECK_INTERVAL = 60 * 60; // An hour
    }
}
