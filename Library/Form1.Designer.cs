
namespace Library
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ListLibraryBooks = new System.Windows.Forms.ListBox();
            this.ListReaderBooks = new System.Windows.Forms.ListBox();
            this.ReadersComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.TransferBooksList = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TransferButton = new System.Windows.Forms.Button();
            this.ClearTransferListButton = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.ReaderRadioButton = new System.Windows.Forms.RadioButton();
            this.LibraryRadiButton = new System.Windows.Forms.RadioButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.AddToSearchButton = new System.Windows.Forms.Button();
            this.textBoxToSearch = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.NumberBooksToTransferButton = new System.Windows.Forms.Button();
            this.BooksNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BooksNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.ReadersComboBox);
            this.groupBox1.Controls.Add(this.ListReaderBooks);
            this.groupBox1.Controls.Add(this.ListLibraryBooks);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(335, 450);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Библиотека";
            // 
            // ListLibraryBooks
            // 
            this.ListLibraryBooks.FormattingEnabled = true;
            this.ListLibraryBooks.Location = new System.Drawing.Point(6, 37);
            this.ListLibraryBooks.Name = "ListLibraryBooks";
            this.ListLibraryBooks.Size = new System.Drawing.Size(151, 394);
            this.ListLibraryBooks.TabIndex = 0;
            this.ListLibraryBooks.SelectedIndexChanged += new System.EventHandler(this.ListLibraryBooks_SelectedIndexChanged);
            // 
            // ListReaderBooks
            // 
            this.ListReaderBooks.FormattingEnabled = true;
            this.ListReaderBooks.Location = new System.Drawing.Point(178, 77);
            this.ListReaderBooks.Name = "ListReaderBooks";
            this.ListReaderBooks.Size = new System.Drawing.Size(151, 355);
            this.ListReaderBooks.TabIndex = 1;
            this.ListReaderBooks.SelectedIndexChanged += new System.EventHandler(this.ListReaderBooks_SelectedIndexChanged);
            // 
            // ReadersComboBox
            // 
            this.ReadersComboBox.FormattingEnabled = true;
            this.ReadersComboBox.Location = new System.Drawing.Point(178, 37);
            this.ReadersComboBox.Name = "ReadersComboBox";
            this.ReadersComboBox.Size = new System.Drawing.Size(121, 21);
            this.ReadersComboBox.TabIndex = 2;
            this.ReadersComboBox.SelectedIndexChanged += new System.EventHandler(this.ReadersComboBox_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Книги в библиотеке";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(175, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Читатель";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(175, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Книги читателя";
            // 
            // TransferBooksList
            // 
            this.TransferBooksList.FormattingEnabled = true;
            this.TransferBooksList.Location = new System.Drawing.Point(344, 25);
            this.TransferBooksList.Name = "TransferBooksList";
            this.TransferBooksList.Size = new System.Drawing.Size(162, 355);
            this.TransferBooksList.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(341, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Книги для передачи";
            // 
            // TransferButton
            // 
            this.TransferButton.Location = new System.Drawing.Point(6, 357);
            this.TransferButton.Name = "TransferButton";
            this.TransferButton.Size = new System.Drawing.Size(159, 44);
            this.TransferButton.TabIndex = 2;
            this.TransferButton.Text = "Передать";
            this.TransferButton.UseVisualStyleBackColor = true;
            this.TransferButton.Click += new System.EventHandler(this.TransferButton_Click);
            // 
            // ClearTransferListButton
            // 
            this.ClearTransferListButton.Location = new System.Drawing.Point(344, 387);
            this.ClearTransferListButton.Name = "ClearTransferListButton";
            this.ClearTransferListButton.Size = new System.Drawing.Size(159, 44);
            this.ClearTransferListButton.TabIndex = 3;
            this.ClearTransferListButton.Text = "Очистить";
            this.ClearTransferListButton.UseVisualStyleBackColor = true;
            this.ClearTransferListButton.Click += new System.EventHandler(this.ClearTransferListButton_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.groupBox4);
            this.groupBox2.Controls.Add(this.groupBox3);
            this.groupBox2.Controls.Add(this.LibraryRadiButton);
            this.groupBox2.Controls.Add(this.ReaderRadioButton);
            this.groupBox2.Controls.Add(this.TransferButton);
            this.groupBox2.Location = new System.Drawing.Point(512, 25);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(174, 407);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            // 
            // ReaderRadioButton
            // 
            this.ReaderRadioButton.AutoSize = true;
            this.ReaderRadioButton.Checked = true;
            this.ReaderRadioButton.Location = new System.Drawing.Point(6, 19);
            this.ReaderRadioButton.Name = "ReaderRadioButton";
            this.ReaderRadioButton.Size = new System.Drawing.Size(113, 17);
            this.ReaderRadioButton.TabIndex = 3;
            this.ReaderRadioButton.TabStop = true;
            this.ReaderRadioButton.Text = "Выдать читателю";
            this.ReaderRadioButton.UseVisualStyleBackColor = true;
            this.ReaderRadioButton.CheckedChanged += new System.EventHandler(this.ReaderRadioButton_CheckedChanged);
            // 
            // LibraryRadiButton
            // 
            this.LibraryRadiButton.AutoSize = true;
            this.LibraryRadiButton.Location = new System.Drawing.Point(6, 42);
            this.LibraryRadiButton.Name = "LibraryRadiButton";
            this.LibraryRadiButton.Size = new System.Drawing.Size(136, 17);
            this.LibraryRadiButton.TabIndex = 4;
            this.LibraryRadiButton.Text = "Вернуть в библиотеку";
            this.LibraryRadiButton.UseVisualStyleBackColor = true;
            this.LibraryRadiButton.CheckedChanged += new System.EventHandler(this.LibraryRadiButton_CheckedChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.textBoxToSearch);
            this.groupBox3.Controls.Add(this.AddToSearchButton);
            this.groupBox3.Location = new System.Drawing.Point(6, 65);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(159, 79);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Поиск по названию";
            // 
            // AddToSearchButton
            // 
            this.AddToSearchButton.Location = new System.Drawing.Point(6, 45);
            this.AddToSearchButton.Name = "AddToSearchButton";
            this.AddToSearchButton.Size = new System.Drawing.Size(147, 23);
            this.AddToSearchButton.TabIndex = 0;
            this.AddToSearchButton.Text = "Добавить в список";
            this.AddToSearchButton.UseVisualStyleBackColor = true;
            this.AddToSearchButton.Click += new System.EventHandler(this.AddToSearchButton_Click);
            // 
            // textBoxToSearch
            // 
            this.textBoxToSearch.Location = new System.Drawing.Point(6, 19);
            this.textBoxToSearch.Name = "textBoxToSearch";
            this.textBoxToSearch.Size = new System.Drawing.Size(147, 20);
            this.textBoxToSearch.TabIndex = 1;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.BooksNumericUpDown);
            this.groupBox4.Controls.Add(this.NumberBooksToTransferButton);
            this.groupBox4.Location = new System.Drawing.Point(6, 150);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(159, 79);
            this.groupBox4.TabIndex = 6;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Добавить количство книг";
            // 
            // NumberBooksToTransferButton
            // 
            this.NumberBooksToTransferButton.Location = new System.Drawing.Point(6, 45);
            this.NumberBooksToTransferButton.Name = "NumberBooksToTransferButton";
            this.NumberBooksToTransferButton.Size = new System.Drawing.Size(147, 23);
            this.NumberBooksToTransferButton.TabIndex = 0;
            this.NumberBooksToTransferButton.Text = "Добавить в список";
            this.NumberBooksToTransferButton.UseVisualStyleBackColor = true;
            this.NumberBooksToTransferButton.Click += new System.EventHandler(this.NumberBooksToTransferButton_Click);
            // 
            // BooksNumericUpDown
            // 
            this.BooksNumericUpDown.Location = new System.Drawing.Point(6, 19);
            this.BooksNumericUpDown.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.BooksNumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.BooksNumericUpDown.Name = "BooksNumericUpDown";
            this.BooksNumericUpDown.Size = new System.Drawing.Size(147, 20);
            this.BooksNumericUpDown.TabIndex = 1;
            this.BooksNumericUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.BooksNumericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(695, 450);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.ClearTransferListButton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TransferBooksList);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Библиотека";            
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.BooksNumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox ReadersComboBox;
        private System.Windows.Forms.ListBox ListReaderBooks;
        private System.Windows.Forms.ListBox ListLibraryBooks;
        private System.Windows.Forms.Button ClearTransferListButton;
        private System.Windows.Forms.Button TransferButton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox TransferBooksList;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton LibraryRadiButton;
        private System.Windows.Forms.RadioButton ReaderRadioButton;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.NumericUpDown BooksNumericUpDown;
        private System.Windows.Forms.Button NumberBooksToTransferButton;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox textBoxToSearch;
        private System.Windows.Forms.Button AddToSearchButton;
    }
}

