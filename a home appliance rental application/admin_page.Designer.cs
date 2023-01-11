namespace a_home_appliance_rental_application
{
    partial class admin_page
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
            this.label1 = new System.Windows.Forms.Label();
            this.displayAdmin = new System.Windows.Forms.DataGridView();
            this.btnDisplayItem = new System.Windows.Forms.Button();
            this.btnDisplayUser = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.displayAdmin)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(28, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(167, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Admin Page ";
            // 
            // displayAdmin
            // 
            this.displayAdmin.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.displayAdmin.Location = new System.Drawing.Point(34, 143);
            this.displayAdmin.Name = "displayAdmin";
            this.displayAdmin.Size = new System.Drawing.Size(640, 324);
            this.displayAdmin.TabIndex = 1;
            // 
            // btnDisplayItem
            // 
            this.btnDisplayItem.Location = new System.Drawing.Point(557, 80);
            this.btnDisplayItem.Name = "btnDisplayItem";
            this.btnDisplayItem.Size = new System.Drawing.Size(117, 31);
            this.btnDisplayItem.TabIndex = 2;
            this.btnDisplayItem.Text = "Display Item";
            this.btnDisplayItem.UseVisualStyleBackColor = true;
            this.btnDisplayItem.Click += new System.EventHandler(this.btnDisplayItem_Click);
            // 
            // btnDisplayUser
            // 
            this.btnDisplayUser.Location = new System.Drawing.Point(403, 80);
            this.btnDisplayUser.Name = "btnDisplayUser";
            this.btnDisplayUser.Size = new System.Drawing.Size(117, 31);
            this.btnDisplayUser.TabIndex = 3;
            this.btnDisplayUser.Text = "Display User";
            this.btnDisplayUser.UseVisualStyleBackColor = true;
            this.btnDisplayUser.Click += new System.EventHandler(this.btnDisplayUser_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.Location = new System.Drawing.Point(34, 491);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(113, 40);
            this.btnLogout.TabIndex = 5;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(703, 149);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(113, 40);
            this.button1.TabIndex = 4;
            this.button1.Text = "button3";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(703, 263);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(113, 40);
            this.btnDelete.TabIndex = 4;
            this.btnDelete.Text = "Delete appliance";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(703, 149);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(113, 40);
            this.btnAdd.TabIndex = 4;
            this.btnAdd.Text = "Add appliance";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(703, 208);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(113, 40);
            this.btnEdit.TabIndex = 4;
            this.btnEdit.Text = "Edit appliance";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // admin_page
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(862, 556);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnDisplayUser);
            this.Controls.Add(this.btnDisplayItem);
            this.Controls.Add(this.displayAdmin);
            this.Controls.Add(this.label1);
            this.Name = "admin_page";
            this.Text = "admin";
            this.Load += new System.EventHandler(this.admin_page_Load);
            ((System.ComponentModel.ISupportInitialize)(this.displayAdmin)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView displayAdmin;
        private System.Windows.Forms.Button btnDisplayItem;
        private System.Windows.Forms.Button btnDisplayUser;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnEdit;
    }
}