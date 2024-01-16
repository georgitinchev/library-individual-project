// Library.cs
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Library
{
    [Serializable]
    public class Library
    {
        public string Name { get; set; }
        public List<Book> BookCatalogue { get;  set; }
        public List<Member> Members { get;  set; }
        public Library(string name)
        {
            Name = name;
            BookCatalogue = new List<Book>();
            Members = new List<Member>();
        }
        public Library()
        {
            Name = Name;
            BookCatalogue = new List<Book>();
            Members = new List<Member>();
        }
        public void ReturnBooksForMember(Member member)
        {
            foreach (Book book in BookCatalogue)
            {
                if (book.CurrentLoan != null && book.CurrentLoan.Borrower.Id == member.Id)
                {
                    book.ReturnBook();
                }
            }
        }
        public Book SearchBook(string title = "", string author = "", BookGenres? genre = null)
        {
            foreach (Book book in BookCatalogue)
            {
                if ((string.IsNullOrEmpty(title) || book.Title.ToLower().Contains(title.ToLower())) &&
                    (string.IsNullOrEmpty(author) || book.Author.ToLower().Contains(author.ToLower())) &&
                    (!genre.HasValue || book.Genre == genre.Value))
                {
                    return book;
                }
            }
            throw new Exception("No book found matching the provided criteria.");
        }
    }
}
