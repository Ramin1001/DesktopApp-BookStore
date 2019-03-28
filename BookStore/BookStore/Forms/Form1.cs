using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BookStore.Forms;


namespace BookStore
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void bookStoreToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            BookStoreForm bookStore = new BookStoreForm();
            bookStore.ShowDialog();
        }

        private void addBookToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddBookForm addBookForm = new AddBookForm();
            addBookForm.ShowDialog();
        }

        private void deleteBookToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RemoveBookForm removeBookForm = new RemoveBookForm();
            removeBookForm.ShowDialog();
        }

        private void editBookToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EditForm editForm = new EditForm();
            editForm.ShowDialog();
        }

        private void addAuthorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddAuthorForm authorForm = new AddAuthorForm();
            authorForm.ShowDialog();
        }

        private void deleteAuthorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RemoveAuthorForm removeAuthor = new RemoveAuthorForm();
            removeAuthor.ShowDialog();
        }
    }
}
