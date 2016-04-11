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
    public partial class FormDataView : FormTemplate
    {
        public FormDataView()
        {
            InitializeComponent();
        }

        //Placeholder for a logout button
        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
