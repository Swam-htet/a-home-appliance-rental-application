namespace a_home_appliance_rental_application
{
    partial class add_item
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.inputName = new System.Windows.Forms.TextBox();
            this.inputPower = new System.Windows.Forms.TextBox();
            this.inputTypical = new System.Windows.Forms.TextBox();
            this.inputCost = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.inputType = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.inputDescription = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(77, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(178, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Add new appliance";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(104, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Name :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 166);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(132, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Power Usage ( by month ):";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(63, 209);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Typical Usage :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(63, 248);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Running Cost :";
            // 
            // inputName
            // 
            this.inputName.Location = new System.Drawing.Point(165, 113);
            this.inputName.Name = "inputName";
            this.inputName.Size = new System.Drawing.Size(169, 20);
            this.inputName.TabIndex = 5;
            // 
            // inputPower
            // 
            this.inputPower.Location = new System.Drawing.Point(165, 159);
            this.inputPower.Name = "inputPower";
            this.inputPower.Size = new System.Drawing.Size(169, 20);
            this.inputPower.TabIndex = 5;
            // 
            // inputTypical
            // 
            this.inputTypical.Location = new System.Drawing.Point(165, 202);
            this.inputTypical.Name = "inputTypical";
            this.inputTypical.Size = new System.Drawing.Size(169, 20);
            this.inputTypical.TabIndex = 5;
            // 
            // inputCost
            // 
            this.inputCost.Location = new System.Drawing.Point(165, 245);
            this.inputCost.Name = "inputCost";
            this.inputCost.Size = new System.Drawing.Size(169, 20);
            this.inputCost.TabIndex = 5;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(310, 415);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(101, 38);
            this.btnAdd.TabIndex = 6;
            this.btnAdd.Text = "Add ";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // inputType
            // 
            this.inputType.Location = new System.Drawing.Point(165, 277);
            this.inputType.Name = "inputType";
            this.inputType.Size = new System.Drawing.Size(169, 20);
            this.inputType.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(104, 284);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "Type :";
            // 
            // inputDescription
            // 
            this.inputDescription.Location = new System.Drawing.Point(165, 315);
            this.inputDescription.Multiline = true;
            this.inputDescription.Name = "inputDescription";
            this.inputDescription.Size = new System.Drawing.Size(169, 77);
            this.inputDescription.TabIndex = 10;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(74, 318);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(66, 13);
            this.label7.TabIndex = 9;
            this.label7.Text = "Description :";
            // 
            // add_item
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(423, 465);
            this.Controls.Add(this.inputDescription);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.inputType);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.inputCost);
            this.Controls.Add(this.inputTypical);
            this.Controls.Add(this.inputPower);
            this.Controls.Add(this.inputName);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "add_item";
            this.Text = "Adding New Appliance";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox inputName;
        private System.Windows.Forms.TextBox inputPower;
        private System.Windows.Forms.TextBox inputTypical;
        private System.Windows.Forms.TextBox inputCost;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox inputType;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox inputDescription;
        private System.Windows.Forms.Label label7;
    }
}