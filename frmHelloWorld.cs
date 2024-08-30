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
        }

        private void btnHelloWorld_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hello World!!!");

            //changes label text
            lblHelloWorld.Text = "Theodore Rosevelt";

            //hides picture box
            pbHelloWorld.Visible = false;


            MessageBox.Show("Goodbye...");

            //changes label text back to original
            lblHelloWorld.Text = "Hello World!!!";

            //makes picture box visible again
            pbHelloWorld.Visible = true;
        }

        private void pbHelloWorld_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Powered By Corsair");

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            //closes form
            this.Close();
        }
    }
}
