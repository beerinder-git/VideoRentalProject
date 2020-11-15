namespace VideoRentalProject
{
    partial class MainForm
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
            this.LoadBtn = new System.Windows.Forms.Button();
            this.MainGrid = new System.Windows.Forms.DataGridView();
            this.LoadMovies = new System.Windows.Forms.Button();
            this.FNTBox = new System.Windows.Forms.TextBox();
            this.LNTBox = new System.Windows.Forms.TextBox();
            this.AdTBox = new System.Windows.Forms.TextBox();
            this.PhTBox = new System.Windows.Forms.TextBox();
            this.FNLabel = new System.Windows.Forms.Label();
            this.LNLabel = new System.Windows.Forms.Label();
            this.AdLabel = new System.Windows.Forms.Label();
            this.PhLabel = new System.Windows.Forms.Label();
            this.AddCustBtn = new System.Windows.Forms.Button();
            this.UpdCustBtn = new System.Windows.Forms.Button();
            this.CustIDLabel = new System.Windows.Forms.Label();
            this.CustIDTBox = new System.Windows.Forms.TextBox();
            this.DltCustBtn = new System.Windows.Forms.Button();
            this.MovieIDLabel = new System.Windows.Forms.Label();
            this.MovieIDTBox = new System.Windows.Forms.TextBox();
            this.ReturnMovieBtn = new System.Windows.Forms.Button();
            this.IssueMovieBtn = new System.Windows.Forms.Button();
            this.LoadRentedMovies = new System.Windows.Forms.Button();
            this.PopCustBtn = new System.Windows.Forms.Button();
            this.PopMovBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.MainGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // LoadBtn
            // 
            this.LoadBtn.Location = new System.Drawing.Point(12, 12);
            this.LoadBtn.Name = "LoadBtn";
            this.LoadBtn.Size = new System.Drawing.Size(82, 54);
            this.LoadBtn.TabIndex = 0;
            this.LoadBtn.Text = "Load Customers";
            this.LoadBtn.UseVisualStyleBackColor = true;
            this.LoadBtn.Click += new System.EventHandler(this.LoadBtn_Click);
            // 
            // MainGrid
            // 
            this.MainGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.MainGrid.Location = new System.Drawing.Point(12, 72);
            this.MainGrid.Name = "MainGrid";
            this.MainGrid.Size = new System.Drawing.Size(654, 293);
            this.MainGrid.TabIndex = 1;
            this.MainGrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.MainGrid_CellContentClick);
            // 
            // LoadMovies
            // 
            this.LoadMovies.Location = new System.Drawing.Point(100, 12);
            this.LoadMovies.Name = "LoadMovies";
            this.LoadMovies.Size = new System.Drawing.Size(82, 54);
            this.LoadMovies.TabIndex = 2;
            this.LoadMovies.Text = "Load Movies";
            this.LoadMovies.UseVisualStyleBackColor = true;
            this.LoadMovies.Click += new System.EventHandler(this.LoadMovies_Click);
            // 
            // FNTBox
            // 
            this.FNTBox.Location = new System.Drawing.Point(378, 402);
            this.FNTBox.Name = "FNTBox";
            this.FNTBox.Size = new System.Drawing.Size(100, 20);
            this.FNTBox.TabIndex = 3;
            // 
            // LNTBox
            // 
            this.LNTBox.Location = new System.Drawing.Point(272, 444);
            this.LNTBox.Name = "LNTBox";
            this.LNTBox.Size = new System.Drawing.Size(100, 20);
            this.LNTBox.TabIndex = 4;
            // 
            // AdTBox
            // 
            this.AdTBox.Location = new System.Drawing.Point(378, 444);
            this.AdTBox.Name = "AdTBox";
            this.AdTBox.Size = new System.Drawing.Size(100, 20);
            this.AdTBox.TabIndex = 5;
            // 
            // PhTBox
            // 
            this.PhTBox.Location = new System.Drawing.Point(484, 444);
            this.PhTBox.Name = "PhTBox";
            this.PhTBox.Size = new System.Drawing.Size(100, 20);
            this.PhTBox.TabIndex = 6;
            // 
            // FNLabel
            // 
            this.FNLabel.AutoSize = true;
            this.FNLabel.Location = new System.Drawing.Point(378, 386);
            this.FNLabel.Name = "FNLabel";
            this.FNLabel.Size = new System.Drawing.Size(57, 13);
            this.FNLabel.TabIndex = 7;
            this.FNLabel.Text = "First Name";
            // 
            // LNLabel
            // 
            this.LNLabel.AutoSize = true;
            this.LNLabel.Location = new System.Drawing.Point(269, 428);
            this.LNLabel.Name = "LNLabel";
            this.LNLabel.Size = new System.Drawing.Size(58, 13);
            this.LNLabel.TabIndex = 8;
            this.LNLabel.Text = "Last Name";
            // 
            // AdLabel
            // 
            this.AdLabel.AutoSize = true;
            this.AdLabel.Location = new System.Drawing.Point(375, 428);
            this.AdLabel.Name = "AdLabel";
            this.AdLabel.Size = new System.Drawing.Size(45, 13);
            this.AdLabel.TabIndex = 9;
            this.AdLabel.Text = "Address";
            // 
            // PhLabel
            // 
            this.PhLabel.AutoSize = true;
            this.PhLabel.Location = new System.Drawing.Point(481, 428);
            this.PhLabel.Name = "PhLabel";
            this.PhLabel.Size = new System.Drawing.Size(38, 13);
            this.PhLabel.TabIndex = 10;
            this.PhLabel.Text = "Phone";
            // 
            // AddCustBtn
            // 
            this.AddCustBtn.Location = new System.Drawing.Point(12, 384);
            this.AddCustBtn.Name = "AddCustBtn";
            this.AddCustBtn.Size = new System.Drawing.Size(62, 54);
            this.AddCustBtn.TabIndex = 11;
            this.AddCustBtn.Text = "Add Customer";
            this.AddCustBtn.UseVisualStyleBackColor = true;
            this.AddCustBtn.Click += new System.EventHandler(this.AddCustBtn_Click);
            // 
            // UpdCustBtn
            // 
            this.UpdCustBtn.Location = new System.Drawing.Point(80, 384);
            this.UpdCustBtn.Name = "UpdCustBtn";
            this.UpdCustBtn.Size = new System.Drawing.Size(62, 54);
            this.UpdCustBtn.TabIndex = 12;
            this.UpdCustBtn.Text = "Update Customer";
            this.UpdCustBtn.UseVisualStyleBackColor = true;
            this.UpdCustBtn.Click += new System.EventHandler(this.UpdCustBtn_Click);
            // 
            // CustIDLabel
            // 
            this.CustIDLabel.AutoSize = true;
            this.CustIDLabel.Location = new System.Drawing.Point(272, 386);
            this.CustIDLabel.Name = "CustIDLabel";
            this.CustIDLabel.Size = new System.Drawing.Size(65, 13);
            this.CustIDLabel.TabIndex = 14;
            this.CustIDLabel.Text = "Customer ID";
            // 
            // CustIDTBox
            // 
            this.CustIDTBox.Enabled = false;
            this.CustIDTBox.Location = new System.Drawing.Point(272, 402);
            this.CustIDTBox.Name = "CustIDTBox";
            this.CustIDTBox.Size = new System.Drawing.Size(100, 20);
            this.CustIDTBox.TabIndex = 13;
            // 
            // DltCustBtn
            // 
            this.DltCustBtn.Location = new System.Drawing.Point(148, 384);
            this.DltCustBtn.Name = "DltCustBtn";
            this.DltCustBtn.Size = new System.Drawing.Size(62, 54);
            this.DltCustBtn.TabIndex = 15;
            this.DltCustBtn.Text = "Delete Customer";
            this.DltCustBtn.UseVisualStyleBackColor = true;
            this.DltCustBtn.Click += new System.EventHandler(this.DltCustBtn_Click);
            // 
            // MovieIDLabel
            // 
            this.MovieIDLabel.AutoSize = true;
            this.MovieIDLabel.Location = new System.Drawing.Point(272, 487);
            this.MovieIDLabel.Name = "MovieIDLabel";
            this.MovieIDLabel.Size = new System.Drawing.Size(50, 13);
            this.MovieIDLabel.TabIndex = 17;
            this.MovieIDLabel.Text = "Movie ID";
            // 
            // MovieIDTBox
            // 
            this.MovieIDTBox.Enabled = false;
            this.MovieIDTBox.Location = new System.Drawing.Point(272, 503);
            this.MovieIDTBox.Name = "MovieIDTBox";
            this.MovieIDTBox.Size = new System.Drawing.Size(100, 20);
            this.MovieIDTBox.TabIndex = 16;
            // 
            // ReturnMovieBtn
            // 
            this.ReturnMovieBtn.Location = new System.Drawing.Point(584, 12);
            this.ReturnMovieBtn.Name = "ReturnMovieBtn";
            this.ReturnMovieBtn.Size = new System.Drawing.Size(82, 54);
            this.ReturnMovieBtn.TabIndex = 18;
            this.ReturnMovieBtn.Text = "Return Movie";
            this.ReturnMovieBtn.UseVisualStyleBackColor = true;
            this.ReturnMovieBtn.Click += new System.EventHandler(this.ReturnMovieBtn_Click);
            // 
            // IssueMovieBtn
            // 
            this.IssueMovieBtn.Location = new System.Drawing.Point(496, 12);
            this.IssueMovieBtn.Name = "IssueMovieBtn";
            this.IssueMovieBtn.Size = new System.Drawing.Size(82, 54);
            this.IssueMovieBtn.TabIndex = 19;
            this.IssueMovieBtn.Text = "Issue Movie";
            this.IssueMovieBtn.UseVisualStyleBackColor = true;
            this.IssueMovieBtn.Click += new System.EventHandler(this.IssueMovieBtn_Click);
            // 
            // LoadRentedMovies
            // 
            this.LoadRentedMovies.Location = new System.Drawing.Point(188, 12);
            this.LoadRentedMovies.Name = "LoadRentedMovies";
            this.LoadRentedMovies.Size = new System.Drawing.Size(82, 54);
            this.LoadRentedMovies.TabIndex = 20;
            this.LoadRentedMovies.Text = "Load Rented Movies";
            this.LoadRentedMovies.UseVisualStyleBackColor = true;
            this.LoadRentedMovies.Click += new System.EventHandler(this.LoadRentedMovies_Click);
            // 
            // PopCustBtn
            // 
            this.PopCustBtn.Location = new System.Drawing.Point(378, 12);
            this.PopCustBtn.Name = "PopCustBtn";
            this.PopCustBtn.Size = new System.Drawing.Size(67, 54);
            this.PopCustBtn.TabIndex = 22;
            this.PopCustBtn.Text = "Popular Customer";
            this.PopCustBtn.UseVisualStyleBackColor = true;
            this.PopCustBtn.Click += new System.EventHandler(this.PopCustBtn_Click);
            // 
            // PopMovBtn
            // 
            this.PopMovBtn.Location = new System.Drawing.Point(305, 12);
            this.PopMovBtn.Name = "PopMovBtn";
            this.PopMovBtn.Size = new System.Drawing.Size(67, 54);
            this.PopMovBtn.TabIndex = 23;
            this.PopMovBtn.Text = "Popular Movie";
            this.PopMovBtn.UseVisualStyleBackColor = true;
            this.PopMovBtn.Click += new System.EventHandler(this.PopMovBtn_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 535);
            this.Controls.Add(this.PopMovBtn);
            this.Controls.Add(this.PopCustBtn);
            this.Controls.Add(this.LoadRentedMovies);
            this.Controls.Add(this.IssueMovieBtn);
            this.Controls.Add(this.ReturnMovieBtn);
            this.Controls.Add(this.MovieIDLabel);
            this.Controls.Add(this.MovieIDTBox);
            this.Controls.Add(this.DltCustBtn);
            this.Controls.Add(this.CustIDLabel);
            this.Controls.Add(this.CustIDTBox);
            this.Controls.Add(this.UpdCustBtn);
            this.Controls.Add(this.AddCustBtn);
            this.Controls.Add(this.PhLabel);
            this.Controls.Add(this.AdLabel);
            this.Controls.Add(this.LNLabel);
            this.Controls.Add(this.FNLabel);
            this.Controls.Add(this.PhTBox);
            this.Controls.Add(this.AdTBox);
            this.Controls.Add(this.LNTBox);
            this.Controls.Add(this.FNTBox);
            this.Controls.Add(this.LoadMovies);
            this.Controls.Add(this.MainGrid);
            this.Controls.Add(this.LoadBtn);
            this.Name = "MainForm";
            this.Text = "Video Rental";
            ((System.ComponentModel.ISupportInitialize)(this.MainGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button LoadBtn;
        private System.Windows.Forms.DataGridView MainGrid;
        private System.Windows.Forms.Button LoadMovies;
        private System.Windows.Forms.TextBox FNTBox;
        private System.Windows.Forms.TextBox LNTBox;
        private System.Windows.Forms.TextBox AdTBox;
        private System.Windows.Forms.TextBox PhTBox;
        private System.Windows.Forms.Label FNLabel;
        private System.Windows.Forms.Label LNLabel;
        private System.Windows.Forms.Label AdLabel;
        private System.Windows.Forms.Label PhLabel;
        private System.Windows.Forms.Button AddCustBtn;
        private System.Windows.Forms.Button UpdCustBtn;
        private System.Windows.Forms.Label CustIDLabel;
        private System.Windows.Forms.TextBox CustIDTBox;
        private System.Windows.Forms.Button DltCustBtn;
        private System.Windows.Forms.Label MovieIDLabel;
        private System.Windows.Forms.TextBox MovieIDTBox;
        private System.Windows.Forms.Button ReturnMovieBtn;
        private System.Windows.Forms.Button IssueMovieBtn;
        private System.Windows.Forms.Button LoadRentedMovies;
        private System.Windows.Forms.Button PopCustBtn;
        private System.Windows.Forms.Button PopMovBtn;
    }
}

