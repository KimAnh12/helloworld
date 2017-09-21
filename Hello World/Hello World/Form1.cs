using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hello_World
{
    public partial class frmHelloWorld : Form
    {
        public frmHelloWorld()
        {
            InitializeComponent();
            MinimumSize = new Size(lblHelloWorld.Width, lblHelloWorld.Width);
        }

        private void frmHelloWorld_Load(object sender, EventArgs e)
        {

        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            lblHelloWorld.Text = "Hello World!";
            lblHelloWorld.Left = (ClientSize.Width - lblHelloWorld.Width) / 2;
            lblHelloWorld.Top = (ClientSize.Height - lblHelloWorld.Height) / 2;


        }
    }
}
