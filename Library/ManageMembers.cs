using System;
using System.Windows.Forms;

namespace Library
{
    public partial class ManageMembers : Form
    {
        private LibForm _libForm;
        public ManageMembers(LibForm libForm)
        {
            _libForm = libForm;
            InitializeComponent();
            InitializeUi();
        }
        private void InitializeUi() 
        {
            currentMembersListBox.Items.Clear();
            foreach (Member member in _libForm.CurrentLibrary.Members)
            {
                currentMembersListBox.Items.Add(member.ToString());
            }
        }
        private void memberNameButton_Click(object sender, EventArgs e)
        {
            try {
                ValidateMemberName(memberNameBox.Text);
                CheckIfMemberExists(memberNameBox.Text);
                Member newMember = new Member(memberNameBox.Text);
                _libForm.CurrentLibrary.Members.Add(newMember);
                InitializeUi();
                memberNameBox.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void removeSelectedMember_Click(object sender, EventArgs e)
        {
            foreach (Member member in _libForm.CurrentLibrary.Members)
            {
                if (member.ToString() == currentMembersListBox.SelectedItem.ToString())
                {
                    // Check if the member has a book loaned
                    foreach (Book book in _libForm.CurrentLibrary.BookCatalogue)
                    {
                        if (book.CurrentLoan != null && book.CurrentLoan.Borrower.Id == member.Id)
                        {
                            book.ReturnBook();
                        }
                    }
                    _libForm.CurrentLibrary.Members.Remove(member);
                    InitializeUi();
                    MessageBox.Show("Member removed successfully!");
                    return;
                }
            }
        }
        private void ValidateMemberName(string name)
        {
            if (string.IsNullOrEmpty(name))
            {
                throw new Exception("Name cannot be empty!");
            }
            if (name.Length < 3)
            {
                throw new Exception("Name must be at least 3 characters long!");
            }
            if (name.Length > 50)
            {
                throw new Exception("Name cannot be longer than 50 characters!");
            }
        }
        private void CheckIfMemberExists(string name)
        {
            foreach (Member member in _libForm.CurrentLibrary.Members)
            {
                if (member.Name.ToLower() == name.ToLower())
                {
                    throw new Exception("Member already exists!");
                }
            }
        }
    }
}
