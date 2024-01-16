using System.ComponentModel;

namespace Library
{
    partial class BookSpecific
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

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
            this.labelCurrentBorrower = new System.Windows.Forms.Label();
            this.labelHistoryOfBorrowers = new System.Windows.Forms.Label();
            this.listBoxHistory = new System.Windows.Forms.ListBox();
            this.currentBorrowerValueLabel = new System.Windows.Forms.Label();
            this.loanBookButton = new System.Windows.Forms.Button();
            this.returnBookButton = new System.Windows.Forms.Button();
            this.membersComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.borrowDateSelect = new System.Windows.Forms.DateTimePicker();
            this.borrowDateSelectLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelCurrentBorrower
            // 
            this.labelCurrentBorrower.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelCurrentBorrower.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.labelCurrentBorrower.Location = new System.Drawing.Point(30, 279);
            this.labelCurrentBorrower.Name = "labelCurrentBorrower";
            this.labelCurrentBorrower.Size = new System.Drawing.Size(746, 33);
            this.labelCurrentBorrower.TabIndex = 3;
            this.labelCurrentBorrower.Text = "Current Borrower: ";
            this.labelCurrentBorrower.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelHistoryOfBorrowers
            // 
            this.labelHistoryOfBorrowers.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelHistoryOfBorrowers.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.labelHistoryOfBorrowers.Location = new System.Drawing.Point(30, 374);
            this.labelHistoryOfBorrowers.Name = "labelHistoryOfBorrowers";
            this.labelHistoryOfBorrowers.Size = new System.Drawing.Size(746, 25);
            this.labelHistoryOfBorrowers.TabIndex = 4;
            this.labelHistoryOfBorrowers.Text = "History of borrowers:";
            this.labelHistoryOfBorrowers.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // listBoxHistory
            // 
            this.listBoxHistory.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.listBoxHistory.FormattingEnabled = true;
            this.listBoxHistory.ItemHeight = 25;
            this.listBoxHistory.Location = new System.Drawing.Point(30, 411);
            this.listBoxHistory.Name = "listBoxHistory";
            this.listBoxHistory.Size = new System.Drawing.Size(746, 129);
            this.listBoxHistory.TabIndex = 5;
            // 
            // currentBorrowerValueLabel
            // 
            this.currentBorrowerValueLabel.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.currentBorrowerValueLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.currentBorrowerValueLabel.Location = new System.Drawing.Point(30, 324);
            this.currentBorrowerValueLabel.Name = "currentBorrowerValueLabel";
            this.currentBorrowerValueLabel.Size = new System.Drawing.Size(746, 34);
            this.currentBorrowerValueLabel.TabIndex = 6;
            this.currentBorrowerValueLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // loanBookButton
            // 
            this.loanBookButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.loanBookButton.Location = new System.Drawing.Point(30, 52);
            this.loanBookButton.Name = "loanBookButton";
            this.loanBookButton.Size = new System.Drawing.Size(179, 71);
            this.loanBookButton.TabIndex = 7;
            this.loanBookButton.Text = "Loan Book ";
            this.loanBookButton.UseVisualStyleBackColor = true;
            this.loanBookButton.Click += new System.EventHandler(this.loanBookButton_Click);
            // 
            // returnBookButton
            // 
            this.returnBookButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.returnBookButton.Location = new System.Drawing.Point(595, 52);
            this.returnBookButton.Name = "returnBookButton";
            this.returnBookButton.Size = new System.Drawing.Size(181, 71);
            this.returnBookButton.TabIndex = 8;
            this.returnBookButton.Text = "Return Book ";
            this.returnBookButton.UseVisualStyleBackColor = true;
            this.returnBookButton.Click += new System.EventHandler(this.returnBookButton_Click);
            // 
            // membersComboBox
            // 
            this.membersComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.membersComboBox.FormattingEnabled = true;
            this.membersComboBox.Location = new System.Drawing.Point(250, 86);
            this.membersComboBox.Name = "membersComboBox";
            this.membersComboBox.Size = new System.Drawing.Size(309, 37);
            this.membersComboBox.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(250, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(309, 23);
            this.label1.TabIndex = 10;
            this.label1.Text = "Member Select:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // borrowDateSelect
            // 
            this.borrowDateSelect.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.borrowDateSelect.Location = new System.Drawing.Point(250, 194);
            this.borrowDateSelect.Name = "borrowDateSelect";
            this.borrowDateSelect.Size = new System.Drawing.Size(309, 22);
            this.borrowDateSelect.TabIndex = 11;
            // 
            // borrowDateSelectLabel
            // 
            this.borrowDateSelectLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.borrowDateSelectLabel.Location = new System.Drawing.Point(245, 159);
            this.borrowDateSelectLabel.Name = "borrowDateSelectLabel";
            this.borrowDateSelectLabel.Size = new System.Drawing.Size(309, 23);
            this.borrowDateSelectLabel.TabIndex = 12;
            this.borrowDateSelectLabel.Text = "Borrow Date Select:";
            this.borrowDateSelectLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BookSpecific
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 551);
            this.Controls.Add(this.borrowDateSelectLabel);
            this.Controls.Add(this.borrowDateSelect);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.membersComboBox);
            this.Controls.Add(this.returnBookButton);
            this.Controls.Add(this.loanBookButton);
            this.Controls.Add(this.currentBorrowerValueLabel);
            this.Controls.Add(this.listBoxHistory);
            this.Controls.Add(this.labelHistoryOfBorrowers);
            this.Controls.Add(this.labelCurrentBorrower);
            this.Name = "BookSpecific";
            this.Text = "BookSpecific";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label labelCurrentBorrower;
        private System.Windows.Forms.Label labelHistoryOfBorrowers;
        private System.Windows.Forms.ListBox listBoxHistory;
        private System.Windows.Forms.Label currentBorrowerValueLabel;
        private System.Windows.Forms.Button loanBookButton;
        private System.Windows.Forms.Button returnBookButton;
        private System.Windows.Forms.ComboBox membersComboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker borrowDateSelect;
        private System.Windows.Forms.Label borrowDateSelectLabel;
    }
}