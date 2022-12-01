using restaurant_admin.bd;
using restaurant_admin.forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace restaurant_admin
{
    public partial class MdiAdmin : Form
    {
        bool formActivated = true;
        public MdiAdmin()
        {
            InitializeComponent();
        }

        private void MdiAdmin_Activated(object sender, EventArgs e)
        {
            if (formActivated)
            {
                formActivated = false;
                Login fm = new Login(this);
                fm.StartPosition = FormStartPosition.CenterScreen;
                fm.Show();
            }
        }
    }
}
