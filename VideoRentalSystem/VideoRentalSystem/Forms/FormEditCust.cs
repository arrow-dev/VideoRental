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
    //Form to edit customer info.
    public partial class FormEditCust : Form
    {
        public string fN { get; set; }
        public string lN { get; set; }
        public string address { get; set; }
        public string phone { get; set; }
        public int id { get; set; }

        public FormEditCust(string fname, string lname, string address, string ph, int id)
        {
            InitializeComponent();
            txtFN.Text = fname;
            txtLN.Text = lname;
            txtAddress.Text = address;
            txtPhone.Text = ph;
            this.id = id;
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
        }
    }
}
