namespace a_home_appliance_rental_application
{
    partial class user_page
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
            this.userDisplay = new System.Windows.Forms.DataGridView();
            this.btnDisplay = new System.Windows.Forms.Button();
            this.btnSort = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.userHeader = new System.Windows.Forms.Label();
            this.inputSearch = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.userDisplay)).BeginInit();
            this.SuspendLayout();
            // 
            // userDisplay
            // 
            this.userDisplay.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.userDisplay.Location = new System.Drawing.Point(29, 123);
            this.userDisplay.Name = "userDisplay";
            this.userDisplay.Size = new System.Drawing.Size(738, 450);
            this.userDisplay.TabIndex = 0;
            // 
            // btnDisplay
            // 
            this.btnDisplay.Location = new System.Drawing.Point(803, 125);
            this.btnDisplay.Name = "btnDisplay";
            this.btnDisplay.Size = new System.Drawing.Size(92, 37);
            this.btnDisplay.TabIndex = 1;
            this.btnDisplay.Text = "Display Item";
            this.btnDisplay.UseVisualStyleBackColor = true;
            this.btnDisplay.Click += new System.EventHandler(this.btnDisplay_Click);
            // 
            // btnSort
            // 
            this.btnSort.Location = new System.Drawing.Point(803, 178);
            this.btnSort.Name = "btnSort";
            this.btnSort.Size = new System.Drawing.Size(92, 37);
            this.btnSort.TabIndex = 2;
            this.btnSort.Text = "Sort Item";
            this.btnSort.UseVisualStyleBackColor = true;
            this.btnSort.Click += new System.EventHandler(this.btnSort_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(803, 245);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(92, 37);
            this.button3.TabIndex = 3;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // btnLogout
            // 
            this.btnLogout.Location = new System.Drawing.Point(29, 590);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(92, 37);
            this.btnLogout.TabIndex = 4;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // userHeader
            // 
            this.userHeader.AutoSize = true;
            this.userHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userHeader.Location = new System.Drawing.Point(34, 67);
            this.userHeader.Name = "userHeader";
            this.userHeader.Size = new System.Drawing.Size(79, 31);
            this.userHeader.TabIndex = 5;
            this.userHeader.Text = "User ";
            // 
            // inputSearch
            // 
            this.inputSearch.Location = new System.Drawing.Point(536, 90);
            this.inputSearch.Name = "inputSearch";
            this.inputSearch.Size = new System.Drawing.Size(136, 20);
            this.inputSearch.TabIndex = 7;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(692, 90);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 20);
            this.btnSearch.TabIndex = 8;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            // 
            // user_page
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(936, 648);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.inputSearch);
            this.Controls.Add(this.userHeader);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.btnSort);
            this.Controls.Add(this.btnDisplay);
            this.Controls.Add(this.userDisplay);
            this.Name = "user_page";
            this.Text = "user_page";
            this.Load += new System.EventHandler(this.user_page_Load);
            ((System.ComponentModel.ISupportInitialize)(this.userDisplay)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView userDisplay;
        private System.Windows.Forms.Button btnDisplay;
        private System.Windows.Forms.Button btnSort;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Label userHeader;
        private System.Windows.Forms.TextBox inputSearch;
        private System.Windows.Forms.Button btnSearch;
    }
}