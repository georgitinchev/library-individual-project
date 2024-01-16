using System;
using System.Text;
using System.Windows.Forms;

namespace Library
{
    public partial class AddNew : Form
    {
        // passing libform instance here to update indexes and also call searchbook
        private LibForm _libForm;
        public AddNew(LibForm libForm)
        {
            InitializeComponent();
            _libForm = libForm;
            foreach (BookGenres genre in Enum.GetValues(typeof(BookGenres)))
            {
                AddGenreComboBox.Items.Add(genre);
            }
        }
        private void AddBookButton_Click(object sender, EventArgs e)
        {
            if (ValidateEmptyInput())
            {
                // if book is non-existant it will drop into catch and create the new book
                try
                {
                    _libForm.CurrentLibrary.SearchBook(AddTitleTextBox.Text, AddAuthorTextBox.Text);
                    MessageBox.Show("Book already exists in the library. Please enter a unique title and author combination.");
                }
                catch
                {
                    Book book = new Book(AddTitleTextBox.Text, AddAuthorTextBox.Text, AddBookSummaryText.Text, long.Parse(AddISBNTextBox.Text), int.Parse(AddPagesNumeric.Text), DateTime.Parse(AddDatePicker.Text), (BookGenres)AddGenreComboBox.SelectedItem);
                    _libForm.CurrentLibrary.BookCatalogue.Add(book);
                    _libForm.UpdateCurrentIndex(_libForm.CurrentLibrary.BookCatalogue.Count - 1);
                    _libForm.PopulateBookInfo(_libForm.SelectCurrentBook());
                    MessageBox.Show("Book added successfully!");
                    this.Close();
                }
            }
        }
        // all validation methods below
        private bool ValidateEmptyInput()
        {
            StringBuilder errorMessage = new StringBuilder();
            if (string.IsNullOrWhiteSpace(AddTitleTextBox.Text) || !IsText(AddTitleTextBox.Text))
            {
                errorMessage.AppendLine("Please enter a valid title for the book.");
            }
            if (string.IsNullOrWhiteSpace(AddAuthorTextBox.Text) || !IsText(AddAuthorTextBox.Text))
            {
                errorMessage.AppendLine("Please enter a valid author for the book.");
            }
            if (string.IsNullOrWhiteSpace(AddISBNTextBox.Text) || !IsIsbn(AddISBNTextBox.Text))
            {
                errorMessage.AppendLine("Please enter a valid ISBN for the book.");
            }
            if (!DateTime.TryParse(AddDatePicker.Text, out DateTime date) || date > DateTime.Now)
            {
                errorMessage.AppendLine("Please enter a valid date that is not later than today.");
            }
            if (AddGenreComboBox.SelectedItem == null)
            {
                errorMessage.AppendLine("Please select a genre for the book.");
            }
            if (!int.TryParse(AddPagesNumeric.Text, out int page))
            {
                errorMessage.AppendLine("Please enter a valid number of pages.");
            }
            if (string.IsNullOrWhiteSpace(AddBookSummaryText.Text) || !IsValidSummary(AddBookSummaryText.Text))
            {
                errorMessage.AppendLine("Please enter a valid summary for the book.");
            }
            if (errorMessage.Length > 0)
            {
                MessageBox.Show(errorMessage.ToString());
                return false;
            }
            return true;
        }
        private bool IsText(string input)
        {
            foreach (char c in input)
            {
                if (!char.IsLetter(c) && !char.IsWhiteSpace(c))
                {
                    return false;
                }
            }
            return true;
        }
        private bool IsValidSummary(string input)
        {
            return !string.IsNullOrWhiteSpace(input) && input.Length <= 290;
        }
        private bool IsIsbn(string input)
        {
            return input.Length == 13 && long.TryParse(input, out _);
        }
    }
}
