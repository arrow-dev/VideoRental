using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VideoRentalSystem.Forms
{
    //Startup menu
    public partial class FormMain : FormTemplate
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //Start button is a placeholder for a future login process
        private void btnStart_Click(object sender, EventArgs e)
        {
            var DataView = new FormDataView();
            this.Hide();
            DataView.ShowDialog();
            this.Show();
        }
    }
}
