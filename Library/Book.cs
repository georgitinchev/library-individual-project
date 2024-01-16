using System;
using System.Collections.Generic;

namespace Library
{
    [Serializable]
    public class Book
    {
        public string Title { get; private set; }
        public string Author { get; private set; }
        public string Description { get; private set; }
        public long Isbn13 { get; private set; }
        public int PageNum { get; private set; }
        public DateTime ReleaseDate { get; private set; }
        public BookGenres Genre { get; private set; } // 1 genre from enum
        public Loan CurrentLoan { get; set; } // 0 or 1 Loans (null if 0)
        public List<Loan> HistoryOfLoans { get; set; } // indefinite length

        public Book(string title, string author,string description, long isbn13, int pageNum, DateTime releaseDate, BookGenres genre)
        {
            Title = title;
            Author = author;
            Description = description;
            Isbn13 = isbn13;
            PageNum = pageNum;
            ReleaseDate = releaseDate;
            Genre = genre;
            CurrentLoan = null;
            HistoryOfLoans = new List<Loan>();
        }
        public void LoanBook(Member member, DateTime loanDate)
        {
            Loan loan = new Loan(this.Title, member, loanDate);   
            CurrentLoan = loan;
        }
        public void ReturnBook()
        {
            CurrentLoan.SetReturnDate();
            HistoryOfLoans.Add(CurrentLoan);
            CurrentLoan = null;
        }
    }
}