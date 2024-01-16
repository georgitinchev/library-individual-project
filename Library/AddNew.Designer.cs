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
            this.addBookGroupBox.BackColor = System.Drawing.Color.DarkGray;
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
            this.addBookGroupBox.Font = new System.Drawing.Font("Bauhaus 93", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addBookGroupBox.Location = new System.Drawing.Point(14, 15);
            this.addBookGroupBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.addBookGroupBox.Name = "addBookGroupBox";
            this.addBookGroupBox.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.addBookGroupBox.Size = new System.Drawing.Size(873, 600);
            this.addBookGroupBox.TabIndex = 0;
            this.addBookGroupBox.TabStop = false;
            this.addBookGroupBox.Text = "New Book Tab:";
            // 
            // AddTitleTextBox
            // 
            this.AddTitleTextBox.Location = new System.Drawing.Point(161, 48);
            this.AddTitleTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.AddTitleTextBox.Name = "AddTitleTextBox";
            this.AddTitleTextBox.Size = new System.Drawing.Size(705, 37);
            this.AddTitleTextBox.TabIndex = 14;
            // 
            // AddAuthorTextBox
            // 
            this.AddAuthorTextBox.Location = new System.Drawing.Point(161, 95);
            this.AddAuthorTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.AddAuthorTextBox.Name = "AddAuthorTextBox";
            this.AddAuthorTextBox.Size = new System.Drawing.Size(705, 37);
            this.AddAuthorTextBox.TabIndex = 13;
            // 
            // AddISBNTextBox
            // 
            this.AddISBNTextBox.Location = new System.Drawing.Point(161, 144);
            this.AddISBNTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.AddISBNTextBox.Name = "AddISBNTextBox";
            this.AddISBNTextBox.Size = new System.Drawing.Size(705, 37);
            this.AddISBNTextBox.TabIndex = 12;
            // 
            // AddDatePicker
            // 
            this.AddDatePicker.Location = new System.Drawing.Point(161, 194);
            this.AddDatePicker.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.AddDatePicker.Name = "AddDatePicker";
            this.AddDatePicker.Size = new System.Drawing.Size(705, 37);
            this.AddDatePicker.TabIndex = 11;
            // 
            // AddGenreComboBox
            // 
            this.AddGenreComboBox.FormattingEnabled = true;
            this.AddGenreComboBox.Location = new System.Drawing.Point(161, 240);
            this.AddGenreComboBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.AddGenreComboBox.Name = "AddGenreComboBox";
            this.AddGenreComboBox.Size = new System.Drawing.Size(705, 31);
            this.AddGenreComboBox.TabIndex = 10;
            // 
            // AddPagesNumeric
            // 
            this.AddPagesNumeric.Location = new System.Drawing.Point(161, 285);
            this.AddPagesNumeric.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.AddPagesNumeric.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.AddPagesNumeric.Name = "AddPagesNumeric";
            this.AddPagesNumeric.Size = new System.Drawing.Size(705, 37);
            this.AddPagesNumeric.TabIndex = 9;
            // 
            // AddBookButton
            // 
            this.AddBookButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.AddBookButton.Location = new System.Drawing.Point(161, 472);
            this.AddBookButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.AddBookButton.Name = "AddBookButton";
            this.AddBookButton.Size = new System.Drawing.Size(705, 99);
            this.AddBookButton.TabIndex = 8;
            this.AddBookButton.Text = "Add Book 📗";
            this.AddBookButton.UseVisualStyleBackColor = true;
            this.AddBookButton.Click += new System.EventHandler(this.AddBookButton_Click);
            // 
            // AddBookSummaryText
            // 
            this.AddBookSummaryText.Location = new System.Drawing.Point(161, 328);
            this.AddBookSummaryText.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.AddBookSummaryText.Name = "AddBookSummaryText";
            this.AddBookSummaryText.Size = new System.Drawing.Size(705, 119);
            this.AddBookSummaryText.TabIndex = 7;
            this.AddBookSummaryText.Text = "";
            // 
            // newSummaryLabel
            // 
            this.newSummaryLabel.AutoSize = true;
            this.newSummaryLabel.Location = new System.Drawing.Point(45, 331);
            this.newSummaryLabel.Name = "newSummaryLabel";
            this.newSummaryLabel.Size = new System.Drawing.Size(96, 23);
            this.newSummaryLabel.TabIndex = 6;
            this.newSummaryLabel.Text = "Summary:";
            // 
            // newPagesLabel
            // 
            this.newPagesLabel.AutoSize = true;
            this.newPagesLabel.Location = new System.Drawing.Point(72, 289);
            this.newPagesLabel.Name = "newPagesLabel";
            this.newPagesLabel.Size = new System.Drawing.Size(71, 23);
            this.newPagesLabel.TabIndex = 5;
            this.newPagesLabel.Text = "Pages:";
            // 
            // newGenreLabel
            // 
            this.newGenreLabel.AutoSize = true;
            this.newGenreLabel.Location = new System.Drawing.Point(73, 240);
            this.newGenreLabel.Name = "newGenreLabel";
            this.newGenreLabel.Size = new System.Drawing.Size(69, 23);
            this.newGenreLabel.TabIndex = 4;
            this.newGenreLabel.Text = "Genre:";
            // 
            // newReleaseDateLabel
            // 
            this.newReleaseDateLabel.AutoSize = true;
            this.newReleaseDateLabel.Location = new System.Drawing.Point(10, 194);
            this.newReleaseDateLabel.Name = "newReleaseDateLabel";
            this.newReleaseDateLabel.Size = new System.Drawing.Size(138, 23);
            this.newReleaseDateLabel.TabIndex = 3;
            this.newReleaseDateLabel.Text = "Release Date:";
            // 
            // newISBNlabel
            // 
            this.newISBNlabel.AutoSize = true;
            this.newISBNlabel.Location = new System.Drawing.Point(9, 144);
            this.newISBNlabel.Name = "newISBNlabel";
            this.newISBNlabel.Size = new System.Drawing.Size(136, 23);
            this.newISBNlabel.TabIndex = 2;
            this.newISBNlabel.Text = "13 digit ISBN: ";
            // 
            // newAuthorLabel
            // 
            this.newAuthorLabel.AutoSize = true;
            this.newAuthorLabel.Location = new System.Drawing.Point(70, 95);
            this.newAuthorLabel.Name = "newAuthorLabel";
            this.newAuthorLabel.Size = new System.Drawing.Size(76, 23);
            this.newAuthorLabel.TabIndex = 1;
            this.newAuthorLabel.Text = "Author:";
            // 
            // newTitleLabel
            // 
            this.newTitleLabel.AutoSize = true;
            this.newTitleLabel.Location = new System.Drawing.Point(89, 51);
            this.newTitleLabel.Name = "newTitleLabel";
            this.newTitleLabel.Size = new System.Drawing.Size(58, 23);
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
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(900, 630);
            this.Controls.Add(this.addBookGroupBox);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
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