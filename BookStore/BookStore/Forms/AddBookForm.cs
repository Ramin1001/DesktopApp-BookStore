using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BookStore.Data;
using BookStore.Forms;

namespace BookStore.Forms
{
    public partial class AddBookForm : Form
    {
        public AddBookForm()
        {
            InitializeComponent();
        }

        private void AddBookForm_Load(object sender, EventArgs e)
        {

            List<BookComboBox> cmbAuthorBoxes = new List<BookComboBox>();

            foreach(Author author in AuthorList.Authors)
            {
                cmbAuthorBoxes.Add(new BookComboBox
                {
                    Text = author.AuthorName,
                    Value=author.AuthorID
                });
            }
            cmbAuthor.DataSource = cmbAuthorBoxes;
        }


        private void btnAdd_Click(object sender, EventArgs e)
        {
            string bookName = txtBookName.Text;
            string bookGenre = txtBookGenre.Text;
            string bookPrice = txtPrice.Text;
            //string bookAuthor = txtAuthorName.Text;
            string bookDescript = txtBookDascript.Text;

            // secilmish qrupun ID nomresinin  groupID-ye verilmesi
            string authorId = ((BookComboBox)cmbAuthor.SelectedItem).Value;

            // Author tipinden deyishen yaradiriq
            // ve author siyahisinin ID-lerinden secilmishini deyishene veririk
            Author selectedAuthor = AuthorList.GetAuthorByID(authorId);

            if (selectedAuthor == null) // eger secilmish author yoxdursa
            {
                MessageBox.Show("Author doesn't exist");
                return;
            }

            if (string.IsNullOrEmpty(bookName))
            {
                // ERROR mesajinin verilmersi
                MessageBox.Show("Book name is not valid", "Failed!",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);

                return;
            }
            if (string.IsNullOrEmpty(bookGenre))
            {
                // ERROR mesajinin verilmersi
                MessageBox.Show("Book genre is not valid", "Failed!",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);

                return;
            }
            if (string.IsNullOrEmpty(bookDescript))
            {
                // ERROR mesajinin verilmersi
                MessageBox.Show("Book description is not valid", "Failed!",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);

                return;
            }
            if (string.IsNullOrEmpty(bookPrice))
            {
                // ERROR mesajinin verilmersi
                MessageBox.Show("Book price is not valid", "Failed!",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);

                return;
            }

            // eger AuthorListde bu ad varsa
            if (BookList.ContainsBookName(bookName))
            {
                // ERROR mesaji verilir 
                MessageBox.Show("Book name is duplicate", "Failed!",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);

                return;
            }





            BookList.AddBook(new Book {
                BookName = bookName,
                BookJenre = bookGenre,
                Price = bookPrice,
                Description = bookDescript,
                Authors = selectedAuthor,
            });

            txtBookName.Text = "";
            txtBookGenre.Text = "";
            txtBookDascript.Text = "";
            txtPrice.Text = "";

         }
    }
}
