namespace Library
{
    partial class ManageMembers
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
            this.currentMembersListBox = new System.Windows.Forms.ListBox();
            this.currentMembersLabel = new System.Windows.Forms.Label();
            this.memberNameBox = new System.Windows.Forms.TextBox();
            this.memberNameLabel = new System.Windows.Forms.Label();
            this.memberNameButton = new System.Windows.Forms.Button();
            this.removeSelectedMember = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // currentMembersListBox
            // 
            this.currentMembersListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.currentMembersListBox.FormattingEnabled = true;
            this.currentMembersListBox.ItemHeight = 20;
            this.currentMembersListBox.Location = new System.Drawing.Point(12, 35);
            this.currentMembersListBox.Name = "currentMembersListBox";
            this.currentMembersListBox.Size = new System.Drawing.Size(248, 324);
            this.currentMembersListBox.TabIndex = 0;
            // 
            // currentMembersLabel
            // 
            this.currentMembersLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.currentMembersLabel.Location = new System.Drawing.Point(57, 9);
            this.currentMembersLabel.Name = "currentMembersLabel";
            this.currentMembersLabel.Size = new System.Drawing.Size(137, 23);
            this.currentMembersLabel.TabIndex = 1;
            this.currentMembersLabel.Text = "Current Members:";
            // 
            // memberNameBox
            // 
            this.memberNameBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.memberNameBox.Location = new System.Drawing.Point(270, 110);
            this.memberNameBox.Name = "memberNameBox";
            this.memberNameBox.Size = new System.Drawing.Size(156, 26);
            this.memberNameBox.TabIndex = 2;
            // 
            // memberNameLabel
            // 
            this.memberNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.memberNameLabel.Location = new System.Drawing.Point(266, 84);
            this.memberNameLabel.Name = "memberNameLabel";
            this.memberNameLabel.Size = new System.Drawing.Size(160, 23);
            this.memberNameLabel.TabIndex = 3;
            this.memberNameLabel.Text = "New Member Name:";
            this.memberNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // memberNameButton
            // 
            this.memberNameButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.memberNameButton.Location = new System.Drawing.Point(270, 142);
            this.memberNameButton.Name = "memberNameButton";
            this.memberNameButton.Size = new System.Drawing.Size(156, 49);
            this.memberNameButton.TabIndex = 4;
            this.memberNameButton.Text = "Add Member";
            this.memberNameButton.UseVisualStyleBackColor = true;
            this.memberNameButton.Click += new System.EventHandler(this.memberNameButton_Click);
            // 
            // removeSelectedMember
            // 
            this.removeSelectedMember.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.removeSelectedMember.Location = new System.Drawing.Point(270, 201);
            this.removeSelectedMember.Name = "removeSelectedMember";
            this.removeSelectedMember.Size = new System.Drawing.Size(156, 56);
            this.removeSelectedMember.TabIndex = 5;
            this.removeSelectedMember.Text = "Remove Selected Member";
            this.removeSelectedMember.UseVisualStyleBackColor = true;
            this.removeSelectedMember.Click += new System.EventHandler(this.removeSelectedMember_Click);
            // 
            // ManageMembers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(438, 367);
            this.Controls.Add(this.removeSelectedMember);
            this.Controls.Add(this.memberNameButton);
            this.Controls.Add(this.memberNameLabel);
            this.Controls.Add(this.memberNameBox);
            this.Controls.Add(this.currentMembersLabel);
            this.Controls.Add(this.currentMembersListBox);
            this.Name = "ManageMembers";
            this.Text = "ManageMembers";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox currentMembersListBox;
        private System.Windows.Forms.Label currentMembersLabel;
        private System.Windows.Forms.TextBox memberNameBox;
        private System.Windows.Forms.Label memberNameLabel;
        private System.Windows.Forms.Button memberNameButton;
        private System.Windows.Forms.Button removeSelectedMember;
    }
}