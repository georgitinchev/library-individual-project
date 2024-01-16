using System.ComponentModel;

namespace Library
{
    partial class AddNew
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
            this.components = new System.ComponentModel.Container();
            this.addBookGroupBox = new System.Windows.Forms.GroupBox();
            this.AddTitleTextBox = new System.Windows.Forms.TextBox();
            this.AddAuthorTextBox = new System.Windows.Forms.TextBox();
            this.AddISBNTextBox = new System.Windows.Forms.TextBox();
            this.AddDatePicker = new System.Windows.Forms.DateTimePicker();
            this.AddGenreComboBox = new System.Windows.Forms.ComboBox();
            this.AddPagesNumeric = new System.Windows.Forms.NumericUpDown();
            this.AddBookButton = new System.Windows.Forms.Button();
            this.AddBookSummaryText = new System.Windows.Forms.RichTextBox();
            this.newSummaryLabel = new System.Windows.Forms.Label();
            this.newPagesLabel = new System.Windows.Forms.Label();
            this.newGenreLabel = new System.Windows.Forms.Label();
            this.newReleaseDateLabel = new System.Windows.Forms.Label();
            this.newISBNlabel = new System.Windows.Forms.Label();
            this.newAuthorLabel = new System.Windows.Forms.Label();
            this.newTitleLabel = new System.Windows.Forms.Label();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.addBookGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AddPagesNumeric)).BeginInit();
            this.SuspendLayout();
            // 
            // addBookGroupBox
            // 
            this.addBookGroupBox.Controls.Add(this.AddTitleTextBox);
            this.addBookGroupBox.Controls.Add(this.AddAuthorTextBox);
            this.addBookGroupBox.Controls.Add(this.AddISBNTextBox);
            this.addBookGroupBox.Controls.Add(this.AddDatePicker);
            this.addBookGroupBox.Controls.Add(this.AddGenreComboBox);
            this.addBookGroupBox.Controls.Add(this.AddPagesNumeric);
            this.addBookGroupBox.Controls.Add(this.AddBookButton);
            this.addBookGroupBox.Controls.Add(this.AddBookSummaryText);
            this.addBookGroupBox.Controls.Add(this.newSummaryLabel);
            this.addBookGroupBox.Controls.Add(this.newPagesLabel);
            this.addBookGroupBox.Controls.Add(this.newGenreLabel);
            this.addBookGroupBox.Controls.Add(this.newReleaseDateLabel);
            this.addBookGroupBox.Controls.Add(this.newISBNlabel);
            this.addBookGroupBox.Controls.Add(this.newAuthorLabel);
            this.addBookGroupBox.Controls.Add(this.newTitleLabel);
            this.addBookGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.addBookGroupBox.Location = new System.Drawing.Point(12, 12);
            this.addBookGroupBox.Name = "addBookGroupBox";
            this.addBookGroupBox.Size = new System.Drawing.Size(776, 480);
            this.addBookGroupBox.TabIndex = 0;
            this.addBookGroupBox.TabStop = false;
            this.addBookGroupBox.Text = "New Book Tab:";
            // 
            // AddTitleTextBox
            // 
            this.AddTitleTextBox.Location = new System.Drawing.Point(143, 38);
            this.AddTitleTextBox.Name = "AddTitleTextBox";
            this.AddTitleTextBox.Size = new System.Drawing.Size(627, 26);
            this.AddTitleTextBox.TabIndex = 14;
            // 
            // AddAuthorTextBox
            // 
            this.AddAuthorTextBox.Location = new System.Drawing.Point(143, 76);
            this.AddAuthorTextBox.Name = "AddAuthorTextBox";
            this.AddAuthorTextBox.Size = new System.Drawing.Size(627, 26);
            this.AddAuthorTextBox.TabIndex = 13;
            // 
            // AddISBNTextBox
            // 
            this.AddISBNTextBox.Location = new System.Drawing.Point(143, 115);
            this.AddISBNTextBox.Name = "AddISBNTextBox";
            this.AddISBNTextBox.Size = new System.Drawing.Size(627, 26);
            this.AddISBNTextBox.TabIndex = 12;
            // 
            // AddDatePicker
            // 
            this.AddDatePicker.Location = new System.Drawing.Point(143, 155);
            this.AddDatePicker.Name = "AddDatePicker";
            this.AddDatePicker.Size = new System.Drawing.Size(627, 26);
            this.AddDatePicker.TabIndex = 11;
            // 
            // AddGenreComboBox
            // 
            this.AddGenreComboBox.FormattingEnabled = true;
            this.AddGenreComboBox.Location = new System.Drawing.Point(143, 192);
            this.AddGenreComboBox.Name = "AddGenreComboBox";
            this.AddGenreComboBox.Size = new System.Drawing.Size(627, 28);
            this.AddGenreComboBox.TabIndex = 10;
            // 
            // AddPagesNumeric
            // 
            this.AddPagesNumeric.Location = new System.Drawing.Point(143, 228);
            this.AddPagesNumeric.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.AddPagesNumeric.Name = "AddPagesNumeric";
            this.AddPagesNumeric.Size = new System.Drawing.Size(627, 26);
            this.AddPagesNumeric.TabIndex = 9;
            // 
            // AddBookButton
            // 
            this.AddBookButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.AddBookButton.Location = new System.Drawing.Point(143, 378);
            this.AddBookButton.Name = "AddBookButton";
            this.AddBookButton.Size = new System.Drawing.Size(627, 79);
            this.AddBookButton.TabIndex = 8;
            this.AddBookButton.Text = "Add Book 📗";
            this.AddBookButton.UseVisualStyleBackColor = true;
            this.AddBookButton.Click += new System.EventHandler(this.AddBookButton_Click);
            // 
            // AddBookSummaryText
            // 
            this.AddBookSummaryText.Location = new System.Drawing.Point(143, 262);
            this.AddBookSummaryText.Name = "AddBookSummaryText";
            this.AddBookSummaryText.Size = new System.Drawing.Size(627, 96);
            this.AddBookSummaryText.TabIndex = 7;
            this.AddBookSummaryText.Text = "";
            // 
            // newSummaryLabel
            // 
            this.newSummaryLabel.AutoSize = true;
            this.newSummaryLabel.Location = new System.Drawing.Point(40, 265);
            this.newSummaryLabel.Name = "newSummaryLabel";
            this.newSummaryLabel.Size = new System.Drawing.Size(85, 20);
            this.newSummaryLabel.TabIndex = 6;
            this.newSummaryLabel.Text = "Summary:";
            // 
            // newPagesLabel
            // 
            this.newPagesLabel.AutoSize = true;
            this.newPagesLabel.Location = new System.Drawing.Point(64, 231);
            this.newPagesLabel.Name = "newPagesLabel";
            this.newPagesLabel.Size = new System.Drawing.Size(61, 20);
            this.newPagesLabel.TabIndex = 5;
            this.newPagesLabel.Text = "Pages:";
            // 
            // newGenreLabel
            // 
            this.newGenreLabel.AutoSize = true;
            this.newGenreLabel.Location = new System.Drawing.Point(65, 192);
            this.newGenreLabel.Name = "newGenreLabel";
            this.newGenreLabel.Size = new System.Drawing.Size(60, 20);
            this.newGenreLabel.TabIndex = 4;
            this.newGenreLabel.Text = "Genre:";
            // 
            // newReleaseDateLabel
            // 
            this.newReleaseDateLabel.AutoSize = true;
            this.newReleaseDateLabel.Location = new System.Drawing.Point(9, 155);
            this.newReleaseDateLabel.Name = "newReleaseDateLabel";
            this.newReleaseDateLabel.Size = new System.Drawing.Size(116, 20);
            this.newReleaseDateLabel.TabIndex = 3;
            this.newReleaseDateLabel.Text = "Release Date:";
            // 
            // newISBNlabel
            // 
            this.newISBNlabel.AutoSize = true;
            this.newISBNlabel.Location = new System.Drawing.Point(8, 115);
            this.newISBNlabel.Name = "newISBNlabel";
            this.newISBNlabel.Size = new System.Drawing.Size(117, 20);
            this.newISBNlabel.TabIndex = 2;
            this.newISBNlabel.Text = "13 digit ISBN: ";
            // 
            // newAuthorLabel
            // 
            this.newAuthorLabel.AutoSize = true;
            this.newAuthorLabel.Location = new System.Drawing.Point(62, 76);
            this.newAuthorLabel.Name = "newAuthorLabel";
            this.newAuthorLabel.Size = new System.Drawing.Size(63, 20);
            this.newAuthorLabel.TabIndex = 1;
            this.newAuthorLabel.Text = "Author:";
            // 
            // newTitleLabel
            // 
            this.newTitleLabel.AutoSize = true;
            this.newTitleLabel.Location = new System.Drawing.Point(79, 41);
            this.newTitleLabel.Name = "newTitleLabel";
            this.newTitleLabel.Size = new System.Drawing.Size(46, 20);
            this.newTitleLabel.TabIndex = 0;
            this.newTitleLabel.Text = "Title:";
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            // 
            // AddNew
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 504);
            this.Controls.Add(this.addBookGroupBox);
            this.Name = "AddNew";
            this.addBookGroupBox.ResumeLayout(false);
            this.addBookGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AddPagesNumeric)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox addBookGroupBox;
        private System.Windows.Forms.Label newTitleLabel;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.Label newSummaryLabel;
        private System.Windows.Forms.Label newPagesLabel;
        private System.Windows.Forms.Label newGenreLabel;
        private System.Windows.Forms.Label newReleaseDateLabel;
        private System.Windows.Forms.Label newISBNlabel;
        private System.Windows.Forms.Label newAuthorLabel;
        private System.Windows.Forms.Button AddBookButton;
        private System.Windows.Forms.RichTextBox AddBookSummaryText;
        private System.Windows.Forms.DateTimePicker AddDatePicker;
        private System.Windows.Forms.ComboBox AddGenreComboBox;
        private System.Windows.Forms.NumericUpDown AddPagesNumeric;
        private System.Windows.Forms.TextBox AddISBNTextBox;
        private System.Windows.Forms.TextBox AddTitleTextBox;
        private System.Windows.Forms.TextBox AddAuthorTextBox;
    }
}