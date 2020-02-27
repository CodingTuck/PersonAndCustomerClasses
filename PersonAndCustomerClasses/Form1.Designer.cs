namespace PersonAndCustomerClasses
{
    partial class Form1
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
            this.nameLabel = new System.Windows.Forms.Label();
            this.addressLabel = new System.Windows.Forms.Label();
            this.phoneNumLabel = new System.Windows.Forms.Label();
            this.phoneNumTextBox = new System.Windows.Forms.TextBox();
            this.addressTextBox = new System.Windows.Forms.TextBox();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.customerNumLabel = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.mailingCheckBox = new System.Windows.Forms.CheckBox();
            this.mailingListLabel = new System.Windows.Forms.Label();
            this.customerNumTextBox = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.mailingListOutputLabel = new System.Windows.Forms.Label();
            this.customerNumOutputLabel = new System.Windows.Forms.Label();
            this.phoneNumOutputLabel = new System.Windows.Forms.Label();
            this.addressOutputLabel = new System.Windows.Forms.Label();
            this.nameOutputLabel = new System.Windows.Forms.Label();
            this.mailingListLabel2 = new System.Windows.Forms.Label();
            this.customerNumLabel2 = new System.Windows.Forms.Label();
            this.phoneNumLabel2 = new System.Windows.Forms.Label();
            this.addressLabel2 = new System.Windows.Forms.Label();
            this.nameLabel2 = new System.Windows.Forms.Label();
            this.subscriptionCreate = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(7, 22);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(38, 13);
            this.nameLabel.TabIndex = 0;
            this.nameLabel.Text = "Name:";
            // 
            // addressLabel
            // 
            this.addressLabel.AutoSize = true;
            this.addressLabel.Location = new System.Drawing.Point(7, 48);
            this.addressLabel.Name = "addressLabel";
            this.addressLabel.Size = new System.Drawing.Size(48, 13);
            this.addressLabel.TabIndex = 1;
            this.addressLabel.Text = "Address:";
            // 
            // phoneNumLabel
            // 
            this.phoneNumLabel.AutoSize = true;
            this.phoneNumLabel.Location = new System.Drawing.Point(7, 74);
            this.phoneNumLabel.Name = "phoneNumLabel";
            this.phoneNumLabel.Size = new System.Drawing.Size(81, 13);
            this.phoneNumLabel.TabIndex = 2;
            this.phoneNumLabel.Text = "Phone Number:";
            // 
            // phoneNumTextBox
            // 
            this.phoneNumTextBox.Location = new System.Drawing.Point(110, 74);
            this.phoneNumTextBox.Name = "phoneNumTextBox";
            this.phoneNumTextBox.Size = new System.Drawing.Size(100, 20);
            this.phoneNumTextBox.TabIndex = 3;
            // 
            // addressTextBox
            // 
            this.addressTextBox.Location = new System.Drawing.Point(110, 48);
            this.addressTextBox.Name = "addressTextBox";
            this.addressTextBox.Size = new System.Drawing.Size(100, 20);
            this.addressTextBox.TabIndex = 2;
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(110, 22);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(100, 20);
            this.nameTextBox.TabIndex = 1;
            // 
            // customerNumLabel
            // 
            this.customerNumLabel.AutoSize = true;
            this.customerNumLabel.Location = new System.Drawing.Point(6, 100);
            this.customerNumLabel.Name = "customerNumLabel";
            this.customerNumLabel.Size = new System.Drawing.Size(94, 13);
            this.customerNumLabel.TabIndex = 6;
            this.customerNumLabel.Text = "Customer Number:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.mailingCheckBox);
            this.groupBox1.Controls.Add(this.nameTextBox);
            this.groupBox1.Controls.Add(this.mailingListLabel);
            this.groupBox1.Controls.Add(this.customerNumLabel);
            this.groupBox1.Controls.Add(this.customerNumTextBox);
            this.groupBox1.Controls.Add(this.phoneNumLabel);
            this.groupBox1.Controls.Add(this.addressTextBox);
            this.groupBox1.Controls.Add(this.addressLabel);
            this.groupBox1.Controls.Add(this.phoneNumTextBox);
            this.groupBox1.Controls.Add(this.nameLabel);
            this.groupBox1.Location = new System.Drawing.Point(57, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(216, 164);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "User Information";
            // 
            // mailingCheckBox
            // 
            this.mailingCheckBox.AutoSize = true;
            this.mailingCheckBox.Location = new System.Drawing.Point(110, 129);
            this.mailingCheckBox.Name = "mailingCheckBox";
            this.mailingCheckBox.Size = new System.Drawing.Size(15, 14);
            this.mailingCheckBox.TabIndex = 5;
            this.mailingCheckBox.UseVisualStyleBackColor = true;
            // 
            // mailingListLabel
            // 
            this.mailingListLabel.AutoSize = true;
            this.mailingListLabel.Location = new System.Drawing.Point(6, 129);
            this.mailingListLabel.Name = "mailingListLabel";
            this.mailingListLabel.Size = new System.Drawing.Size(65, 13);
            this.mailingListLabel.TabIndex = 8;
            this.mailingListLabel.Text = "Mailing List?";
            // 
            // customerNumTextBox
            // 
            this.customerNumTextBox.Location = new System.Drawing.Point(110, 100);
            this.customerNumTextBox.Name = "customerNumTextBox";
            this.customerNumTextBox.Size = new System.Drawing.Size(100, 20);
            this.customerNumTextBox.TabIndex = 4;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.mailingListOutputLabel);
            this.groupBox2.Controls.Add(this.customerNumOutputLabel);
            this.groupBox2.Controls.Add(this.phoneNumOutputLabel);
            this.groupBox2.Controls.Add(this.addressOutputLabel);
            this.groupBox2.Controls.Add(this.nameOutputLabel);
            this.groupBox2.Controls.Add(this.mailingListLabel2);
            this.groupBox2.Controls.Add(this.customerNumLabel2);
            this.groupBox2.Controls.Add(this.phoneNumLabel2);
            this.groupBox2.Controls.Add(this.addressLabel2);
            this.groupBox2.Controls.Add(this.nameLabel2);
            this.groupBox2.Location = new System.Drawing.Point(373, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(226, 164);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "User Subscription Information";
            
            // 
            // mailingListOutputLabel
            // 
            this.mailingListOutputLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mailingListOutputLabel.Location = new System.Drawing.Point(110, 125);
            this.mailingListOutputLabel.Name = "mailingListOutputLabel";
            this.mailingListOutputLabel.Size = new System.Drawing.Size(97, 22);
            this.mailingListOutputLabel.TabIndex = 14;
            // 
            // customerNumOutputLabel
            // 
            this.customerNumOutputLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.customerNumOutputLabel.Location = new System.Drawing.Point(110, 99);
            this.customerNumOutputLabel.Name = "customerNumOutputLabel";
            this.customerNumOutputLabel.Size = new System.Drawing.Size(97, 22);
            this.customerNumOutputLabel.TabIndex = 13;
            // 
            // phoneNumOutputLabel
            // 
            this.phoneNumOutputLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.phoneNumOutputLabel.Location = new System.Drawing.Point(110, 73);
            this.phoneNumOutputLabel.Name = "phoneNumOutputLabel";
            this.phoneNumOutputLabel.Size = new System.Drawing.Size(97, 22);
            this.phoneNumOutputLabel.TabIndex = 12;
            // 
            // addressOutputLabel
            // 
            this.addressOutputLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.addressOutputLabel.Location = new System.Drawing.Point(110, 47);
            this.addressOutputLabel.Name = "addressOutputLabel";
            this.addressOutputLabel.Size = new System.Drawing.Size(97, 22);
            this.addressOutputLabel.TabIndex = 11;
            // 
            // nameOutputLabel
            // 
            this.nameOutputLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nameOutputLabel.Location = new System.Drawing.Point(110, 22);
            this.nameOutputLabel.Name = "nameOutputLabel";
            this.nameOutputLabel.Size = new System.Drawing.Size(97, 22);
            this.nameOutputLabel.TabIndex = 10;
            // 
            // mailingListLabel2
            // 
            this.mailingListLabel2.AutoSize = true;
            this.mailingListLabel2.Location = new System.Drawing.Point(6, 126);
            this.mailingListLabel2.Name = "mailingListLabel2";
            this.mailingListLabel2.Size = new System.Drawing.Size(65, 13);
            this.mailingListLabel2.TabIndex = 9;
            this.mailingListLabel2.Text = "Mailing List?";
            // 
            // customerNumLabel2
            // 
            this.customerNumLabel2.AutoSize = true;
            this.customerNumLabel2.Location = new System.Drawing.Point(6, 100);
            this.customerNumLabel2.Name = "customerNumLabel2";
            this.customerNumLabel2.Size = new System.Drawing.Size(94, 13);
            this.customerNumLabel2.TabIndex = 6;
            this.customerNumLabel2.Text = "Customer Number:";
            // 
            // phoneNumLabel2
            // 
            this.phoneNumLabel2.AutoSize = true;
            this.phoneNumLabel2.Location = new System.Drawing.Point(7, 74);
            this.phoneNumLabel2.Name = "phoneNumLabel2";
            this.phoneNumLabel2.Size = new System.Drawing.Size(81, 13);
            this.phoneNumLabel2.TabIndex = 2;
            this.phoneNumLabel2.Text = "Phone Number:";
            // 
            // addressLabel2
            // 
            this.addressLabel2.AutoSize = true;
            this.addressLabel2.Location = new System.Drawing.Point(7, 48);
            this.addressLabel2.Name = "addressLabel2";
            this.addressLabel2.Size = new System.Drawing.Size(48, 13);
            this.addressLabel2.TabIndex = 1;
            this.addressLabel2.Text = "Address:";
            // 
            // nameLabel2
            // 
            this.nameLabel2.AutoSize = true;
            this.nameLabel2.Location = new System.Drawing.Point(7, 22);
            this.nameLabel2.Name = "nameLabel2";
            this.nameLabel2.Size = new System.Drawing.Size(38, 13);
            this.nameLabel2.TabIndex = 0;
            this.nameLabel2.Text = "Name:";
            // 
            // subscriptionCreate
            // 
            this.subscriptionCreate.Location = new System.Drawing.Point(128, 182);
            this.subscriptionCreate.Name = "subscriptionCreate";
            this.subscriptionCreate.Size = new System.Drawing.Size(75, 51);
            this.subscriptionCreate.TabIndex = 6;
            this.subscriptionCreate.Text = "Create Subscription";
            this.subscriptionCreate.UseVisualStyleBackColor = true;
            this.subscriptionCreate.Click += new System.EventHandler(this.subscriptionCreate_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(437, 182);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 51);
            this.exitButton.TabIndex = 7;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(294, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 16);
            this.label1.TabIndex = 10;
            this.label1.Text = "--------->";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(621, 248);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.subscriptionCreate);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label addressLabel;
        private System.Windows.Forms.Label phoneNumLabel;
        private System.Windows.Forms.TextBox phoneNumTextBox;
        private System.Windows.Forms.TextBox addressTextBox;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.Label customerNumLabel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox mailingCheckBox;
        private System.Windows.Forms.Label mailingListLabel;
        private System.Windows.Forms.TextBox customerNumTextBox;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label mailingListLabel2;
        private System.Windows.Forms.Label customerNumLabel2;
        private System.Windows.Forms.Label phoneNumLabel2;
        private System.Windows.Forms.Label addressLabel2;
        private System.Windows.Forms.Label nameLabel2;
        private System.Windows.Forms.Button subscriptionCreate;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Label mailingListOutputLabel;
        private System.Windows.Forms.Label customerNumOutputLabel;
        private System.Windows.Forms.Label phoneNumOutputLabel;
        private System.Windows.Forms.Label addressOutputLabel;
        private System.Windows.Forms.Label nameOutputLabel;
        private System.Windows.Forms.Label label1;
    }
}

