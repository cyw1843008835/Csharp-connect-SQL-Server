namespace WindowsFormsApp1
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
            this.EXIT_Button = new System.Windows.Forms.Button();
            this.LOGIN_Button = new System.Windows.Forms.Button();
            this.USERNAME_textBox1 = new System.Windows.Forms.TextBox();
            this.PASSWORD_textBox2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // EXIT_Button
            // 
            this.EXIT_Button.Location = new System.Drawing.Point(552, 330);
            this.EXIT_Button.Name = "EXIT_Button";
            this.EXIT_Button.Size = new System.Drawing.Size(130, 60);
            this.EXIT_Button.TabIndex = 0;
            this.EXIT_Button.Text = "EXIT";
            this.EXIT_Button.UseVisualStyleBackColor = true;
            this.EXIT_Button.Click += new System.EventHandler(this.EXIT_Button_Click);
            // 
            // LOGIN_Button
            // 
            this.LOGIN_Button.Location = new System.Drawing.Point(787, 330);
            this.LOGIN_Button.Name = "LOGIN_Button";
            this.LOGIN_Button.Size = new System.Drawing.Size(130, 60);
            this.LOGIN_Button.TabIndex = 1;
            this.LOGIN_Button.Text = "LOGIN";
            this.LOGIN_Button.UseVisualStyleBackColor = true;
            this.LOGIN_Button.Click += new System.EventHandler(this.LOGIN_Button_Click);
            // 
            // USERNAME_textBox1
            // 
            this.USERNAME_textBox1.Location = new System.Drawing.Point(552, 99);
            this.USERNAME_textBox1.Name = "USERNAME_textBox1";
            this.USERNAME_textBox1.Size = new System.Drawing.Size(365, 31);
            this.USERNAME_textBox1.TabIndex = 2;
            // 
            // PASSWORD_textBox2
            // 
            this.PASSWORD_textBox2.Location = new System.Drawing.Point(552, 197);
            this.PASSWORD_textBox2.Name = "PASSWORD_textBox2";
            this.PASSWORD_textBox2.Size = new System.Drawing.Size(365, 31);
            this.PASSWORD_textBox2.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(406, 97);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 24);
            this.label1.TabIndex = 4;
            this.label1.Text = "USERNAME";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(406, 197);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 24);
            this.label2.TabIndex = 5;
            this.label2.Text = "PASSWORD";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1044, 516);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PASSWORD_textBox2);
            this.Controls.Add(this.USERNAME_textBox1);
            this.Controls.Add(this.LOGIN_Button);
            this.Controls.Add(this.EXIT_Button);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button EXIT_Button;
        private System.Windows.Forms.Button LOGIN_Button;
        private System.Windows.Forms.TextBox USERNAME_textBox1;
        private System.Windows.Forms.TextBox PASSWORD_textBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

