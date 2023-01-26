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
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnTotal = new System.Windows.Forms.Button();
            this.inputSearch = new System.Windows.Forms.ComboBox();
            this.cart_table = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.inputCartDuration = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.inputCartQuantity = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.inputCartID = new System.Windows.Forms.Label();
            this.InputCartPrice = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.userDisplay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cart_table)).BeginInit();
            this.SuspendLayout();
            // 
            // userDisplay
            // 
            this.userDisplay.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.userDisplay.Location = new System.Drawing.Point(67, 129);
            this.userDisplay.Name = "userDisplay";
            this.userDisplay.Size = new System.Drawing.Size(770, 310);
            this.userDisplay.TabIndex = 0;
            this.userDisplay.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.userDisplay_CellEnter);
            // 
            // btnDisplay
            // 
            this.btnDisplay.Location = new System.Drawing.Point(868, 135);
            this.btnDisplay.Name = "btnDisplay";
            this.btnDisplay.Size = new System.Drawing.Size(92, 48);
            this.btnDisplay.TabIndex = 1;
            this.btnDisplay.Text = "Display Item";
            this.btnDisplay.UseVisualStyleBackColor = true;
            this.btnDisplay.Click += new System.EventHandler(this.btnDisplay_Click);
            // 
            // btnSort
            // 
            this.btnSort.Location = new System.Drawing.Point(868, 208);
            this.btnSort.Name = "btnSort";
            this.btnSort.Size = new System.Drawing.Size(92, 48);
            this.btnSort.TabIndex = 2;
            this.btnSort.Text = "Sort Item with power consumption";
            this.btnSort.UseVisualStyleBackColor = true;
            this.btnSort.Click += new System.EventHandler(this.btnSort_Click);
            // 
            // btnCart
            // 
            this.btnCart.Location = new System.Drawing.Point(234, 667);
            this.btnCart.Name = "btnCart";
            this.btnCart.Size = new System.Drawing.Size(92, 37);
            this.btnCart.TabIndex = 3;
            this.btnCart.Text = "Add to Cart";
            this.btnCart.UseVisualStyleBackColor = true;
            this.btnCart.Click += new System.EventHandler(this.btnCart_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.Location = new System.Drawing.Point(12, 750);
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
            this.userHeader.Location = new System.Drawing.Point(414, 20);
            this.userHeader.Name = "userHeader";
            this.userHeader.Size = new System.Drawing.Size(319, 31);
            this.userHeader.TabIndex = 5;
            this.userHeader.Text = "Home Application Rental ";
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(739, 75);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(98, 42);
            this.btnSearch.TabIndex = 8;
            this.btnSearch.Text = "Search with type";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnTotal
            // 
            this.btnTotal.Location = new System.Drawing.Point(234, 724);
            this.btnTotal.Name = "btnTotal";
            this.btnTotal.Size = new System.Drawing.Size(92, 38);
            this.btnTotal.TabIndex = 9;
            this.btnTotal.Text = "Calculate Total";
            this.btnTotal.UseVisualStyleBackColor = true;
            this.btnTotal.Click += new System.EventHandler(this.btn_calculate_Click);
            // 
            // inputSearch
            // 
            this.inputSearch.FormattingEnabled = true;
            this.inputSearch.Items.AddRange(new object[] {
            "kitchen use",
            "house use",
            "personal use",
            "entertainment use",
            "excavation tool"});
            this.inputSearch.Location = new System.Drawing.Point(587, 81);
            this.inputSearch.Name = "inputSearch";
            this.inputSearch.Size = new System.Drawing.Size(146, 21);
            this.inputSearch.TabIndex = 10;
            // 
            // cart_table
            // 
            this.cart_table.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.cart_table.Location = new System.Drawing.Point(356, 472);
            this.cart_table.Name = "cart_table";
            this.cart_table.Size = new System.Drawing.Size(623, 315);
            this.cart_table.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(90, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 26);
            this.label1.TabIndex = 12;
            this.label1.Text = "Product View";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(169, 475);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(157, 26);
            this.label2.TabIndex = 13;
            this.label2.Text = "Shopping Cart ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(104, 535);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Appliance ID :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(72, 627);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Duration ( in month ):";
            // 
            // inputCartDuration
            // 
            this.inputCartDuration.Location = new System.Drawing.Point(197, 624);
            this.inputCartDuration.Name = "inputCartDuration";
            this.inputCartDuration.Size = new System.Drawing.Size(129, 20);
            this.inputCartDuration.TabIndex = 15;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(125, 596);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Quantity :";
            // 
            // inputCartQuantity
            // 
            this.inputCartQuantity.Location = new System.Drawing.Point(197, 589);
            this.inputCartQuantity.Name = "inputCartQuantity";
            this.inputCartQuantity.Size = new System.Drawing.Size(129, 20);
            this.inputCartQuantity.TabIndex = 15;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(140, 562);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Price :";
            // 
            // inputCartID
            // 
            this.inputCartID.AutoSize = true;
            this.inputCartID.Location = new System.Drawing.Point(205, 535);
            this.inputCartID.Name = "inputCartID";
            this.inputCartID.Size = new System.Drawing.Size(35, 13);
            this.inputCartID.TabIndex = 16;
            this.inputCartID.Text = "label7";
            // 
            // InputCartPrice
            // 
            this.InputCartPrice.AutoSize = true;
            this.InputCartPrice.Location = new System.Drawing.Point(206, 563);
            this.InputCartPrice.Name = "InputCartPrice";
            this.InputCartPrice.Size = new System.Drawing.Size(35, 13);
            this.InputCartPrice.TabIndex = 17;
            this.InputCartPrice.Text = "label8";
            // 
            // user_page
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1018, 810);
            this.Controls.Add(this.InputCartPrice);
            this.Controls.Add(this.inputCartID);
            this.Controls.Add(this.inputCartQuantity);
            this.Controls.Add(this.inputCartDuration);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cart_table);
            this.Controls.Add(this.inputSearch);
            this.Controls.Add(this.btnTotal);
            this.Controls.Add(this.btnSearch);
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
            ((System.ComponentModel.ISupportInitialize)(this.cart_table)).EndInit();
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
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnTotal;
        private System.Windows.Forms.ComboBox inputSearch;
        private System.Windows.Forms.DataGridView cart_table;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox inputCartDuration;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox inputCartQuantity;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label inputCartID;
        private System.Windows.Forms.Label InputCartPrice;
    }
}