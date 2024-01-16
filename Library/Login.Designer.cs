namespace Library
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
            this.loginTextBox = new System.Windows.Forms.TextBox();
            this.loginBtn = new System.Windows.Forms.Button();
            this.inputStaffLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // loginTextBox
            // 
            this.loginTextBox.Font = new System.Drawing.Font("Bauhaus 93", 12F);
            this.loginTextBox.Location = new System.Drawing.Point(35, 90);
            this.loginTextBox.Name = "loginTextBox";
            this.loginTextBox.Size = new System.Drawing.Size(354, 43);
            this.loginTextBox.TabIndex = 0;
            // 
            // loginBtn
            // 
            this.loginBtn.Font = new System.Drawing.Font("Bauhaus 93", 12F);
            this.loginBtn.Location = new System.Drawing.Point(35, 168);
            this.loginBtn.Name = "loginBtn";
            this.loginBtn.Size = new System.Drawing.Size(354, 58);
            this.loginBtn.TabIndex = 1;
            this.loginBtn.Text = "Login";
            this.loginBtn.UseVisualStyleBackColor = true;
            this.loginBtn.Click += new System.EventHandler(this.loginBtn_Click);
            // 
            // inputStaffLabel
            // 
            this.inputStaffLabel.BackColor = System.Drawing.Color.RoyalBlue;
            this.inputStaffLabel.Font = new System.Drawing.Font("Bauhaus 93", 12F);
            this.inputStaffLabel.Location = new System.Drawing.Point(31, 31);
            this.inputStaffLabel.Name = "inputStaffLabel";
            this.inputStaffLabel.Size = new System.Drawing.Size(358, 35);
            this.inputStaffLabel.TabIndex = 2;
            this.inputStaffLabel.Text = "Input Staff Password:";
            this.inputStaffLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CornflowerBlue;
            this.ClientSize = new System.Drawing.Size(434, 264);
            this.Controls.Add(this.inputStaffLabel);
            this.Controls.Add(this.loginBtn);
            this.Controls.Add(this.loginTextBox);
            this.Name = "Login";
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox loginTextBox;
        private System.Windows.Forms.Button loginBtn;
        private System.Windows.Forms.Label inputStaffLabel;
    }
}