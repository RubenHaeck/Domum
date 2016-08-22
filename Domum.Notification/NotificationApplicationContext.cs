using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Domum.Notification
{
    public class NotificationApplicationContext : ApplicationContext
    {
        private NotifyIcon _notifyIcon;
        private ContextMenuStrip _contextMenuStrip;

        public NotificationApplicationContext()
        {
            Application.ApplicationExit += new EventHandler(this.OnApplicationExit);
            InitializeComponent();
            _notifyIcon.Visible = true;

        }

        private void InitializeComponent()
        {
            _notifyIcon = new NotifyIcon();
            _notifyIcon.BalloonTipIcon = ToolTipIcon.Info;
            _notifyIcon.BalloonTipText = "Domum Notifications";
            _notifyIcon.BalloonTipTitle = "Title";
            _notifyIcon.Text = "My fabulous tray icon demo";
            _notifyIcon.Icon = Properties.Resources.ASPNETWeb;

            _notifyIcon.DoubleClick += (sender, args) =>
            {
                MessageBox.Show("Dit is een test");
                _notifyIcon.ShowBalloonTip(1000);

            };

            _contextMenuStrip = new ContextMenuStrip();
            _contextMenuStrip.Name = "contextMenuStrip";
            _contextMenuStrip.SuspendLayout();

            _contextMenuStrip.Items.Add(new ToolStripMenuItem());

        }

        protected void OnApplicationExit(object sender, EventArgs e)
        {
            _notifyIcon.Visible = false;
        }
    }
}
