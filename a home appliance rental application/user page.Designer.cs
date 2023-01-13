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
            this.btnCart = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.userHeader = new System.Windows.Forms.Label();
            this.inputSearch = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnCalculate = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.userDisplay)).BeginInit();
            this.SuspendLayout();
            // 
            // userDisplay
            // 
            this.userDisplay.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.userDisplay.Location = new System.Drawing.Point(24, 101);
            this.userDisplay.Name = "userDisplay";
            this.userDisplay.Size = new System.Drawing.Size(738, 450);
            this.userDisplay.TabIndex = 0;
            // 
            // btnDisplay
            // 
            this.btnDisplay.Location = new System.Drawing.Point(798, 103);
            this.btnDisplay.Name = "btnDisplay";
            this.btnDisplay.Size = new System.Drawing.Size(92, 37);
            this.btnDisplay.TabIndex = 1;
            this.btnDisplay.Text = "Display Item";
            this.btnDisplay.UseVisualStyleBackColor = true;
            this.btnDisplay.Click += new System.EventHandler(this.btnDisplay_Click);
            // 
            // btnSort
            // 
            this.btnSort.Location = new System.Drawing.Point(798, 156);
            this.btnSort.Name = "btnSort";
            this.btnSort.Size = new System.Drawing.Size(92, 37);
            this.btnSort.TabIndex = 2;
            this.btnSort.Text = "Sort Item";
            this.btnSort.UseVisualStyleBackColor = true;
            this.btnSort.Click += new System.EventHandler(this.btnSort_Click);
            // 
            // btnCart
            // 
            this.btnCart.Location = new System.Drawing.Point(798, 243);
            this.btnCart.Name = "btnCart";
            this.btnCart.Size = new System.Drawing.Size(92, 37);
            this.btnCart.TabIndex = 3;
            this.btnCart.Text = "Add to Cart";
            this.btnCart.UseVisualStyleBackColor = true;
            this.btnCart.Click += new System.EventHandler(this.btnCart_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.Location = new System.Drawing.Point(24, 568);
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
            this.userHeader.Location = new System.Drawing.Point(29, 45);
            this.userHeader.Name = "userHeader";
            this.userHeader.Size = new System.Drawing.Size(79, 31);
            this.userHeader.TabIndex = 5;
            this.userHeader.Text = "User ";
            // 
            // inputSearch
            // 
            this.inputSearch.Location = new System.Drawing.Point(452, 65);
            this.inputSearch.Name = "inputSearch";
            this.inputSearch.Size = new System.Drawing.Size(168, 20);
            this.inputSearch.TabIndex = 7;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(626, 60);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(98, 28);
            this.btnSearch.TabIndex = 8;
            this.btnSearch.Text = "Search with type";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(798, 302);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(92, 38);
            this.btnCalculate.TabIndex = 9;
            this.btnCalculate.Text = "Calculate Total";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btn_calculate_Click);
            // 
            // user_page
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(936, 648);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.inputSearch);
            this.Controls.Add(this.userHeader);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.btnCart);
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
        private System.Windows.Forms.Button btnCart;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Label userHeader;
        private System.Windows.Forms.TextBox inputSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnCalculate;
    }
}