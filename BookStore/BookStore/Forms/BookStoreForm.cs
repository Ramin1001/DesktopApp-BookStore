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
    public partial class BookStoreForm : Form
    {
        public BookStoreForm()
        {
            InitializeComponent();
        }
          

        private void BookStoreForm_Load(object sender, EventArgs e)
        {
            //cedvelde kitab siyahsindaki kitablarin yerleshdirilmesi
            GridViewBookList.DataSource = BookList.Books;

            // Muellif adlarinin BookComboBox-a yerleshdirilmesi
            List<BookComboBox> AuthorCombos = new List<BookComboBox>();

            foreach (Author author in AuthorList.Authors)
            {
                AuthorCombos.Add(new BookComboBox
                {
                    Text=author.AuthorName,
                    Value=author.AuthorID
                });
            }

            cmbAuthors.Items.Add("All");

            cmbAuthors.Items.AddRange(AuthorCombos.ToArray());
        }

        // yeni event elave edirik
        private void cmbAuthors_SelectedIndexChanged(object sender, EventArgs e)
        {
            // muelliflerin adlarini gotururuk
            string authorName = cmbAuthors.Text;

            // cedvelde Authors kolonunun indexsini gotururuk
            int index = GridViewBookList.Columns["Authors"].Index;

            foreach(DataGridViewRow item in GridViewBookList.Rows)
            {
                // eger siranin indexsinin string-e cevrilmis deyeri authorName-e beraberdirse
                if (item.Cells[index].Value.ToString() == authorName)
                {
                    item.DefaultCellStyle.BackColor=Color.Yellow;
                }
                else
                {
                    item.DefaultCellStyle.BackColor = Color.White;
                }
            }
        }
    }
}
