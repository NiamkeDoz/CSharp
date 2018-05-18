namespace SimpleForm
{
    partial class Login
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
            this.Username = new System.Windows.Forms.TextBox();
            this.pwd = new System.Windows.Forms.TextBox();
            this.LoginBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.unameError = new System.Windows.Forms.Label();
            this.passError = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Username
            // 
            this.Username.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.Username.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Username.Location = new System.Drawing.Point(390, 297);
            this.Username.Name = "Username";
            this.Username.Size = new System.Drawing.Size(213, 31);
            this.Username.TabIndex = 2;
            this.Username.Text = "Username";
            this.Username.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Username.Enter += new System.EventHandler(this.Username_Enter);
            this.Username.Leave += new System.EventHandler(this.Username_Leave);
            // 
            // pwd
            // 
            this.pwd.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.pwd.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pwd.Location = new System.Drawing.Point(390, 370);
            this.pwd.Name = "pwd";
            this.pwd.Size = new System.Drawing.Size(213, 31);
            this.pwd.TabIndex = 3;
            this.pwd.Text = "Password";
            this.pwd.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.pwd.Enter += new System.EventHandler(this.Password_Enter);
            this.pwd.Leave += new System.EventHandler(this.Password_Leave);
            // 
            // LoginBtn
            // 
            this.LoginBtn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoginBtn.Location = new System.Drawing.Point(764, 560);
            this.LoginBtn.Name = "LoginBtn";
            this.LoginBtn.Size = new System.Drawing.Size(166, 55);
            this.LoginBtn.TabIndex = 4;
            this.LoginBtn.Text = "Login";
            this.LoginBtn.UseVisualStyleBackColor = true;
            this.LoginBtn.Click += new System.EventHandler(this.LoginBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Algerian", 75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(201, 109);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(602, 111);
            this.label1.TabIndex = 5;
            this.label1.Text = "Car Finder";
            // 
            // unameError
            // 
            this.unameError.AutoSize = true;
            this.unameError.Location = new System.Drawing.Point(315, 312);
            this.unameError.Name = "unameError";
            this.unameError.Size = new System.Drawing.Size(0, 13);
            this.unameError.TabIndex = 6;
            // 
            // passError
            // 
            this.passError.AutoSize = true;
            this.passError.Location = new System.Drawing.Point(315, 382);
            this.passError.Name = "passError";
            this.passError.Size = new System.Drawing.Size(0, 13);
            this.passError.TabIndex = 7;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Firebrick;
            this.ClientSize = new System.Drawing.Size(969, 663);
            this.Controls.Add(this.passError);
            this.Controls.Add(this.unameError);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LoginBtn);
            this.Controls.Add(this.pwd);
            this.Controls.Add(this.Username);
            this.Name = "Login";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox Username;
        private System.Windows.Forms.TextBox pwd;
        private System.Windows.Forms.Button LoginBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label unameError;
        private System.Windows.Forms.Label passError;
    }
}

