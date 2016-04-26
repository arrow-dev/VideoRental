namespace VideoStore
{
    partial class FormEditMovie
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnUpdate = new System.Windows.Forms.Button();
            this.cmbxRating = new System.Windows.Forms.ComboBox();
            this.cmbxGenre = new System.Windows.Forms.ComboBox();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.txtPlot = new System.Windows.Forms.TextBox();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.lblYear = new System.Windows.Forms.Label();
            this.lblGenre = new System.Windows.Forms.Label();
            this.lblPlot = new System.Windows.Forms.Label();
            this.lblRating = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(50, 235);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 22;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // cmbxRating
            // 
            this.cmbxRating.FormattingEnabled = true;
            this.cmbxRating.Items.AddRange(new object[] {
            "G",
            "PG",
            "M",
            "R16",
            "R18"});
            this.cmbxRating.Location = new System.Drawing.Point(50, 208);
            this.cmbxRating.Name = "cmbxRating";
            this.cmbxRating.Size = new System.Drawing.Size(121, 21);
            this.cmbxRating.TabIndex = 21;
            // 
            // cmbxGenre
            // 
            this.cmbxGenre.FormattingEnabled = true;
            this.cmbxGenre.Items.AddRange(new object[] {
            "Action",
            "Thriller",
            "Comedy",
            "Horror",
            "Romance",
            "Sci Fi"});
            this.cmbxGenre.Location = new System.Drawing.Point(50, 178);
            this.cmbxGenre.Name = "cmbxGenre";
            this.cmbxGenre.Size = new System.Drawing.Size(121, 21);
            this.cmbxGenre.TabIndex = 20;
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.CustomFormat = "yyyy";
            this.dateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker.Location = new System.Drawing.Point(50, 148);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.ShowUpDown = true;
            this.dateTimePicker.Size = new System.Drawing.Size(95, 20);
            this.dateTimePicker.TabIndex = 19;
            this.dateTimePicker.Value = new System.DateTime(2016, 1, 1, 0, 0, 0, 0);
            // 
            // txtPlot
            // 
            this.txtPlot.Location = new System.Drawing.Point(50, 40);
            this.txtPlot.Multiline = true;
            this.txtPlot.Name = "txtPlot";
            this.txtPlot.Size = new System.Drawing.Size(250, 98);
            this.txtPlot.TabIndex = 18;
            // 
            // txtTitle
            // 
            this.txtTitle.Location = new System.Drawing.Point(50, 10);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(250, 20);
            this.txtTitle.TabIndex = 17;
            // 
            // lblYear
            // 
            this.lblYear.AutoSize = true;
            this.lblYear.Location = new System.Drawing.Point(12, 148);
            this.lblYear.Name = "lblYear";
            this.lblYear.Size = new System.Drawing.Size(29, 13);
            this.lblYear.TabIndex = 16;
            this.lblYear.Text = "Year";
            // 
            // lblGenre
            // 
            this.lblGenre.AutoSize = true;
            this.lblGenre.Location = new System.Drawing.Point(12, 178);
            this.lblGenre.Name = "lblGenre";
            this.lblGenre.Size = new System.Drawing.Size(36, 13);
            this.lblGenre.TabIndex = 15;
            this.lblGenre.Text = "Genre";
            // 
            // lblPlot
            // 
            this.lblPlot.AutoSize = true;
            this.lblPlot.Location = new System.Drawing.Point(12, 40);
            this.lblPlot.Name = "lblPlot";
            this.lblPlot.Size = new System.Drawing.Size(25, 13);
            this.lblPlot.TabIndex = 14;
            this.lblPlot.Text = "Plot";
            // 
            // lblRating
            // 
            this.lblRating.AutoSize = true;
            this.lblRating.Location = new System.Drawing.Point(12, 208);
            this.lblRating.Name = "lblRating";
            this.lblRating.Size = new System.Drawing.Size(38, 13);
            this.lblRating.TabIndex = 13;
            this.lblRating.Text = "Rating";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new System.Drawing.Point(12, 10);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(27, 13);
            this.lblTitle.TabIndex = 12;
            this.lblTitle.Text = "Title";
            // 
            // FormEditMovie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(572, 305);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.cmbxRating);
            this.Controls.Add(this.cmbxGenre);
            this.Controls.Add(this.dateTimePicker);
            this.Controls.Add(this.txtPlot);
            this.Controls.Add(this.txtTitle);
            this.Controls.Add(this.lblYear);
            this.Controls.Add(this.lblGenre);
            this.Controls.Add(this.lblPlot);
            this.Controls.Add(this.lblRating);
            this.Controls.Add(this.lblTitle);
            this.Name = "FormEditMovie";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormEditMovie";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.ComboBox cmbxRating;
        private System.Windows.Forms.ComboBox cmbxGenre;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.TextBox txtPlot;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.Label lblYear;
        private System.Windows.Forms.Label lblGenre;
        private System.Windows.Forms.Label lblPlot;
        private System.Windows.Forms.Label lblRating;
        private System.Windows.Forms.Label lblTitle;
    }
}