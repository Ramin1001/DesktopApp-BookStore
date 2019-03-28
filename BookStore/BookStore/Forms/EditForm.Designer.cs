namespace BookStore.Forms
{
    partial class EditForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.txtBookDascript = new System.Windows.Forms.RichTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBookGenre = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbBookList = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.panel1.Controls.Add(this.cmbBookList);
            this.panel1.Controls.Add(this.btnConfirm);
            this.panel1.Controls.Add(this.txtBookDascript);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txtPrice);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtBookGenre);
            this.panel1.Location = new System.Drawing.Point(1, 38);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(597, 231);
            this.panel1.TabIndex = 5;
            // 
            // btnConfirm
            // 
            this.btnConfirm.BackColor = System.Drawing.Color.DarkOrchid;
            this.btnConfirm.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnConfirm.ForeColor = System.Drawing.Color.Black;
            this.btnConfirm.Location = new System.Drawing.Point(312, 136);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(242, 59);
            this.btnConfirm.TabIndex = 3;
            this.btnConfirm.Text = "Confirm";
            this.btnConfirm.UseVisualStyleBackColor = false;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // txtBookDascript
            // 
            this.txtBookDascript.Location = new System.Drawing.Point(312, 34);
            this.txtBookDascript.Name = "txtBookDascript";
            this.txtBookDascript.Size = new System.Drawing.Size(242, 76);
            this.txtBookDascript.TabIndex = 2;
            this.txtBookDascript.Text = "";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(40, 137);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 24);
            this.label4.TabIndex = 1;
            this.label4.Text = "Price";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(37, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 24);
            this.label3.TabIndex = 1;
            this.label3.Text = "Book genre";
            // 
            // txtPrice
            // 
            this.txtPrice.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtPrice.Location = new System.Drawing.Point(38, 164);
            this.txtPrice.Multiline = true;
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(225, 28);
            this.txtPrice.TabIndex = 0;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(308, 8);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(150, 24);
            this.label6.TabIndex = 1;
            this.label6.Text = "Book description";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(38, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Book name";
            // 
            // txtBookGenre
            // 
            this.txtBookGenre.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtBookGenre.Location = new System.Drawing.Point(38, 98);
            this.txtBookGenre.Multiline = true;
            this.txtBookGenre.Name = "txtBookGenre";
            this.txtBookGenre.Size = new System.Drawing.Size(225, 28);
            this.txtBookGenre.TabIndex = 0;
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
            this.label1.Location = new System.Drawing.Point(1, -2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(597, 40);
            this.label1.TabIndex = 4;
            this.label1.Text = "Edit Book";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cmbBookList
            // 
            this.cmbBookList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBookList.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cmbBookList.FormattingEnabled = true;
            this.cmbBookList.Location = new System.Drawing.Point(38, 34);
            this.cmbBookList.Name = "cmbBookList";
            this.cmbBookList.Size = new System.Drawing.Size(225, 32);
            this.cmbBookList.TabIndex = 5;
            this.cmbBookList.SelectedIndexChanged += new System.EventHandler(this.cmbBookList_SelectedIndexChanged);
            // 
            // EditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(598, 263);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "EditForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Edit Book Form";
            this.Load += new System.EventHandler(this.EditForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.RichTextBox txtBookDascript;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBookGenre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbBookList;
    }
}