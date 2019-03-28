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
    public partial class RemoveBookForm : Form
    {
        public RemoveBookForm()
        {
            InitializeComponent();
        }


        private void RemoveBookForm_Load(object sender, EventArgs e)
        {
            UpdateBookList();
        }


        private void btnDel_Click(object sender, EventArgs e)
        {
            DialogResult question = MessageBox.Show("Are you sure?","",MessageBoxButtons.YesNo);

            if (question == DialogResult.Yes)
            {
                //=========================  Book-un silinmesi ====================================
                // downcast edirik ve BookComboBox secilmish book ID nomresini bookId-ye veririk
                string bookId = ((BookComboBox)cmbBookList.SelectedItem).Value;

                // BookList-den secilmish book ID-ye gore tapib veririk Book tipinde bookForDelete-e
                // bir nov apcast olunur ki Book-un icinden lazim olana catsin
                Book bookForDelete = BookList.GetBookById(bookId);

                // BookList-den Book classina girib Books siyahisindan 
                // ID-ci uyqun geleni silirik
                BookList.Books.Remove(bookForDelete);
            }

            UpdateBookList();

        }

        private void UpdateBookList()
        {
            List<BookComboBox> comboBoxes = new List<BookComboBox>();

            foreach(Book book in BookList.Books)
            {
                comboBoxes.Add(new BookComboBox
                {
                    Text = book.BookName,
                    Value=book.BookID
                });
            }

            cmbBookList.DataSource = comboBoxes;
        }

        
    }
}
