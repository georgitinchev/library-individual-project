using System;
using System.Windows.Forms;
using System.IO;
using System.Text.Json;

namespace Library
{
    public partial class LibForm : Form
    {
        internal Library CurrentLibrary = new Library("Eindhoven Books");
        private int _currentBookIndex = 0;
        public LibForm()
        {
            InitializeComponent();
            InitializeUi();
        }
        private void InitializeUi()
        {
            libraryHeaderTitle.Text = $"Welcome to Library {CurrentLibrary.Name} 📖";
            if(CurrentLibrary.BookCatalogue.Count != 0)
            {
            PopulateBookInfo(SelectCurrentBook());
            }
            PopulateComboBox();
        }
        public Book SelectCurrentBook()
        {
            return _currentBookIndex >= 0 && _currentBookIndex < CurrentLibrary.BookCatalogue.Count
                ? CurrentLibrary.BookCatalogue[_currentBookIndex]
                : null;
        }
        public void UpdateCurrentIndex(int index)
        {
            _currentBookIndex = (index >= 0 && index < CurrentLibrary.BookCatalogue.Count) ? index : _currentBookIndex;
        }
        private void MoveToPreviousBook()
        {
            CheckIfLibraryNull();
            if (_currentBookIndex > 0)
            {
                UpdateCurrentIndex(_currentBookIndex - 1);
                PopulateBookInfo(SelectCurrentBook());
            }
        }
        private void MoveToNextBook()
        {
            CheckIfLibraryNull();
            if (_currentBookIndex < CurrentLibrary.BookCatalogue.Count - 1)
            {
                UpdateCurrentIndex(_currentBookIndex + 1);
                PopulateBookInfo(SelectCurrentBook());
            }
        }
        private void previousBookBtn_Click_1(object sender, EventArgs e)
        {
            MoveToPreviousBook();
        }
        private void nextBookBtn_Click_1(object sender, EventArgs e)
        {
            MoveToNextBook();
        }
        private void staffPanelBtn_Click(object sender, EventArgs e)
        {
            staffPanel.Visible = !staffPanel.Visible;
            staffPanelBtn.Text = staffPanel.Visible ? "Hide staff panel 🔒" : "Show staff panel 🔓";
        }
        private void searchBtn_Click(object sender, EventArgs e)
        {
            try
            {
                string author = searchAuthorTextBox.Text;
                string title = searchTitleTextBox.Text;
                BookGenres? genre = searchGenreComboBox.SelectedItem as BookGenres?;
                Book book = CurrentLibrary.SearchBook(title, author, genre);
                int index = CurrentLibrary.BookCatalogue.IndexOf(book);
                UpdateCurrentIndex(index);
                PopulateBookInfo(book);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Search Result", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void removeCurrentBookBtn_Click(object sender, EventArgs e)
        {
            Book currentBook = SelectCurrentBook();
            if (currentBook != null)
            {
                CurrentLibrary.BookCatalogue.Remove(currentBook);
                MessageBox.Show("Book removed successfully.", "Remove Book", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (CurrentLibrary.BookCatalogue.Count > 0)
                {
                    // populate with last book if there are elemnets left in book catalogue
                    if (_currentBookIndex >= CurrentLibrary.BookCatalogue.Count)
                    {
                        UpdateCurrentIndex(CurrentLibrary.BookCatalogue.Count - 1);
                    }
                    PopulateBookInfo(SelectCurrentBook());
                }
                else
                {
                    ClearBookInfo();
                }
            }
            else
            {
                MessageBox.Show("No more books to remove.", "Remove Book", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void ClearBookInfo()
        {
            bookTitleLabel.Text = "";
            bookAuthorLabel.Text = "";
            bookGenreLabel.Text = "";
            ISBNlabel.Text = "";
            publicationDateLabel.Text = "";
            pagesLabel.Text = "";
            bookDescriptionLabel.Text = "";
        }

        private void CheckIfLibraryNull()
        {
            if(CurrentLibrary == null)
            {
                MessageBox.Show("No library loaded.", "Library Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }
        private void PopulateComboBox()
        {
            searchGenreComboBox.Items.Clear();
            foreach (BookGenres genre in Enum.GetValues(typeof(BookGenres)))
            {
                searchGenreComboBox.Items.Add(genre);
            }
        }
        public void PopulateBookInfo(Book book)
        {
            bookTitleLabel.Text = $"Title: {book.Title}";
            bookAuthorLabel.Text = $"Author: {book.Author}";
            bookGenreLabel.Text = $"Genre: {book.Genre.ToString()}";
            ISBNlabel.Text = $"ISBN: {book.Isbn13.ToString()}";
            publicationDateLabel.Text = $"Release date: {book.ReleaseDate.ToString("dd/MM/yyyy")}";
            pagesLabel.Text = $"Pages: {book.PageNum.ToString()}";
            bookDescriptionLabel.Text = $"Summary description:\n{book.Description}";
        }
        private void buttonShowLoanDetails_Click(object sender, EventArgs e)
        {
            if(SelectCurrentBook() == null)
            {
                MessageBox.Show("No book selected");
                return;
            }
            BookSpecific bookSpecific = new BookSpecific(this);
            bookSpecific.Show();
        }
        private void buttonAddNew_Click(object sender, EventArgs e)
        {
            CheckIfLibraryNull();
            AddNew addNew = new AddNew(this);
            addNew.Show();
        }
        private void buttonManageMembers_Click(object sender, EventArgs e)
        {
            CheckIfLibraryNull();
            ManageMembers manageMembers = new ManageMembers(this);
            manageMembers.Show();
        }
        private void labelSave_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "JSON files (*.json)|*.json";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    string json = JsonSerializer.Serialize(CurrentLibrary);
                    using (FileStream fs = new FileStream(saveFileDialog.FileName, FileMode.Create))
                    {
                        using (StreamWriter writer = new StreamWriter(fs))
                        {
                            writer.Write(json);
                        }
                    }
                    MessageBox.Show("Library saved successfully.");
                    UpdateCurrentIndex(0);
                    CurrentLibrary = null;
                    ClearBookInfo();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
        private void labelLoad_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "JSON files (*.json)|*.json";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    string json = string.Empty;
                    using (FileStream fs = new FileStream(openFileDialog.FileName, FileMode.Open))
                    {
                        using (StreamReader reader = new StreamReader(fs))
                        {
                            json = reader.ReadToEnd();
                        }
                    }
                    CurrentLibrary = JsonSerializer.Deserialize<Library>(json);
                    MessageBox.Show("Library loaded successfully.");
                    InitializeUi();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
    }
}
