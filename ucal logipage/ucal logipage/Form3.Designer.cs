namespace ucal_logipage
{
    partial class Form3
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
            this.LOGIN = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.USER = new System.Windows.Forms.Label();
            this.USERNAME = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // LOGIN
            // 
            this.LOGIN.Location = new System.Drawing.Point(212, 250);
            this.LOGIN.Name = "LOGIN";
            this.LOGIN.Size = new System.Drawing.Size(75, 23);
            this.LOGIN.TabIndex = 0;
            this.LOGIN.Text = "LOGIN";
            this.LOGIN.UseVisualStyleBackColor = true;
            this.LOGIN.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(418, 250);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "CANCEL";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // USER
            // 
            this.USER.AutoSize = true;
            this.USER.Location = new System.Drawing.Point(188, 75);
            this.USER.Name = "USER";
            this.USER.Size = new System.Drawing.Size(45, 16);
            this.USER.TabIndex = 2;
            this.USER.Text = "USER";
            // 
            // USERNAME
            // 
            this.USERNAME.AutoSize = true;
            this.USERNAME.Location = new System.Drawing.Point(188, 134);
            this.USERNAME.Name = "USERNAME";
            this.USERNAME.Size = new System.Drawing.Size(84, 16);
            this.USERNAME.TabIndex = 4;
            this.USERNAME.Text = "USERNAME";
            // 
            // txtPassword
            // 
            this.txtPassword.AutoSize = true;
            this.txtPassword.Location = new System.Drawing.Point(188, 200);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(86, 16);
            this.txtPassword.TabIndex = 5;
            this.txtPassword.Text = "PASSWORD";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(380, 134);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 22);
            this.textBox2.TabIndex = 6;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(380, 200);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 22);
            this.textBox3.TabIndex = 7;
            this.textBox3.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(359, 75);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(157, 24);
            this.comboBox1.TabIndex = 8;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(486, 202);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(18, 17);
            this.checkBox1.TabIndex = 9;
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.USERNAME);
            this.Controls.Add(this.USER);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.LOGIN);
            this.Name = "Form3";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button LOGIN;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label USER;
        private System.Windows.Forms.Label USERNAME;
        private System.Windows.Forms.Label txtPassword;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.CheckBox checkBox1;
    }
}