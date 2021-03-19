using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Library
{
    public partial class Form1 : Form
    {
        private Library library;
        private short mode = 0;// режим передачи книг 0-объекты, 1-поиск по книгам

        List<Book> TransferBooks; //временное хранилище для передаваемых книг
        List<string> StringsToSearch; //временное хранилище для передаваемых строк поиска

        public Form1()
        {
            InitializeComponent();

            library = new Library();
            TransferBooks = new List<Book>() { };
            StringsToSearch = new List<string>() { };
            fillIn();
            ReadersComboBox.SelectedIndex = 0;
            ReaderRadioButton.Checked = true;
            mode = 0;
            
        }

        private void RefreshForm()//обновляет информацию на форме
        {
            ListLibraryBooks.Items.Clear();
            ListReaderBooks.Items.Clear();         

            foreach (Book book in library.GetBooks())// вывод книг в библиотеке
            {
                ListLibraryBooks.Items.Add(book.Name + " " + book.Author);
            }

            foreach (Reader reader in library.GetReaders())// вывод книг выбранного пользователя
            {
                if (reader.ID == ReadersComboBox.SelectedIndex)
                {
                    foreach (Book book in reader.GetBooks())
                    {
                        ListReaderBooks.Items.Add(book.Name + " " + book.Author);
                    }
                }
            }

            if (ReaderRadioButton.Checked)
            {
                ListLibraryBooks.Enabled = true;
                ListReaderBooks.Enabled = false;
            }
            else
            {
                ListLibraryBooks.Enabled = false;
                ListReaderBooks.Enabled = true;
            }
        }

        private void fillIn() //заполняет библиотеку
        {            
            library.AddReader(new Reader("Иванов Н.С.", 0, "Юридический", 
                new DateTime(2000, 10, 6), "240-00-50", library));
            library.AddReader(new Reader("Петров А.Е.", 1, "Юридический",
                new DateTime(2001, 12, 26), "240-00-51", library));
            library.AddReader(new Reader("Сидоров В.П.", 2, "Управление",
                new DateTime(1999, 11, 16), "240-00-52", library));

            foreach (Reader reader in library.GetReaders())
            {
                ReadersComboBox.Items.Add(reader.Name);
            }

            library.AddBook(new Book("Почта духов", "Иван Крылов"));
            library.AddBook(new Book("Зритель", "Иван Крылов"));
            library.AddBook(new Book("Меркурий", "Иван Крылов"));
            library.AddBook(new Book("Государство", "Василий Жуковский"));
            library.AddBook(new Book("Азбука", "Лев Толстой"));
            library.AddBook(new Book("Песенник", "Лев Толстой"));
        }

        private void ReadersComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {            
            TransferBooks.Clear();
            StringsToSearch.Clear();
            RefreshForm();
        }

        private void ClearTransferListButton_Click(object sender, EventArgs e)
        {
            TransferBooksList.Items.Clear();
        }

        private void ReaderRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            TransferBooksList.Items.Clear();
            RefreshForm();
        }

        private void LibraryRadiButton_CheckedChanged(object sender, EventArgs e)
        {
            TransferBooksList.Items.Clear();
            RefreshForm();
        }

        private void TransferButton_Click(object sender, EventArgs e)
        {
            if (mode == 0)//передача книг как обьъектов
            {
                if (ReaderRadioButton.Checked)
                    library.GetReaders()[ReadersComboBox.SelectedIndex].TakeBook(TransferBooks);
                else
                    library.GetReaders()[ReadersComboBox.SelectedIndex].ReturnBook(TransferBooks);

                RefreshForm();
            }
            else if (mode == 1)//передача строк с запросами
            {
                foreach (string str in TransferBooksList.Items)
                    StringsToSearch.Add(str);

                if (ReaderRadioButton.Checked)
                {
                    library.GetReaders()[ReadersComboBox.SelectedIndex].TakeBook(StringsToSearch);
                }
                else
                {
                    library.GetReaders()[ReadersComboBox.SelectedIndex].ReturnBook(StringsToSearch);
                }
            }            

            TransferBooks.Clear();
            StringsToSearch.Clear();
            TransferBooksList.Items.Clear();
            RefreshForm();
        }

        private void ListLibraryBooks_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (mode != 0)
            {
                mode = 0;
                TransferBooks.Clear();
                StringsToSearch.Clear();
            }

            if (ListLibraryBooks.SelectedIndex != -1)
            {
                Book book = library.GetBookByIndex(ListLibraryBooks.SelectedIndex);
                if (book != null && !TransferBooks.Contains(book))
                {
                    TransferBooks.Add(book);
                    TransferBooksList.Items.Add(book.Name + " " + book.Author);
                }
            }            

            RefreshForm();
        }

        private void ListReaderBooks_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (mode != 0)
            {
                mode = 0;
                TransferBooks.Clear();
                StringsToSearch.Clear();
            }

            if (ListReaderBooks.SelectedIndex != -1)
            {
                Book book = library.GetReaders()[ReadersComboBox.SelectedIndex]
                    .GetBookByIndex(ListReaderBooks.SelectedIndex);
                if (book != null && !TransferBooks.Contains(book))
                {
                    TransferBooks.Add(book);
                    TransferBooksList.Items.Add(book.Name + " " + book.Author);
                }
            }

            RefreshForm();
        }

        private void AddToSearchButton_Click(object sender, EventArgs e)
        {
            if (mode != 1)
            {
                mode = 1;
                TransferBooks.Clear();
                StringsToSearch.Clear();
            }

            TransferBooksList.Items.Add(textBoxToSearch.Text);
        }

        private void NumberBooksToTransferButton_Click(object sender, EventArgs e)//добавление книг по количеству, идет в обход кнопки "Передать"
        {
            if (ReaderRadioButton.Checked)
            {
                library.GetReaders()[ReadersComboBox.SelectedIndex].TakeBook((int) BooksNumericUpDown.Value);
            }
            else
            {
                library.GetReaders()[ReadersComboBox.SelectedIndex].ReturnBook((int)BooksNumericUpDown.Value);
            }

            RefreshForm();
        }
    }
}
