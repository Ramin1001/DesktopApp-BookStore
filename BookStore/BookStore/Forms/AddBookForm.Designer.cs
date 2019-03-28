namespace BookStore.Forms
{
    partial class AddBookForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cmbAuthor = new System.Windows.Forms.ComboBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtBookDascript = new System.Windows.Forms.RichTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBookGenre = new System.Windows.Forms.TextBox();
            this.txtBookName = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.BackColor = System.Drawing.Color.SlateBlue;
            this.label1.Cursor = System.Windows.Forms.Cursors.Default;
            this.label1.Font = new System.Drawing.Font("Candara", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(1, -1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(663, 65);
            this.label1.TabIndex = 2;
            this.label1.Text = "Add Book";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.panel1.Controls.Add(this.cmbAuthor);
            this.panel1.Controls.Add(this.btnAdd);
            this.panel1.Controls.Add(this.txtBookDascript);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txtPrice);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtBookGenre);
            this.panel1.Controls.Add(this.txtBookName);
            this.panel1.Location = new System.Drawing.Point(0, 65);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(664, 335);
            this.panel1.TabIndex = 3;
            // 
            // cmbAuthor
            // 
            this.cmbAuthor.CausesValidation = false;
            this.cmbAuthor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAuthor.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbAuthor.FormattingEnabled = true;
            this.cmbAuthor.Location = new System.Drawing.Point(359, 37);
            this.cmbAuthor.Name = "cmbAuthor";
            this.cmbAuthor.Size = new System.Drawing.Size(242, 32);
            this.cmbAuthor.TabIndex = 8;
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.DarkOrchid;
            this.btnAdd.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnAdd.ForeColor = System.Drawing.Color.Black;
            this.btnAdd.Location = new System.Drawing.Point(213, 242);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(242, 59);
            this.btnAdd.TabIndex = 3;
            this.btnAdd.Text = "Add book";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtBookDascript
            // 
            this.txtBookDascript.CausesValidation = false;
            this.txtBookDascript.Location = new System.Drawing.Point(359, 114);
            this.txtBookDascript.Name = "txtBookDascript";
            this.txtBookDascript.Size = new System.Drawing.Size(242, 96);
            this.txtBookDascript.TabIndex = 2;
            this.txtBookDascript.Text = "";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(42, 151);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 24);
            this.label4.TabIndex = 1;
            this.label4.Text = "Price";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(40, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 24);
            this.label3.TabIndex = 1;
            this.label3.Text = "Book genre";
            // 
            // txtPrice
            // 
            this.txtPrice.CausesValidation = false;
            this.txtPrice.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtPrice.Location = new System.Drawing.Point(40, 182);
            this.txtPrice.Multiline = true;
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(225, 28);
            this.txtPrice.TabIndex = 0;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(361, 84);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(150, 24);
            this.label6.TabIndex = 1;
            this.label6.Text = "Book description";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(361, 10);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(119, 24);
            this.label5.TabIndex = 1;
            this.label5.Text = "Author name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(42, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Book name";
            // 
            // txtBookGenre
            // 
            this.txtBookGenre.CausesValidation = false;
            this.txtBookGenre.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtBookGenre.Location = new System.Drawing.Point(38, 114);
            this.txtBookGenre.Multiline = true;
            this.txtBookGenre.Name = "txtBookGenre";
            this.txtBookGenre.Size = new System.Drawing.Size(225, 28);
            this.txtBookGenre.TabIndex = 0;
            // 
            // txtBookName
            // 
            this.txtBookName.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtBookName.Location = new System.Drawing.Point(40, 41);
            this.txtBookName.Multiline = true;
            this.txtBookName.Name = "txtBookName";
            this.txtBookName.Size = new System.Drawing.Size(225, 28);
            this.txtBookName.TabIndex = 0;
            // 
            // AddBookForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(664, 397);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "AddBookForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "AddBookForm";
            this.Load += new System.EventHandler(this.AddBookForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.RichTextBox txtBookDascript;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBookGenre;
        private System.Windows.Forms.TextBox txtBookName;
        private System.Windows.Forms.ComboBox cmbAuthor;
    }
}