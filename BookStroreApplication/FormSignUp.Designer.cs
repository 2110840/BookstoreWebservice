namespace BookStroreApplication
{
    partial class FormSignUp
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
            this.bt_Ok = new System.Windows.Forms.Button();
            this.bt_Cancel = new System.Windows.Forms.Button();
            this.txt_pass = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_user = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.radioBt_Yes = new System.Windows.Forms.RadioButton();
            this.radioBt_No = new System.Windows.Forms.RadioButton();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // bt_Ok
            // 
            this.bt_Ok.Location = new System.Drawing.Point(174, 156);
            this.bt_Ok.Name = "bt_Ok";
            this.bt_Ok.Size = new System.Drawing.Size(75, 23);
            this.bt_Ok.TabIndex = 11;
            this.bt_Ok.Text = "Ok";
            this.bt_Ok.UseVisualStyleBackColor = true;
            this.bt_Ok.Click += new System.EventHandler(this.bt_Ok_Click);
            // 
            // bt_Cancel
            // 
            this.bt_Cancel.Location = new System.Drawing.Point(54, 156);
            this.bt_Cancel.Name = "bt_Cancel";
            this.bt_Cancel.Size = new System.Drawing.Size(75, 23);
            this.bt_Cancel.TabIndex = 10;
            this.bt_Cancel.Text = "Cancel";
            this.bt_Cancel.UseVisualStyleBackColor = true;
            this.bt_Cancel.Click += new System.EventHandler(this.bt_Cancel_Click);
            // 
            // txt_pass
            // 
            this.txt_pass.Location = new System.Drawing.Point(105, 48);
            this.txt_pass.Name = "txt_pass";
            this.txt_pass.Size = new System.Drawing.Size(100, 20);
            this.txt_pass.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(42, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Password:";
            // 
            // txt_user
            // 
            this.txt_user.Location = new System.Drawing.Point(105, 16);
            this.txt_user.Name = "txt_user";
            this.txt_user.Size = new System.Drawing.Size(100, 20);
            this.txt_user.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Username:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(69, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Admin:";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.radioBt_No);
            this.panel1.Controls.Add(this.radioBt_Yes);
            this.panel1.Location = new System.Drawing.Point(115, 85);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(90, 54);
            this.panel1.TabIndex = 13;
            // 
            // radioBt_Yes
            // 
            this.radioBt_Yes.AutoSize = true;
            this.radioBt_Yes.Location = new System.Drawing.Point(2, 3);
            this.radioBt_Yes.Name = "radioBt_Yes";
            this.radioBt_Yes.Size = new System.Drawing.Size(43, 17);
            this.radioBt_Yes.TabIndex = 0;
            this.radioBt_Yes.Text = "Yes";
            this.radioBt_Yes.UseVisualStyleBackColor = true;
            // 
            // radioBt_No
            // 
            this.radioBt_No.AutoSize = true;
            this.radioBt_No.Checked = true;
            this.radioBt_No.Location = new System.Drawing.Point(3, 34);
            this.radioBt_No.Name = "radioBt_No";
            this.radioBt_No.Size = new System.Drawing.Size(39, 17);
            this.radioBt_No.TabIndex = 1;
            this.radioBt_No.TabStop = true;
            this.radioBt_No.Text = "No";
            this.radioBt_No.UseVisualStyleBackColor = true;
            // 
            // FormSignUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.bt_Ok);
            this.Controls.Add(this.bt_Cancel);
            this.Controls.Add(this.txt_pass);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_user);
            this.Controls.Add(this.label1);
            this.Name = "FormSignUp";
            this.Text = "FormSignUp";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bt_Ok;
        private System.Windows.Forms.Button bt_Cancel;
        private System.Windows.Forms.TextBox txt_pass;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_user;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton radioBt_No;
        private System.Windows.Forms.RadioButton radioBt_Yes;
    }
}