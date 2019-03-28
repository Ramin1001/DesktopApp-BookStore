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
    public partial class RemoveAuthorForm : Form
    {
        public RemoveAuthorForm()
        {
            InitializeComponent();
        }

        private void RemoveAuthorForm_Load(object sender, EventArgs e)
        {
            UpdateAuthorList();
        }


        private void btnDel_Click(object sender, EventArgs e)
        {
            DialogResult question = MessageBox.Show("Are you sure?", "All books for this author will be deleted!", MessageBoxButtons.YesNo);

            if (question == DialogResult.Yes)
            {
                //=========================  Author-un silinmesi ====================================
                // downcast edirik ve comboBoxda secilmish author ID nomresini authorID-ye veririk
                string authorID = ((AuthorComboBox)cmbAuthorList.SelectedItem).Value;

                // AuthorList-den secilmish author ID-ye gore tapib veririk Author tipinde authorToDeleted-e
                // bir nov apcast olunur ki Author-un icinden lazim olana catsin
                Author authorToDeleted = AuthorList.GetAuthorByID(authorID);

                // AuthorList-den Author classina girib Authors siyahisindan 
                // ID-ci uyqun geleni silirik
                AuthorList.Authors.Remove(authorToDeleted);

                //==================================================================================

                //=========== Silinen Author-un Book siyahisinin silinmesi =====================//

                // silinen group-un icindeki studentleri yeni List massivine yiqiriq
                List<Book> bookToBedeleted = BookList.GetBookByGroup(authorToDeleted);

                // ve hemin massiv siralanir ve siyahidaki bookName-ler silinir
                foreach (Book bookName in bookToBedeleted)
                {
                    BookList.Books.Remove(bookName);
                }

                UpdateAuthorList();
            }
            else
            {
                MessageBox.Show("You are cancelled deletion!");
            }

        }

        private void UpdateAuthorList()
        {
            List<AuthorComboBox> comboBoxes = new List<AuthorComboBox>();

            foreach (Author author in AuthorList.Authors)
            {
                comboBoxes.Add(new AuthorComboBox
                {
                    Text = author.AuthorName,
                    Value = author.AuthorID
                });
            }
            cmbAuthorList.DataSource = comboBoxes;
        }

        
    }
}
