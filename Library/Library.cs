using System;
using System.Collections.Generic;

namespace Library
{
    class Library
    {
        private Reader[] Readers;
        private List<Book> Books;

        public Reader[] GetReaders()
        {
            return Readers;
        }

        public List<Book> GetBooks()
        {
            return Books;
        }

        public Library()
        {
            Readers = new Reader[] { };
            Books = new List<Book> { };
        }

        public void AddReader(Reader reader)
        {
            Array.Resize(ref Readers, Readers.Length +1);
            Readers[Readers.Length-1] = reader;
        }

        public void AddBook(Book book)
        {
            Books.Add(book);
        }

        public void RemoveBook(Book book)
        {
            Books.Remove(book);
        }

        public List<Book> GetRandomBooks(int number)
        {
            List<Book> booksToReturn = new List<Book> { };

            if (number <= Books.Count)
            {
                while (booksToReturn.Count < number)
                {
                    booksToReturn.Add(Books[0]);
                    Books.RemoveAt(0);
                }
            }

            return booksToReturn;
        }

        public Book GetBookByName(string bookName)
        {
            foreach (Book book in Books)
            {
                if (book.Name.Contains(bookName) || book.Name.Equals(bookName))
                {
                    Books.Remove(book);
                    return book;
                }
            }

            return null;
        }
            
        public Book GetBookByIndex(int index)
        {
            return Books[index];
        }
    }
}
