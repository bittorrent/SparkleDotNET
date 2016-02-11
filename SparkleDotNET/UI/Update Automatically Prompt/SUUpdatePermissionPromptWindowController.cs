using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using KNFoundation;

namespace SparkleDotNET {

    public interface SUUpdatePermissionPromptWindowControllerDelegate {

        void PermissionPromptDidComplete(bool shouldCheckForUpdates, bool shouldSendSystemInfo);
    }

    class SUUpdatePermissionPromptWindowController : KNWindowController {

        private SUUpdatePermissionPromptViewController viewController;
        bool sendDelegateOnWindowClose;
        SUUpdatePermissionPromptWindow updatePermissionPromptWindow;

        public SUUpdatePermissionPromptWindowController(SUHost host)
            : base(new SUUpdatePermissionPromptWindow()) {

                Window.Icon = host.Icon;
                Window.Topmost = true;

                updatePermissionPromptWindow = Window is SUUpdatePermissionPromptWindow ? (SUUpdatePermissionPromptWindow)Window : null;

                viewController = new SUUpdatePermissionPromptViewController(host);
                viewController.CheckAutomaticallyButton.Click += CheckAutomatically;
                viewController.DontCheckButton.Click += DontCheck;

                ViewController = viewController;
                sendDelegateOnWindowClose = true;
        }

        void WindowIsClosing() {
            if (sendDelegateOnWindowClose) {
                if (Delegate != null) {
                    Delegate.PermissionPromptDidComplete(false, ShouldSendSystemInfo);
                }
            }
        }

        void CheckAutomatically(object sender, EventArgs e) {
            sendDelegateOnWindowClose = false;

            if (Delegate != null) {
                Delegate.PermissionPromptDidComplete(true, ShouldSendSystemInfo);
            }
            if (updatePermissionPromptWindow != null)
            {
                //don't quit autoupdater; updatePermissionPromptWindow no longer needs to handle quitting
                updatePermissionPromptWindow.DontTerminateOnClosing = true;
            }
            Window.Close();
        }

        void DontCheck(object sender, EventArgs e) {
            sendDelegateOnWindowClose = false;

            if (Delegate != null) {
                Delegate.PermissionPromptDidComplete(false, ShouldSendSystemInfo);
            }

            Window.Close();
            KNNotificationCentre.SharedCentre().PostNotificationWithName(SUConstants.SUTerminateNotification, this);
        }

        private bool ShouldSendSystemInfo {
            get {
                return viewController.SendProfileCheck.IsChecked.Value;
            }
        }

        public SUUpdatePermissionPromptWindowControllerDelegate Delegate {
            get;
            set;
        }

    }
}
