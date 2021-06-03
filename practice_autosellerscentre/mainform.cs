using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace practice_autosellerscentre
{
    public partial class mainform : Form
    {
        public mainform()
        {
            InitializeComponent();
        }

        private void exitTB_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            Close();
        }
    }
}
