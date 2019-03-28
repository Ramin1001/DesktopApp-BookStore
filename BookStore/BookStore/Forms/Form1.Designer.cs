namespace BookStore
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.bookStoreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.shopToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addBookToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editBookToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteBookToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.authorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addAuthorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteAuthorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.AutoSize = false;
            this.menuStrip1.BackColor = System.Drawing.Color.SlateBlue;
            this.menuStrip1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bookStoreToolStripMenuItem,
            this.shopToolStripMenuItem,
            this.authorToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(986, 53);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "Book store";
            // 
            // bookStoreToolStripMenuItem
            // 
            this.bookStoreToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.bookStoreToolStripMenuItem.Name = "bookStoreToolStripMenuItem";
            this.bookStoreToolStripMenuItem.Size = new System.Drawing.Size(123, 49);
            this.bookStoreToolStripMenuItem.Text = "Book store";
            this.bookStoreToolStripMenuItem.Click += new System.EventHandler(this.bookStoreToolStripMenuItem_Click_1);
            // 
            // shopToolStripMenuItem
            // 
            this.shopToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addBookToolStripMenuItem,
            this.editBookToolStripMenuItem,
            this.deleteBookToolStripMenuItem});
            this.shopToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.shopToolStripMenuItem.Name = "shopToolStripMenuItem";
            this.shopToolStripMenuItem.Size = new System.Drawing.Size(80, 49);
            this.shopToolStripMenuItem.Text = "Books";
            // 
            // addBookToolStripMenuItem
            // 
            this.addBookToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addBookToolStripMenuItem.Name = "addBookToolStripMenuItem";
            this.addBookToolStripMenuItem.Size = new System.Drawing.Size(186, 30);
            this.addBookToolStripMenuItem.Text = "Add book";
            this.addBookToolStripMenuItem.Click += new System.EventHandler(this.addBookToolStripMenuItem_Click);
            // 
            // editBookToolStripMenuItem
            // 
            this.editBookToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.editBookToolStripMenuItem.Name = "editBookToolStripMenuItem";
            this.editBookToolStripMenuItem.Size = new System.Drawing.Size(186, 30);
            this.editBookToolStripMenuItem.Text = "Edit book";
            this.editBookToolStripMenuItem.Click += new System.EventHandler(this.editBookToolStripMenuItem_Click);
            // 
            // deleteBookToolStripMenuItem
            // 
            this.deleteBookToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.deleteBookToolStripMenuItem.Name = "deleteBookToolStripMenuItem";
            this.deleteBookToolStripMenuItem.Size = new System.Drawing.Size(186, 30);
            this.deleteBookToolStripMenuItem.Text = "Delete book";
            this.deleteBookToolStripMenuItem.Click += new System.EventHandler(this.deleteBookToolStripMenuItem_Click);
            // 
            // authorToolStripMenuItem
            // 
            this.authorToolStripMenuItem.BackColor = System.Drawing.Color.SlateBlue;
            this.authorToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addAuthorToolStripMenuItem,
            this.deleteAuthorToolStripMenuItem});
            this.authorToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.authorToolStripMenuItem.Name = "authorToolStripMenuItem";
            this.authorToolStripMenuItem.Size = new System.Drawing.Size(89, 49);
            this.authorToolStripMenuItem.Text = "Author";
            // 
            // addAuthorToolStripMenuItem
            // 
            this.addAuthorToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addAuthorToolStripMenuItem.Name = "addAuthorToolStripMenuItem";
            this.addAuthorToolStripMenuItem.Size = new System.Drawing.Size(200, 30);
            this.addAuthorToolStripMenuItem.Text = "Add author";
            this.addAuthorToolStripMenuItem.Click += new System.EventHandler(this.addAuthorToolStripMenuItem_Click);
            // 
            // deleteAuthorToolStripMenuItem
            // 
            this.deleteAuthorToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.deleteAuthorToolStripMenuItem.Name = "deleteAuthorToolStripMenuItem";
            this.deleteAuthorToolStripMenuItem.Size = new System.Drawing.Size(200, 30);
            this.deleteAuthorToolStripMenuItem.Text = "Delete author";
            this.deleteAuthorToolStripMenuItem.Click += new System.EventHandler(this.deleteAuthorToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label1.Cursor = System.Windows.Forms.Cursors.Default;
            this.label1.Font = new System.Drawing.Font("Candara", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.Snow;
            this.label1.Location = new System.Drawing.Point(0, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(985, 351);
            this.label1.TabIndex = 1;
            this.label1.Text = "Welcome to our Book Store";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(986, 404);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Book Store";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem bookStoreToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem shopToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addBookToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editBookToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteBookToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripMenuItem authorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addAuthorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteAuthorToolStripMenuItem;
    }
}

