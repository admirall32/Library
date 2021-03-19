using System;
using System.Collections.Generic;

namespace Library
{
    class Reader
    {
        public string Name { get; private set; }
        public int ID { get; private set; }
        public string Faculty { get; private set; }
        public DateTime DateOfBirth { get; private set; }
        public string TelephoneNumber { get; private set; }
        private Library myLibrary;

        private List<Book> bookList;

        public Reader(string name, int id, string faculty, 
            DateTime dateOfBirth, string telephoneNumber,Library library)
        {
            Name = name;
            ID = id;
            Faculty = faculty;
            DateOfBirth = dateOfBirth;
            TelephoneNumber = telephoneNumber;
            myLibrary = library;
            bookList = new List<Book> { };
        }

        public bool TakeBook(List<Book> newBooks)
        {
            if (newBooks != null && newBooks.Count > 0)
            {
                string resultString = Name + " взял: ";

                foreach (Book book in newBooks)
                {
                    bookList.Add(book);
                    myLibrary.RemoveBook(book);
                    resultString += book.Name + ", ";
                }

                resultString = resultString.Substring(0, resultString.Length - 1) + ".";
                Console.WriteLine(resultString);
                return true;
            }                
            else
            {
                Console.WriteLine("Нет книг для добавления.");
                return false;
            }

        }

        public bool TakeBook(int numberOfBooks)
        {
            if (numberOfBooks > 0)
            {
                List<Book> newBooks = myLibrary.GetRandomBooks(numberOfBooks);
                if (newBooks.Count > 0)
                {
                    TakeBook(newBooks);
                    Console.WriteLine(Name + " взял " + newBooks.Count + " книг(и).");
                    return true;
                }
                else
                    return false;
            }
            else
                return false;
        }

        public bool TakeBook(List<string> bookNames)
        {
            if (bookNames.Count > 0)
            {
                List<Book> newBooks = new List<Book> { };

                foreach (string bookName  in bookNames)
                {                    
                    Book currentBook = myLibrary.GetBookByName(bookName);

                    if (currentBook != null)
                        newBooks.Add(currentBook);
                    else
                        Console.WriteLine("Книга с названием \"" + bookName + "\" не найдена.");                    
                }

                if (newBooks.Count > 0)
                {
                    TakeBook(newBooks);
                    return true;
                }
            }

            return false;
        }
    
        public bool ReturnBook(List<Book> booksToReturn)
        {
            if (booksToReturn.Count > 0)
            {
                foreach (Book book in booksToReturn)
                {
                    myLibrary.AddBook(book);
                    bookList.Remove(book);
                    Console.WriteLine("Книга " + book.Author + " " 
                        + book.Name + " возвращена в библиотеку.");
                }
                return true;
            }
            return false;
        }

        public bool ReturnBook(int numberOfBooks)
        {
            if (bookList != null && numberOfBooks <= bookList.Count)
            {
                for (int i = 0; i < numberOfBooks; i++)
                {
                    myLibrary.AddBook(bookList[0]);                    
                    Console.WriteLine("Книга " + bookList[0] + " "
                        + bookList[0] + " возвращена в библиотеку.");
                    bookList.RemoveAt(0);
                }
                return true;
            }

            return false;
        }

        public bool ReturnBook(List<string> bookNames)
        {
            if (bookNames.Count > 0)
            {
                List<Book> newBooks = new List<Book> { };

                foreach (string bookName in bookNames)
                {
                    Book currentBook = GetBookByName(bookName);

                    if (currentBook != null)
                        myLibrary.AddBook(currentBook);
                    else
                        Console.WriteLine("Книга с названием \"" + bookName + "\" не найдена.");
                }

                return true;
            }

            return false;
        }

        public Book GetBookByName(string bookName)
        {
            foreach (Book book in bookList)
            {
                if (book.Name.Contains(bookName) || book.Name.Equals(bookName))
                {
                    bookList.Remove(book);
                    return book;
                }
            }

            return null;
        }

        public Book GetBookByIndex(int index)
        {
            return bookList[index];
        }

        public List<Book> GetBooks()
        {
            return bookList;
        }
    }
}
