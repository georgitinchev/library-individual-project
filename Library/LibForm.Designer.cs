namespace Library
{
  partial class LibForm
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
      this.components = new System.ComponentModel.Container();
      this.tabPage2 = new System.Windows.Forms.TabPage();
      this.tabPage1 = new System.Windows.Forms.TabPage();
      this.libraryHeaderTitle = new System.Windows.Forms.Label();
      this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
      this.booksTab = new System.Windows.Forms.TabPage();
      this.labelLoad = new System.Windows.Forms.Label();
      this.labelSave = new System.Windows.Forms.Label();
      this.groupBox2 = new System.Windows.Forms.GroupBox();
      this.label4 = new System.Windows.Forms.Label();
      this.searchGenreComboBox = new System.Windows.Forms.ComboBox();
      this.label3 = new System.Windows.Forms.Label();
      this.label2 = new System.Windows.Forms.Label();
      this.searchTitleTextBox = new System.Windows.Forms.TextBox();
      this.searchAuthorTextBox = new System.Windows.Forms.TextBox();
      this.label1 = new System.Windows.Forms.Label();
      this.staffPanelBtn = new System.Windows.Forms.Button();
      this.staffPanel = new System.Windows.Forms.GroupBox();
      this.buttonShowLoanDetails = new System.Windows.Forms.Button();
      this.removeCurrentBookBtn = new System.Windows.Forms.Button();
      this.buttonAddNew = new System.Windows.Forms.Button();
      this.buttonManageMembers = new System.Windows.Forms.Button();
      this.nextBookBtn = new System.Windows.Forms.Button();
      this.previousBookBtn = new System.Windows.Forms.Button();
      this.bookOverviewDtls = new System.Windows.Forms.GroupBox();
      this.bookDescriptionLabel = new System.Windows.Forms.Label();
      this.bookAuthorLabel = new System.Windows.Forms.Label();
      this.bookTitleLabel = new System.Windows.Forms.Label();
      this.ISBNlabel = new System.Windows.Forms.Label();
      this.pagesLabel = new System.Windows.Forms.Label();
      this.publicationDateLabel = new System.Windows.Forms.Label();
      this.bookGenreLabel = new System.Windows.Forms.Label();
      this.searchBtn = new System.Windows.Forms.Button();
      this.libraryTabControl = new System.Windows.Forms.TabControl();
      this.booksTab.SuspendLayout();
      this.groupBox2.SuspendLayout();
      this.staffPanel.SuspendLayout();
      this.bookOverviewDtls.SuspendLayout();
      this.libraryTabControl.SuspendLayout();
      this.SuspendLayout();
      // 
      // tabPage2
      // 
      this.tabPage2.Location = new System.Drawing.Point(4, 25);
      this.tabPage2.Name = "tabPage2";
      this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
      this.tabPage2.Size = new System.Drawing.Size(0, 0);
      this.tabPage2.TabIndex = 1;
      this.tabPage2.Text = "tabPage2";
      this.tabPage2.UseVisualStyleBackColor = true;
      // 
      // tabPage1
      // 
      this.tabPage1.Location = new System.Drawing.Point(4, 25);
      this.tabPage1.Name = "tabPage1";
      this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
      this.tabPage1.Size = new System.Drawing.Size(375, 502);
      this.tabPage1.TabIndex = 0;
      this.tabPage1.Text = "tabPage1";
      this.tabPage1.UseVisualStyleBackColor = true;
      // 
      // libraryHeaderTitle
      // 
      this.libraryHeaderTitle.BackColor = System.Drawing.SystemColors.InactiveCaption;
      this.libraryHeaderTitle.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
      this.libraryHeaderTitle.Font = new System.Drawing.Font("Bauhaus 93", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.libraryHeaderTitle.Location = new System.Drawing.Point(18, 11);
      this.libraryHeaderTitle.Name = "libraryHeaderTitle";
      this.libraryHeaderTitle.Size = new System.Drawing.Size(920, 55);
      this.libraryHeaderTitle.TabIndex = 5;
      this.libraryHeaderTitle.Text = "Welcome to the Library! 📖";
      this.libraryHeaderTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      // 
      // contextMenuStrip1
      // 
      this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
      this.contextMenuStrip1.Name = "contextMenuStrip1";
      this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
      // 
      // booksTab
      // 
      this.booksTab.BackColor = System.Drawing.SystemColors.ButtonShadow;
      this.booksTab.Controls.Add(this.labelLoad);
      this.booksTab.Controls.Add(this.labelSave);
      this.booksTab.Controls.Add(this.groupBox2);
      this.booksTab.Controls.Add(this.label1);
      this.booksTab.Controls.Add(this.staffPanelBtn);
      this.booksTab.Controls.Add(this.staffPanel);
      this.booksTab.Controls.Add(this.nextBookBtn);
      this.booksTab.Controls.Add(this.previousBookBtn);
      this.booksTab.Controls.Add(this.bookOverviewDtls);
      this.booksTab.Controls.Add(this.searchBtn);
      this.booksTab.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
      this.booksTab.Location = new System.Drawing.Point(4, 37);
      this.booksTab.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
      this.booksTab.Name = "booksTab";
      this.booksTab.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
      this.booksTab.Size = new System.Drawing.Size(924, 957);
      this.booksTab.TabIndex = 0;
      this.booksTab.Text = "Books 📕";
      // 
      // labelLoad
      // 
      this.labelLoad.AutoSize = true;
      this.labelLoad.BackColor = System.Drawing.Color.LightGray;
      this.labelLoad.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
      this.labelLoad.Location = new System.Drawing.Point(790, 792);
      this.labelLoad.Name = "labelLoad";
      this.labelLoad.Size = new System.Drawing.Size(54, 37);
      this.labelLoad.TabIndex = 14;
      this.labelLoad.Text = "🔄";
      this.labelLoad.Click += new System.EventHandler(this.labelLoad_Click);
      // 
      // labelSave
      // 
      this.labelSave.AutoSize = true;
      this.labelSave.BackColor = System.Drawing.Color.LightGray;
      this.labelSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
      this.labelSave.Location = new System.Drawing.Point(732, 792);
      this.labelSave.Name = "labelSave";
      this.labelSave.Size = new System.Drawing.Size(54, 37);
      this.labelSave.TabIndex = 13;
      this.labelSave.Text = "💾";
      this.labelSave.Click += new System.EventHandler(this.labelSave_Click);
      // 
      // groupBox2
      // 
      this.groupBox2.Controls.Add(this.label4);
      this.groupBox2.Controls.Add(this.searchGenreComboBox);
      this.groupBox2.Controls.Add(this.label3);
      this.groupBox2.Controls.Add(this.label2);
      this.groupBox2.Controls.Add(this.searchTitleTextBox);
      this.groupBox2.Controls.Add(this.searchAuthorTextBox);
      this.groupBox2.Font = new System.Drawing.Font("Bauhaus 93", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.groupBox2.Location = new System.Drawing.Point(18, 8);
      this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
      this.groupBox2.Name = "groupBox2";
      this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
      this.groupBox2.Size = new System.Drawing.Size(650, 254);
      this.groupBox2.TabIndex = 12;
      this.groupBox2.TabStop = false;
      this.groupBox2.Text = "Search Inputs:";
      // 
      // label4
      // 
      this.label4.AutoSize = true;
      this.label4.Font = new System.Drawing.Font("Bauhaus 93", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label4.Location = new System.Drawing.Point(9, 178);
      this.label4.Name = "label4";
      this.label4.Size = new System.Drawing.Size(63, 20);
      this.label4.TabIndex = 6;
      this.label4.Text = "Genre:";
      // 
      // searchGenreComboBox
      // 
      this.searchGenreComboBox.FormattingEnabled = true;
      this.searchGenreComboBox.Location = new System.Drawing.Point(12, 205);
      this.searchGenreComboBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
      this.searchGenreComboBox.Name = "searchGenreComboBox";
      this.searchGenreComboBox.Size = new System.Drawing.Size(626, 36);
      this.searchGenreComboBox.TabIndex = 5;
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Font = new System.Drawing.Font("Bauhaus 93", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label3.Location = new System.Drawing.Point(9, 109);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(44, 20);
      this.label3.TabIndex = 4;
      this.label3.Text = "Title";
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Font = new System.Drawing.Font("Bauhaus 93", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label2.Location = new System.Drawing.Point(9, 38);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(62, 20);
      this.label2.TabIndex = 3;
      this.label2.Text = "Author";
      // 
      // searchTitleTextBox
      // 
      this.searchTitleTextBox.Location = new System.Drawing.Point(12, 135);
      this.searchTitleTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
      this.searchTitleTextBox.Name = "searchTitleTextBox";
      this.searchTitleTextBox.Size = new System.Drawing.Size(626, 43);
      this.searchTitleTextBox.TabIndex = 1;
      // 
      // searchAuthorTextBox
      // 
      this.searchAuthorTextBox.Location = new System.Drawing.Point(12, 62);
      this.searchAuthorTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
      this.searchAuthorTextBox.Name = "searchAuthorTextBox";
      this.searchAuthorTextBox.Size = new System.Drawing.Size(626, 43);
      this.searchAuthorTextBox.TabIndex = 0;
      // 
      // label1
      // 
      this.label1.Font = new System.Drawing.Font("Bauhaus 93", 12F);
      this.label1.Location = new System.Drawing.Point(674, 842);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(246, 32);
      this.label1.TabIndex = 11;
      this.label1.Text = "Navigation:";
      this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      // 
      // staffPanelBtn
      // 
      this.staffPanelBtn.Font = new System.Drawing.Font("Bauhaus 93", 12F);
      this.staffPanelBtn.Location = new System.Drawing.Point(681, 157);
      this.staffPanelBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
      this.staffPanelBtn.Name = "staffPanelBtn";
      this.staffPanelBtn.Size = new System.Drawing.Size(222, 105);
      this.staffPanelBtn.TabIndex = 10;
      this.staffPanelBtn.Text = "Show staff panel 🔓";
      this.staffPanelBtn.UseVisualStyleBackColor = true;
      this.staffPanelBtn.Click += new System.EventHandler(this.staffPanelBtn_Click);
      // 
      // staffPanel
      // 
      this.staffPanel.Controls.Add(this.buttonShowLoanDetails);
      this.staffPanel.Controls.Add(this.removeCurrentBookBtn);
      this.staffPanel.Controls.Add(this.buttonAddNew);
      this.staffPanel.Controls.Add(this.buttonManageMembers);
      this.staffPanel.Location = new System.Drawing.Point(680, 302);
      this.staffPanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
      this.staffPanel.Name = "staffPanel";
      this.staffPanel.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
      this.staffPanel.Size = new System.Drawing.Size(222, 478);
      this.staffPanel.TabIndex = 9;
      this.staffPanel.TabStop = false;
      this.staffPanel.Text = "Staff Panel 📖";
      this.staffPanel.Visible = false;
      // 
      // buttonShowLoanDetails
      // 
      this.buttonShowLoanDetails.Font = new System.Drawing.Font("Bauhaus 93", 12F);
      this.buttonShowLoanDetails.Location = new System.Drawing.Point(6, 154);
      this.buttonShowLoanDetails.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
      this.buttonShowLoanDetails.Name = "buttonShowLoanDetails";
      this.buttonShowLoanDetails.Size = new System.Drawing.Size(210, 102);
      this.buttonShowLoanDetails.TabIndex = 10;
      this.buttonShowLoanDetails.Text = "Show Book\'s Loan Details";
      this.buttonShowLoanDetails.UseVisualStyleBackColor = true;
      this.buttonShowLoanDetails.Click += new System.EventHandler(this.buttonShowLoanDetails_Click);
      // 
      // removeCurrentBookBtn
      // 
      this.removeCurrentBookBtn.Font = new System.Drawing.Font("Bauhaus 93", 12F);
      this.removeCurrentBookBtn.Location = new System.Drawing.Point(6, 371);
      this.removeCurrentBookBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
      this.removeCurrentBookBtn.Name = "removeCurrentBookBtn";
      this.removeCurrentBookBtn.Size = new System.Drawing.Size(210, 102);
      this.removeCurrentBookBtn.TabIndex = 9;
      this.removeCurrentBookBtn.Text = "Remove Current Book";
      this.removeCurrentBookBtn.UseVisualStyleBackColor = true;
      this.removeCurrentBookBtn.Click += new System.EventHandler(this.removeCurrentBookBtn_Click);
      // 
      // buttonAddNew
      // 
      this.buttonAddNew.Font = new System.Drawing.Font("Bauhaus 93", 12F);
      this.buttonAddNew.Location = new System.Drawing.Point(6, 262);
      this.buttonAddNew.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
      this.buttonAddNew.Name = "buttonAddNew";
      this.buttonAddNew.Size = new System.Drawing.Size(210, 102);
      this.buttonAddNew.TabIndex = 8;
      this.buttonAddNew.Text = "Add New Book";
      this.buttonAddNew.UseVisualStyleBackColor = true;
      this.buttonAddNew.Click += new System.EventHandler(this.buttonAddNew_Click);
      // 
      // buttonManageMembers
      // 
      this.buttonManageMembers.Font = new System.Drawing.Font("Bauhaus 93", 12F);
      this.buttonManageMembers.Location = new System.Drawing.Point(6, 45);
      this.buttonManageMembers.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
      this.buttonManageMembers.Name = "buttonManageMembers";
      this.buttonManageMembers.Size = new System.Drawing.Size(210, 102);
      this.buttonManageMembers.TabIndex = 4;
      this.buttonManageMembers.Text = "Manage Book Club Members";
      this.buttonManageMembers.UseVisualStyleBackColor = true;
      this.buttonManageMembers.Click += new System.EventHandler(this.buttonManageMembers_Click);
      // 
      // nextBookBtn
      // 
      this.nextBookBtn.Font = new System.Drawing.Font("Bauhaus 93", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.nextBookBtn.Location = new System.Drawing.Point(798, 880);
      this.nextBookBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
      this.nextBookBtn.Name = "nextBookBtn";
      this.nextBookBtn.Size = new System.Drawing.Size(122, 60);
      this.nextBookBtn.TabIndex = 7;
      this.nextBookBtn.Text = "=>";
      this.nextBookBtn.UseVisualStyleBackColor = true;
      this.nextBookBtn.Click += new System.EventHandler(this.nextBookBtn_Click_1);
      // 
      // previousBookBtn
      // 
      this.previousBookBtn.Font = new System.Drawing.Font("Bauhaus 93", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.previousBookBtn.Location = new System.Drawing.Point(674, 880);
      this.previousBookBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
      this.previousBookBtn.Name = "previousBookBtn";
      this.previousBookBtn.Size = new System.Drawing.Size(118, 60);
      this.previousBookBtn.TabIndex = 6;
      this.previousBookBtn.Text = "<=";
      this.previousBookBtn.UseVisualStyleBackColor = true;
      this.previousBookBtn.Click += new System.EventHandler(this.previousBookBtn_Click_1);
      // 
      // bookOverviewDtls
      // 
      this.bookOverviewDtls.Controls.Add(this.bookDescriptionLabel);
      this.bookOverviewDtls.Controls.Add(this.bookAuthorLabel);
      this.bookOverviewDtls.Controls.Add(this.bookTitleLabel);
      this.bookOverviewDtls.Controls.Add(this.ISBNlabel);
      this.bookOverviewDtls.Controls.Add(this.pagesLabel);
      this.bookOverviewDtls.Controls.Add(this.publicationDateLabel);
      this.bookOverviewDtls.Controls.Add(this.bookGenreLabel);
      this.bookOverviewDtls.Font = new System.Drawing.Font("Bauhaus 93", 12F);
      this.bookOverviewDtls.Location = new System.Drawing.Point(18, 269);
      this.bookOverviewDtls.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
      this.bookOverviewDtls.Name = "bookOverviewDtls";
      this.bookOverviewDtls.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
      this.bookOverviewDtls.Size = new System.Drawing.Size(650, 706);
      this.bookOverviewDtls.TabIndex = 5;
      this.bookOverviewDtls.TabStop = false;
      this.bookOverviewDtls.Text = "📗 Overview:";
      // 
      // bookDescriptionLabel
      // 
      this.bookDescriptionLabel.BackColor = System.Drawing.Color.Gainsboro;
      this.bookDescriptionLabel.Location = new System.Drawing.Point(6, 469);
      this.bookDescriptionLabel.Name = "bookDescriptionLabel";
      this.bookDescriptionLabel.Size = new System.Drawing.Size(633, 185);
      this.bookDescriptionLabel.TabIndex = 6;
      this.bookDescriptionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
      // 
      // bookAuthorLabel
      // 
      this.bookAuthorLabel.BackColor = System.Drawing.Color.Gainsboro;
      this.bookAuthorLabel.Location = new System.Drawing.Point(6, 102);
      this.bookAuthorLabel.Name = "bookAuthorLabel";
      this.bookAuthorLabel.Size = new System.Drawing.Size(633, 49);
      this.bookAuthorLabel.TabIndex = 1;
      this.bookAuthorLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
      // 
      // bookTitleLabel
      // 
      this.bookTitleLabel.BackColor = System.Drawing.Color.Gainsboro;
      this.bookTitleLabel.Location = new System.Drawing.Point(6, 32);
      this.bookTitleLabel.Name = "bookTitleLabel";
      this.bookTitleLabel.Size = new System.Drawing.Size(633, 55);
      this.bookTitleLabel.TabIndex = 0;
      this.bookTitleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
      // 
      // ISBNlabel
      // 
      this.ISBNlabel.BackColor = System.Drawing.Color.Gainsboro;
      this.ISBNlabel.Location = new System.Drawing.Point(6, 162);
      this.ISBNlabel.Name = "ISBNlabel";
      this.ISBNlabel.Size = new System.Drawing.Size(633, 62);
      this.ISBNlabel.TabIndex = 5;
      this.ISBNlabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
      // 
      // pagesLabel
      // 
      this.pagesLabel.BackColor = System.Drawing.Color.Gainsboro;
      this.pagesLabel.Location = new System.Drawing.Point(6, 394);
      this.pagesLabel.Name = "pagesLabel";
      this.pagesLabel.Size = new System.Drawing.Size(633, 62);
      this.pagesLabel.TabIndex = 4;
      this.pagesLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
      // 
      // publicationDateLabel
      // 
      this.publicationDateLabel.BackColor = System.Drawing.Color.Gainsboro;
      this.publicationDateLabel.Location = new System.Drawing.Point(6, 238);
      this.publicationDateLabel.Name = "publicationDateLabel";
      this.publicationDateLabel.Size = new System.Drawing.Size(633, 62);
      this.publicationDateLabel.TabIndex = 3;
      this.publicationDateLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
      // 
      // bookGenreLabel
      // 
      this.bookGenreLabel.BackColor = System.Drawing.Color.Gainsboro;
      this.bookGenreLabel.Location = new System.Drawing.Point(6, 315);
      this.bookGenreLabel.Name = "bookGenreLabel";
      this.bookGenreLabel.Size = new System.Drawing.Size(633, 62);
      this.bookGenreLabel.TabIndex = 2;
      this.bookGenreLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
      // 
      // searchBtn
      // 
      this.searchBtn.Font = new System.Drawing.Font("Bauhaus 93", 12F);
      this.searchBtn.Location = new System.Drawing.Point(681, 26);
      this.searchBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
      this.searchBtn.Name = "searchBtn";
      this.searchBtn.Size = new System.Drawing.Size(222, 82);
      this.searchBtn.TabIndex = 2;
      this.searchBtn.Text = "Search 🔍";
      this.searchBtn.UseVisualStyleBackColor = true;
      this.searchBtn.Click += new System.EventHandler(this.searchBtn_Click);
      // 
      // libraryTabControl
      // 
      this.libraryTabControl.Controls.Add(this.booksTab);
      this.libraryTabControl.Font = new System.Drawing.Font("Bauhaus 93", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.libraryTabControl.Location = new System.Drawing.Point(14, 89);
      this.libraryTabControl.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
      this.libraryTabControl.Name = "libraryTabControl";
      this.libraryTabControl.SelectedIndex = 0;
      this.libraryTabControl.Size = new System.Drawing.Size(932, 998);
      this.libraryTabControl.TabIndex = 6;
      // 
      // LibForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.BackColor = System.Drawing.SystemColors.MenuHighlight;
      this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
      this.ClientSize = new System.Drawing.Size(954, 1105);
      this.Controls.Add(this.libraryTabControl);
      this.Controls.Add(this.libraryHeaderTitle);
      this.Location = new System.Drawing.Point(15, 15);
      this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
      this.Name = "LibForm";
      this.Text = "Library Application";
      this.booksTab.ResumeLayout(false);
      this.booksTab.PerformLayout();
      this.groupBox2.ResumeLayout(false);
      this.groupBox2.PerformLayout();
      this.staffPanel.ResumeLayout(false);
      this.bookOverviewDtls.ResumeLayout(false);
      this.libraryTabControl.ResumeLayout(false);
      this.ResumeLayout(false);
    }

    private System.Windows.Forms.Label libraryHeaderTitle;

    private System.Windows.Forms.TabPage tabPage2;
    private System.Windows.Forms.TabPage tabPage1;

        #endregion
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TabPage booksTab;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox searchGenreComboBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox searchTitleTextBox;
        private System.Windows.Forms.TextBox searchAuthorTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button staffPanelBtn;
        private System.Windows.Forms.GroupBox staffPanel;
        private System.Windows.Forms.Button removeCurrentBookBtn;
        private System.Windows.Forms.Button buttonAddNew;
        private System.Windows.Forms.Button buttonManageMembers;
        private System.Windows.Forms.Button nextBookBtn;
        private System.Windows.Forms.Button previousBookBtn;
        private System.Windows.Forms.GroupBox bookOverviewDtls;
        private System.Windows.Forms.Label bookDescriptionLabel;
        private System.Windows.Forms.Label bookAuthorLabel;
        private System.Windows.Forms.Label bookTitleLabel;
        private System.Windows.Forms.Label ISBNlabel;
        private System.Windows.Forms.Label pagesLabel;
        private System.Windows.Forms.Label publicationDateLabel;
        private System.Windows.Forms.Label bookGenreLabel;
        private System.Windows.Forms.Button searchBtn;
        private System.Windows.Forms.TabControl libraryTabControl;
        private System.Windows.Forms.Button buttonShowLoanDetails;
        private System.Windows.Forms.Label labelLoad;
        private System.Windows.Forms.Label labelSave;
    }
}

