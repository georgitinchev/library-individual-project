using System;
using System.Xml.Linq;

namespace Library
{
    [Serializable]
    public class Loan
    {
        public int Id { get; private set; }
        public string Title { get; private set; }
        public Member Borrower { get; private set; }
        public DateTime BorrowDate { get; private set; }
        // nullable return date
        public DateTime? ReturnDate { get; private set; }
        public Loan(string title, Member borrower, DateTime borrowDate)
        {
            Id = borrower.Id;
            Title = title;
            Borrower = borrower;
            BorrowDate = borrowDate.Date;
            ReturnDate = null;
        }
        public void SetReturnDate()
        {
            this.ReturnDate = DateTime.Now.Date;
        }
        public override string ToString()
        {
            return $"Borrower: [{Id}] {Borrower.Name}| Borrow Date: {BorrowDate.ToString("dd/MM/yyyy")} Return Date: {ReturnDate?.ToString("dd/MM/yyyy")}";
        }
    }
}