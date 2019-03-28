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
    public partial class EditForm : Form
    {
        public EditForm()
        {
            InitializeComponent();
        }

        private void EditForm_Load(object sender, EventArgs e)
        {
            UpdateBookList();
        }

        private void cmbBookList_SelectedIndexChanged(object sender, EventArgs e)
        {
            // kitablarin adlarini gotururuk
            string bookName = cmbBookList.Text;

        }



        private void btnConfirm_Click(object sender, EventArgs e)
        {
            //string newBookName = txtBookName.Text;
            //string newGenre = txtBookGenre.Text;
            //string newDescript = txtBookDascript.Text;
            //string newPrice = txtPrice.Text;
            //string newAuthor = txtAuthorName.Text;
        }



        private void UpdateBookList()
        {
            List<BookComboBox> comboBoxes = new List<BookComboBox>();

            foreach (Book book in BookList.Books)
            {
                comboBoxes.Add(new BookComboBox
                {
                    Text = book.BookName,
                    Value = book.BookID
                });
            }
            cmbBookList.DataSource = comboBoxes;
        }

        
    }
}
