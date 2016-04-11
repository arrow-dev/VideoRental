namespace VideoRentalSystem.Forms
{
    partial class FormDataView
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
            this.tcDataDisplay = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnEditMovie = new System.Windows.Forms.Button();
            this.btnRemoveMovie = new System.Windows.Forms.Button();
            this.btnAddMovie = new System.Windows.Forms.Button();
            this.dgvMovies = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnEditUser = new System.Windows.Forms.Button();
            this.btnRemoveUser = new System.Windows.Forms.Button();
            this.btnAddUser = new System.Windows.Forms.Button();
            this.dgvUsers = new System.Windows.Forms.DataGridView();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.btnReturn = new System.Windows.Forms.Button();
            this.btnNewRental = new System.Windows.Forms.Button();
            this.dgvRentals = new System.Windows.Forms.DataGridView();
            this.btnBack = new System.Windows.Forms.Button();
            this.tcDataDisplay.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMovies)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsers)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRentals)).BeginInit();
            this.SuspendLayout();
            // 
            // tcDataDisplay
            // 
            this.tcDataDisplay.Controls.Add(this.tabPage1);
            this.tcDataDisplay.Controls.Add(this.tabPage2);
            this.tcDataDisplay.Controls.Add(this.tabPage3);
            this.tcDataDisplay.Location = new System.Drawing.Point(12, 12);
            this.tcDataDisplay.Name = "tcDataDisplay";
            this.tcDataDisplay.SelectedIndex = 0;
            this.tcDataDisplay.Size = new System.Drawing.Size(1083, 676);
            this.tcDataDisplay.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btnEditMovie);
            this.tabPage1.Controls.Add(this.btnRemoveMovie);
            this.tabPage1.Controls.Add(this.btnAddMovie);
            this.tabPage1.Controls.Add(this.dgvMovies);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1075, 650);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Movies";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnEditMovie
            // 
            this.btnEditMovie.Location = new System.Drawing.Point(354, 621);
            this.btnEditMovie.Name = "btnEditMovie";
            this.btnEditMovie.Size = new System.Drawing.Size(168, 23);
            this.btnEditMovie.TabIndex = 7;
            this.btnEditMovie.Text = "Edit";
            this.btnEditMovie.UseVisualStyleBackColor = true;
            // 
            // btnRemoveMovie
            // 
            this.btnRemoveMovie.Location = new System.Drawing.Point(180, 621);
            this.btnRemoveMovie.Name = "btnRemoveMovie";
            this.btnRemoveMovie.Size = new System.Drawing.Size(168, 23);
            this.btnRemoveMovie.TabIndex = 6;
            this.btnRemoveMovie.Text = "Remove Movie";
            this.btnRemoveMovie.UseVisualStyleBackColor = true;
            // 
            // btnAddMovie
            // 
            this.btnAddMovie.Location = new System.Drawing.Point(6, 621);
            this.btnAddMovie.Name = "btnAddMovie";
            this.btnAddMovie.Size = new System.Drawing.Size(168, 23);
            this.btnAddMovie.TabIndex = 4;
            this.btnAddMovie.Text = "Add Movie";
            this.btnAddMovie.UseVisualStyleBackColor = true;
            // 
            // dgvMovies
            // 
            this.dgvMovies.AllowUserToAddRows = false;
            this.dgvMovies.AllowUserToDeleteRows = false;
            this.dgvMovies.AllowUserToResizeRows = false;
            this.dgvMovies.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMovies.Location = new System.Drawing.Point(6, 6);
            this.dgvMovies.MultiSelect = false;
            this.dgvMovies.Name = "dgvMovies";
            this.dgvMovies.ReadOnly = true;
            this.dgvMovies.RowHeadersVisible = false;
            this.dgvMovies.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMovies.Size = new System.Drawing.Size(522, 609);
            this.dgvMovies.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btnEditUser);
            this.tabPage2.Controls.Add(this.btnRemoveUser);
            this.tabPage2.Controls.Add(this.btnAddUser);
            this.tabPage2.Controls.Add(this.dgvUsers);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1075, 650);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Users";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnEditUser
            // 
            this.btnEditUser.Location = new System.Drawing.Point(354, 621);
            this.btnEditUser.Name = "btnEditUser";
            this.btnEditUser.Size = new System.Drawing.Size(168, 23);
            this.btnEditUser.TabIndex = 10;
            this.btnEditUser.Text = "Edit";
            this.btnEditUser.UseVisualStyleBackColor = true;
            // 
            // btnRemoveUser
            // 
            this.btnRemoveUser.Location = new System.Drawing.Point(180, 621);
            this.btnRemoveUser.Name = "btnRemoveUser";
            this.btnRemoveUser.Size = new System.Drawing.Size(168, 23);
            this.btnRemoveUser.TabIndex = 9;
            this.btnRemoveUser.Text = "Remove User";
            this.btnRemoveUser.UseVisualStyleBackColor = true;
            // 
            // btnAddUser
            // 
            this.btnAddUser.Location = new System.Drawing.Point(6, 621);
            this.btnAddUser.Name = "btnAddUser";
            this.btnAddUser.Size = new System.Drawing.Size(168, 23);
            this.btnAddUser.TabIndex = 8;
            this.btnAddUser.Text = "Add User";
            this.btnAddUser.UseVisualStyleBackColor = true;
            // 
            // dgvUsers
            // 
            this.dgvUsers.AllowUserToAddRows = false;
            this.dgvUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUsers.Location = new System.Drawing.Point(6, 6);
            this.dgvUsers.MultiSelect = false;
            this.dgvUsers.Name = "dgvUsers";
            this.dgvUsers.RowHeadersVisible = false;
            this.dgvUsers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvUsers.Size = new System.Drawing.Size(1063, 609);
            this.dgvUsers.TabIndex = 1;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.btnReturn);
            this.tabPage3.Controls.Add(this.btnNewRental);
            this.tabPage3.Controls.Add(this.dgvRentals);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(1075, 650);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Rentals";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // btnReturn
            // 
            this.btnReturn.Location = new System.Drawing.Point(180, 621);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(168, 23);
            this.btnReturn.TabIndex = 9;
            this.btnReturn.Text = "Return Movie";
            this.btnReturn.UseVisualStyleBackColor = true;
            // 
            // btnNewRental
            // 
            this.btnNewRental.Location = new System.Drawing.Point(6, 621);
            this.btnNewRental.Name = "btnNewRental";
            this.btnNewRental.Size = new System.Drawing.Size(168, 23);
            this.btnNewRental.TabIndex = 8;
            this.btnNewRental.Text = "New Rental";
            this.btnNewRental.UseVisualStyleBackColor = true;
            // 
            // dgvRentals
            // 
            this.dgvRentals.AllowUserToAddRows = false;
            this.dgvRentals.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRentals.Location = new System.Drawing.Point(6, 6);
            this.dgvRentals.MultiSelect = false;
            this.dgvRentals.Name = "dgvRentals";
            this.dgvRentals.RowHeadersVisible = false;
            this.dgvRentals.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvRentals.Size = new System.Drawing.Size(1063, 609);
            this.dgvRentals.TabIndex = 1;
            // 
            // btnBack
            // 
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(1101, 608);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(187, 80);
            this.btnBack.TabIndex = 8;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // FormDataView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1300, 700);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.tcDataDisplay);
            this.Name = "FormDataView";
            this.Text = "FormDataView";
            this.tcDataDisplay.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMovies)).EndInit();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsers)).EndInit();
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRentals)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tcDataDisplay;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button btnEditMovie;
        private System.Windows.Forms.Button btnRemoveMovie;
        private System.Windows.Forms.Button btnAddMovie;
        private System.Windows.Forms.DataGridView dgvMovies;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btnEditUser;
        private System.Windows.Forms.Button btnRemoveUser;
        private System.Windows.Forms.Button btnAddUser;
        private System.Windows.Forms.DataGridView dgvUsers;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.Button btnNewRental;
        private System.Windows.Forms.DataGridView dgvRentals;
        private System.Windows.Forms.Button btnBack;
    }
}