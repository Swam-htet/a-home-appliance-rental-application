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
            this.Administrator = new System.Windows.Forms.Label();
            this.displayAdmin = new System.Windows.Forms.DataGridView();
            this.btnDisplayItem = new System.Windows.Forms.Button();
            this.btnDisplayUser = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.inputName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.inputPower = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.inputUsage = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.inputCost = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.inputType = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.inputDescription = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.inputID = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.displayAdmin)).BeginInit();
            this.SuspendLayout();
            // 
            // Administrator
            // 
            this.Administrator.AutoSize = true;
            this.Administrator.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Administrator.Location = new System.Drawing.Point(38, 61);
            this.Administrator.Name = "Administrator";
            this.Administrator.Size = new System.Drawing.Size(174, 31);
            this.Administrator.TabIndex = 0;
            this.Administrator.Text = "Administrator";
            // 
            // displayAdmin
            // 
            this.displayAdmin.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.displayAdmin.Location = new System.Drawing.Point(34, 143);
            this.displayAdmin.Name = "displayAdmin";
            this.displayAdmin.Size = new System.Drawing.Size(774, 342);
            this.displayAdmin.TabIndex = 1;
            this.displayAdmin.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.displayAdmin_CellEnter);
            // 
            // btnDisplayItem
            // 
            this.btnDisplayItem.Location = new System.Drawing.Point(691, 93);
            this.btnDisplayItem.Name = "btnDisplayItem";
            this.btnDisplayItem.Size = new System.Drawing.Size(117, 31);
            this.btnDisplayItem.TabIndex = 2;
            this.btnDisplayItem.Text = "Display Item";
            this.btnDisplayItem.UseVisualStyleBackColor = true;
            this.btnDisplayItem.Click += new System.EventHandler(this.btnDisplayItem_Click);
            // 
            // btnDisplayUser
            // 
            this.btnDisplayUser.Location = new System.Drawing.Point(537, 93);
            this.btnDisplayUser.Name = "btnDisplayUser";
            this.btnDisplayUser.Size = new System.Drawing.Size(117, 31);
            this.btnDisplayUser.TabIndex = 3;
            this.btnDisplayUser.Text = "Display User";
            this.btnDisplayUser.UseVisualStyleBackColor = true;
            this.btnDisplayUser.Click += new System.EventHandler(this.btnDisplayUser_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.Location = new System.Drawing.Point(23, 543);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(113, 40);
            this.btnLogout.TabIndex = 5;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(964, 525);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(113, 40);
            this.btnDelete.TabIndex = 4;
            this.btnDelete.Text = "Delete appliance";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(687, 525);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(113, 40);
            this.btnAdd.TabIndex = 4;
            this.btnAdd.Text = "Add appliance";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(829, 525);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(113, 40);
            this.btnEdit.TabIndex = 4;
            this.btnEdit.Text = "Edit appliance";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(879, 208);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Name :";
            // 
            // inputName
            // 
            this.inputName.Location = new System.Drawing.Point(926, 205);
            this.inputName.Name = "inputName";
            this.inputName.Size = new System.Drawing.Size(151, 20);
            this.inputName.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(843, 245);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Power Usage :";
            // 
            // inputPower
            // 
            this.inputPower.Location = new System.Drawing.Point(926, 242);
            this.inputPower.Name = "inputPower";
            this.inputPower.Size = new System.Drawing.Size(151, 20);
            this.inputPower.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(843, 283);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Typical Usage :";
            // 
            // inputUsage
            // 
            this.inputUsage.Location = new System.Drawing.Point(926, 280);
            this.inputUsage.Name = "inputUsage";
            this.inputUsage.Size = new System.Drawing.Size(151, 20);
            this.inputUsage.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(843, 322);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Running Cost :";
            // 
            // inputCost
            // 
            this.inputCost.Location = new System.Drawing.Point(926, 319);
            this.inputCost.Name = "inputCost";
            this.inputCost.Size = new System.Drawing.Size(151, 20);
            this.inputCost.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(883, 365);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Type :";
            // 
            // inputType
            // 
            this.inputType.Location = new System.Drawing.Point(926, 358);
            this.inputType.Name = "inputType";
            this.inputType.Size = new System.Drawing.Size(151, 20);
            this.inputType.TabIndex = 7;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(854, 397);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(66, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Description :";
            // 
            // inputDescription
            // 
            this.inputDescription.Location = new System.Drawing.Point(926, 394);
            this.inputDescription.Multiline = true;
            this.inputDescription.Name = "inputDescription";
            this.inputDescription.Size = new System.Drawing.Size(151, 91);
            this.inputDescription.TabIndex = 7;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(896, 151);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(24, 13);
            this.label8.TabIndex = 6;
            this.label8.Text = "ID :";
            // 
            // inputID
            // 
            this.inputID.Location = new System.Drawing.Point(926, 144);
            this.inputID.Name = "inputID";
            this.inputID.Size = new System.Drawing.Size(151, 20);
            this.inputID.TabIndex = 7;
            // 
            // admin_page
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1109, 620);
            this.Controls.Add(this.inputID);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.inputDescription);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.inputType);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.inputCost);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.inputUsage);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.inputPower);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.inputName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnDisplayUser);
            this.Controls.Add(this.btnDisplayItem);
            this.Controls.Add(this.displayAdmin);
            this.Controls.Add(this.Administrator);
            this.Name = "admin_page";
            this.Text = "admin";
            this.Load += new System.EventHandler(this.admin_page_Load);
            ((System.ComponentModel.ISupportInitialize)(this.displayAdmin)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Administrator;
        private System.Windows.Forms.DataGridView displayAdmin;
        private System.Windows.Forms.Button btnDisplayItem;
        private System.Windows.Forms.Button btnDisplayUser;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox inputName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox inputPower;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox inputUsage;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox inputCost;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox inputType;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox inputDescription;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox inputID;
    }
}