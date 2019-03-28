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

namespace BookStore.Forms
{
    public partial class AddAuthorForm : Form
    {
        public AddAuthorForm()
        {
            InitializeComponent();
        }

        private void btnAddAuthor_Click(object sender, EventArgs e)
        {
            string authorName = txtAuthorName.Text;

            // eger null veya boshdursa
            if (string.IsNullOrEmpty(authorName))
            {
                // ERROR mesajinin verilmersi
                MessageBox.Show("Author name is not valid", "Failed!",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);

                return;
            }

            // eger AuthorListde bu ad varsa
            if (AuthorList.ContainsAuthorName(authorName))
            {
                // ERROR mesaji verilir 
                MessageBox.Show("Author name is duplicate", "Failed!",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);

                return;
            }

            //user uyqun author adini daxil etdi ve bu addan yoxdur
            //bu halda yeni author-un AuthorList-e elave edilmesi
            AuthorList.AddAuthor(new Author(authorName));

            // Elave edildikden sonra setrin bosh gorsedilmesi
            txtAuthorName.Text = "";

            // Melumat mesajinin verilmesi
            MessageBox.Show("New author was successfully added", "Success!",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);


        }
    }
}
