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
            this.displayUserList = new System.Windows.Forms.DataGridView();
            this.displayItemList = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.btnRrefresh = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.displayUserList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.displayItemList)).BeginInit();
            this.SuspendLayout();
            // 
            // Administrator
            // 
            this.Administrator.AutoSize = true;
            this.Administrator.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Administrator.Location = new System.Drawing.Point(47, 31);
            this.Administrator.Name = "Administrator";
            this.Administrator.Size = new System.Drawing.Size(174, 31);
            this.Administrator.TabIndex = 0;
            this.Administrator.Text = "Administrator";
            // 
            // btnLogout
            // 
            this.btnLogout.Location = new System.Drawing.Point(12, 644);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(113, 40);
            this.btnLogout.TabIndex = 5;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(638, 625);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(113, 40);
            this.btnDelete.TabIndex = 4;
            this.btnDelete.Text = "Delete appliance";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(352, 625);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(113, 40);
            this.btnAdd.TabIndex = 4;
            this.btnAdd.Text = "Add appliance";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(506, 625);
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
            this.label2.Location = new System.Drawing.Point(90, 326);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Name :";
            // 
            // inputName
            // 
            this.inputName.Location = new System.Drawing.Point(137, 323);
            this.inputName.Name = "inputName";
            this.inputName.Size = new System.Drawing.Size(151, 20);
            this.inputName.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(54, 363);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Power Usage :";
            // 
            // inputPower
            // 
            this.inputPower.Location = new System.Drawing.Point(137, 360);
            this.inputPower.Name = "inputPower";
            this.inputPower.Size = new System.Drawing.Size(151, 20);
            this.inputPower.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(50, 401);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Typical Usage :";
            // 
            // inputUsage
            // 
            this.inputUsage.Location = new System.Drawing.Point(137, 398);
            this.inputUsage.Name = "inputUsage";
            this.inputUsage.Size = new System.Drawing.Size(151, 20);
            this.inputUsage.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(54, 440);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Running Cost :";
            // 
            // inputCost
            // 
            this.inputCost.Location = new System.Drawing.Point(137, 437);
            this.inputCost.Name = "inputCost";
            this.inputCost.Size = new System.Drawing.Size(151, 20);
            this.inputCost.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(94, 479);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Type :";
            // 
            // inputType
            // 
            this.inputType.Location = new System.Drawing.Point(137, 476);
            this.inputType.Name = "inputType";
            this.inputType.Size = new System.Drawing.Size(151, 20);
            this.inputType.TabIndex = 7;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(65, 525);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(66, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Description :";
            // 
            // inputDescription
            // 
            this.inputDescription.Location = new System.Drawing.Point(137, 512);
            this.inputDescription.Multiline = true;
            this.inputDescription.Name = "inputDescription";
            this.inputDescription.Size = new System.Drawing.Size(151, 91);
            this.inputDescription.TabIndex = 7;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(107, 287);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(24, 13);
            this.label8.TabIndex = 6;
            this.label8.Text = "ID :";
            // 
            // inputID
            // 
            this.inputID.Location = new System.Drawing.Point(137, 284);
            this.inputID.Name = "inputID";
            this.inputID.Size = new System.Drawing.Size(151, 20);
            this.inputID.TabIndex = 7;
            // 
            // displayUserList
            // 
            this.displayUserList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.displayUserList.Location = new System.Drawing.Point(475, 87);
            this.displayUserList.Name = "displayUserList";
            this.displayUserList.Size = new System.Drawing.Size(644, 179);
            this.displayUserList.TabIndex = 1;
            // 
            // displayItemList
            // 
            this.displayItemList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.displayItemList.Location = new System.Drawing.Point(352, 346);
            this.displayItemList.Name = "displayItemList";
            this.displayItemList.Size = new System.Drawing.Size(767, 257);
            this.displayItemList.TabIndex = 1;
            this.displayItemList.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.displayItemList_CellEnter);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(347, 303);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 25);
            this.label1.TabIndex = 8;
            this.label1.Text = "Appliance List";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(470, 47);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(165, 25);
            this.label9.TabIndex = 9;
            this.label9.Text = "User Account List";
            // 
            // btnRrefresh
            // 
            this.btnRrefresh.Location = new System.Drawing.Point(983, 298);
            this.btnRrefresh.Name = "btnRrefresh";
            this.btnRrefresh.Size = new System.Drawing.Size(136, 41);
            this.btnRrefresh.TabIndex = 10;
            this.btnRrefresh.Text = "Refresh Displays Here";
            this.btnRrefresh.UseVisualStyleBackColor = true;
            this.btnRrefresh.Click += new System.EventHandler(this.btnRrefresh_Click);
            // 
            // admin_page
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1153, 711);
            this.Controls.Add(this.btnRrefresh);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label1);
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
            this.Controls.Add(this.displayUserList);
            this.Controls.Add(this.displayItemList);
            this.Controls.Add(this.Administrator);
            this.Name = "admin_page";
            this.Text = "admin";
            this.Load += new System.EventHandler(this.admin_page_Load);
            ((System.ComponentModel.ISupportInitialize)(this.displayUserList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.displayItemList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Administrator;
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
        private System.Windows.Forms.DataGridView displayUserList;
        private System.Windows.Forms.DataGridView displayItemList;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnRrefresh;
    }
}