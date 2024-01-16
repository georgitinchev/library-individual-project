using System;
using System.Windows.Forms;

namespace Library
{
    public partial class BookSpecific : Form
    {
        private LibForm _libForm;
        private Book _currentBook;
        public BookSpecific(LibForm libForm)
        {
            InitializeComponent();
            _libForm = libForm;
            _currentBook = _libForm.SelectCurrentBook();
            InitializeUI();
        }
        private void InitializeUI()
        {
            InitializeMembers();
            InitializeHistory();
            if (_currentBook.CurrentLoan != null)
            {
                currentBorrowerValueLabel.Text = _currentBook.CurrentLoan.Borrower.ToString();
            }
            else
            {
                currentBorrowerValueLabel.Text = "No current borrower";
            }
        }
        private void InitializeMembers()
        {
            membersComboBox.Items.Clear();
            foreach (Member member in _libForm.CurrentLibrary.Members)
            {
                membersComboBox.Items.Add(member.ToString());
            }
        }
        private void InitializeHistory()
        {
            listBoxHistory.Items.Clear();
            foreach (Loan loan in _currentBook.HistoryOfLoans)
            {
                listBoxHistory.Items.Add(loan.ToString());
            }
        }
        private void returnBookButton_Click(object sender, EventArgs e)
        {
            if (_currentBook.CurrentLoan == null)
            {
                MessageBox.Show("This book is not loaned!");
                return;
            }
            else
            {
                _currentBook.ReturnBook();
                InitializeUI();
            }
        }
        private void loanBookButton_Click(object sender, EventArgs e)
        {
            DateTime selectedDate = borrowDateSelect.Value.Date;
            if (selectedDate > DateTime.Now.Date)
            {
                MessageBox.Show("You can't loan a book in the future!");
            }
            else
            {
                if (membersComboBox.SelectedIndex == -1)
                {
                    MessageBox.Show("You must select a member to loan a book!");
                    return;
                }
                else if (_currentBook.CurrentLoan != null)
                {
                    MessageBox.Show("This book is already loaned!");
                    return;
                }
                else
                {
                    _currentBook.LoanBook(_libForm.CurrentLibrary.Members[membersComboBox.SelectedIndex], selectedDate);
                    MessageBox.Show("Succesfully Loaned Book!");
                    InitializeUI();
                }
            }
        }
    }
}