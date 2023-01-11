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
            this.inputType = new System.Windows.Forms.TextBox();
            this.inputPower = new System.Windows.Forms.TextBox();
            this.inputTypical = new System.Windows.Forms.TextBox();
            this.inputCost = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
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
            this.label2.Location = new System.Drawing.Point(79, 124);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Type : ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(42, 166);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Power Usage :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(38, 209);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Typical Usage :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(42, 252);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Running Cost :";
            // 
            // inputType
            // 
            this.inputType.Location = new System.Drawing.Point(138, 117);
            this.inputType.Name = "inputType";
            this.inputType.Size = new System.Drawing.Size(158, 20);
            this.inputType.TabIndex = 5;
            // 
            // inputPower
            // 
            this.inputPower.Location = new System.Drawing.Point(138, 163);
            this.inputPower.Name = "inputPower";
            this.inputPower.Size = new System.Drawing.Size(158, 20);
            this.inputPower.TabIndex = 5;
            // 
            // inputTypical
            // 
            this.inputTypical.Location = new System.Drawing.Point(138, 206);
            this.inputTypical.Name = "inputTypical";
            this.inputTypical.Size = new System.Drawing.Size(158, 20);
            this.inputTypical.TabIndex = 5;
            // 
            // inputCost
            // 
            this.inputCost.Location = new System.Drawing.Point(138, 249);
            this.inputCost.Name = "inputCost";
            this.inputCost.Size = new System.Drawing.Size(158, 20);
            this.inputCost.TabIndex = 5;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(177, 307);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(91, 23);
            this.btnAdd.TabIndex = 6;
            this.btnAdd.Text = "Add ";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // add_item
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(341, 369);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.inputCost);
            this.Controls.Add(this.inputTypical);
            this.Controls.Add(this.inputPower);
            this.Controls.Add(this.inputType);
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
        private System.Windows.Forms.TextBox inputType;
        private System.Windows.Forms.TextBox inputPower;
        private System.Windows.Forms.TextBox inputTypical;
        private System.Windows.Forms.TextBox inputCost;
        private System.Windows.Forms.Button btnAdd;
    }
}