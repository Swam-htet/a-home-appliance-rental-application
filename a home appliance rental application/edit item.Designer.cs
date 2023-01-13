namespace a_home_appliance_rental_application
{
    partial class edit_item
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
            this.inputChoose = new System.Windows.Forms.ComboBox();
            this.inputChange = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Change = new System.Windows.Forms.Label();
            this.btnEdit = new System.Windows.Forms.Button();
            this.inputSearch = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(36, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Edit Appliance ";
            // 
            // inputChoose
            // 
            this.inputChoose.FormattingEnabled = true;
            this.inputChoose.Items.AddRange(new object[] {
            "id",
            "name",
            "powerUsage",
            "typicalUsage",
            "runningCost"});
            this.inputChoose.Location = new System.Drawing.Point(155, 170);
            this.inputChoose.Name = "inputChoose";
            this.inputChoose.Size = new System.Drawing.Size(161, 21);
            this.inputChoose.TabIndex = 1;
            // 
            // inputChange
            // 
            this.inputChange.Location = new System.Drawing.Point(155, 220);
            this.inputChange.Name = "inputChange";
            this.inputChange.Size = new System.Drawing.Size(160, 20);
            this.inputChange.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 170);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Choose column :";
            // 
            // Change
            // 
            this.Change.AutoSize = true;
            this.Change.Location = new System.Drawing.Point(69, 223);
            this.Change.Name = "Change";
            this.Change.Size = new System.Drawing.Size(55, 13);
            this.Change.TabIndex = 4;
            this.Change.Text = "Changes :";
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(153, 292);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(82, 35);
            this.btnEdit.TabIndex = 5;
            this.btnEdit.Text = "Edit ";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // inputSearch
            // 
            this.inputSearch.Location = new System.Drawing.Point(155, 121);
            this.inputSearch.Name = "inputSearch";
            this.inputSearch.Size = new System.Drawing.Size(161, 20);
            this.inputSearch.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(100, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(24, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "ID :";
            // 
            // edit_item
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(370, 350);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.inputSearch);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.Change);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.inputChange);
            this.Controls.Add(this.inputChoose);
            this.Controls.Add(this.label1);
            this.Name = "edit_item";
            this.Text = "Editing Appliance";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox inputChoose;
        private System.Windows.Forms.TextBox inputChange;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label Change;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.TextBox inputSearch;
        private System.Windows.Forms.Label label3;
    }
}