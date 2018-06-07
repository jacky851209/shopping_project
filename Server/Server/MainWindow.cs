using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Server
{
    public partial class MainWindow : Form
    {
        SocketServer server = new SocketServer();
        public MainWindow()
        {
            InitializeComponent();
            BtnClose.Enabled = false;
        }

        private void BtnStart_Click(object sender, EventArgs e)
        {
            server.start();

            BtnStart.Enabled = false;
            BtnClose.Enabled = true;
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            server.stop();

            BtnStart.Enabled = true;
            BtnClose.Enabled = false;
        }
    }
}
