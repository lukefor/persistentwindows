using System;
using System.Windows.Forms;
using Ninjacrab.PersistentWindows.Common;
using Ninjacrab.PersistentWindows.WpfShell;
using NativeHelpers;

namespace Ninjacrab.PersistentWindows.SystrayShell
{
    public partial class SystrayForm : Form
    {
        public MainWindow MainView { get; set; }

        private PersistentWindowProcessor m_persistentWindowProcessor;

        public SystrayForm(PersistentWindowProcessor persistentWindowProcessor)
        {
            m_persistentWindowProcessor = persistentWindowProcessor;
            InitializeComponent();
        }

        private void DiagnosticsToolStripMenuItemClickHandler(object sender, EventArgs e)
        {
            // XXX
            /* bool shouldShow = false;
             if (this.MainView == null ||
                 this.MainView.IsClosed)
             {
                 this.MainView = new MainWindow();
                 shouldShow = true;
             }

             if (shouldShow)
             {
                 this.MainView.Show();
             }*/


            m_persistentWindowProcessor.BeginRestoreApplicationsOnCurrentDisplays();
        }

        private void ExitToolStripMenuItemClickHandler(object sender, EventArgs e)
        {
            this.notifyIconMain.Visible = false;
            this.notifyIconMain.Icon = null;
            Application.Exit();
        }

    }
}
