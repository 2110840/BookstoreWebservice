namespace BookStroreApplication
{
    partial class FormMain
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
            this.bt_LogIn = new System.Windows.Forms.Button();
            this.bt_Go = new System.Windows.Forms.Button();
            this.bt_SignUp = new System.Windows.Forms.Button();
            this.bt_LogOut = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cbox_Operation = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBox_OutPut = new System.Windows.Forms.TextBox();
            this.cb_teste = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // bt_LogIn
            // 
            this.bt_LogIn.Location = new System.Drawing.Point(69, 28);
            this.bt_LogIn.Name = "bt_LogIn";
            this.bt_LogIn.Size = new System.Drawing.Size(75, 23);
            this.bt_LogIn.TabIndex = 0;
            this.bt_LogIn.Text = "Log In";
            this.bt_LogIn.UseVisualStyleBackColor = true;
            this.bt_LogIn.Click += new System.EventHandler(this.bt_LogIn_Click);
            // 
            // bt_Go
            // 
            this.bt_Go.Location = new System.Drawing.Point(231, 96);
            this.bt_Go.Name = "bt_Go";
            this.bt_Go.Size = new System.Drawing.Size(75, 23);
            this.bt_Go.TabIndex = 1;
            this.bt_Go.Text = "Go!";
            this.bt_Go.UseVisualStyleBackColor = true;
            this.bt_Go.Click += new System.EventHandler(this.bt_Go_Click);
            // 
            // bt_SignUp
            // 
            this.bt_SignUp.Location = new System.Drawing.Point(231, 28);
            this.bt_SignUp.Name = "bt_SignUp";
            this.bt_SignUp.Size = new System.Drawing.Size(75, 23);
            this.bt_SignUp.TabIndex = 2;
            this.bt_SignUp.Text = "Sign Up";
            this.bt_SignUp.UseVisualStyleBackColor = true;
            this.bt_SignUp.Click += new System.EventHandler(this.bt_SignUp_Click);
            // 
            // bt_LogOut
            // 
            this.bt_LogOut.Location = new System.Drawing.Point(150, 28);
            this.bt_LogOut.Name = "bt_LogOut";
            this.bt_LogOut.Size = new System.Drawing.Size(75, 23);
            this.bt_LogOut.TabIndex = 3;
            this.bt_LogOut.Text = "Log Out";
            this.bt_LogOut.UseVisualStyleBackColor = true;
            this.bt_LogOut.Click += new System.EventHandler(this.bt_LogOut_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(69, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Operation:";
            // 
            // cbox_Operation
            // 
            this.cbox_Operation.FormattingEnabled = true;
            this.cbox_Operation.Items.AddRange(new object[] {
            "Get Books"});
            this.cbox_Operation.Location = new System.Drawing.Point(150, 67);
            this.cbox_Operation.Name = "cbox_Operation";
            this.cbox_Operation.Size = new System.Drawing.Size(156, 21);
            this.cbox_Operation.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 132);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "OutPut:";
            // 
            // txtBox_OutPut
            // 
            this.txtBox_OutPut.Location = new System.Drawing.Point(13, 161);
            this.txtBox_OutPut.Multiline = true;
            this.txtBox_OutPut.Name = "txtBox_OutPut";
            this.txtBox_OutPut.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtBox_OutPut.Size = new System.Drawing.Size(319, 169);
            this.txtBox_OutPut.TabIndex = 7;
            // 
            // cb_teste
            // 
            this.cb_teste.FormattingEnabled = true;
            this.cb_teste.Location = new System.Drawing.Point(15, 98);
            this.cb_teste.Name = "cb_teste";
            this.cb_teste.Size = new System.Drawing.Size(121, 21);
            this.cb_teste.TabIndex = 8;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(357, 367);
            this.Controls.Add(this.cb_teste);
            this.Controls.Add(this.txtBox_OutPut);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbox_Operation);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bt_LogOut);
            this.Controls.Add(this.bt_SignUp);
            this.Controls.Add(this.bt_Go);
            this.Controls.Add(this.bt_LogIn);
            this.Name = "FormMain";
            this.Text = "Form1";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormMain_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bt_LogIn;
        private System.Windows.Forms.Button bt_Go;
        private System.Windows.Forms.Button bt_SignUp;
        private System.Windows.Forms.Button bt_LogOut;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbox_Operation;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBox_OutPut;
        private System.Windows.Forms.ComboBox cb_teste;
    }
}

