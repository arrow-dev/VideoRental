using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VideoStore
{
    //This is a dialog form to pass data back to the main program.
    public partial class FormAddCustomer : Form
    {
        public string fN { get; set; }
        public string lN { get; set; }
        public string address { get; set; }
        public string phone { get; set; }

        public FormAddCustomer()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtFN.Text != "" && txtLN.Text != "" && txtAddress.Text != "" && txtPhone.Text != "")
            {
                fN = txtFN.Text;
                lN = txtLN.Text;
                address = txtAddress.Text;
                phone = txtPhone.Text;
                this.DialogResult = DialogResult.OK;
            }
            else
            {
                MessageBox.Show("Please complete all fields.");
            }
        }
    }
}
