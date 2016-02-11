using KNFoundation;
using System;
using System.Collections.Generic;
using System.ComponentModel; // CancelEventArgs
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace SparkleDotNET {
    /// <summary>
    /// Interaction logic for SUUpdatePermissionPromptWindow.xaml
    /// </summary>
    public partial class SUUpdatePermissionPromptWindow : Window {
        public SUUpdatePermissionPromptWindow() {
            InitializeComponent();
        }
        bool dontTerminateOnClosing = false;
        public bool DontTerminateOnClosing
        {
            set
            {
                dontTerminateOnClosing = value;
            }
        }
        //our callback to Closing in xaml; hit upon user closing window instead of clicking action buttons
        void OnClosing(object sender, CancelEventArgs e)
        {
            if (!dontTerminateOnClosing)
            {
                KNNotificationCentre.SharedCentre().PostNotificationWithName(SUConstants.SUTerminateNotification, this);
            }
        }
    }
}
