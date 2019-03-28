namespace BookStore.Forms
{
    partial class AddAuthorForm
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
            this.btnAddAuthor = new System.Windows.Forms.Button();
            this.txtAuthorName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnAddAuthor);
            this.panel1.Controls.Add(this.txtAuthorName);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(2, 70);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(368, 234);
            this.panel1.TabIndex = 3;
            // 
            // btnAddAuthor
            // 
            this.btnAddAuthor.BackColor = System.Drawing.Color.DarkOrchid;
            this.btnAddAuthor.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnAddAuthor.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAddAuthor.Location = new System.Drawing.Point(60, 142);
            this.btnAddAuthor.Name = "btnAddAuthor";
            this.btnAddAuthor.Size = new System.Drawing.Size(245, 59);
            this.btnAddAuthor.TabIndex = 2;
            this.btnAddAuthor.Text = "Add";
            this.btnAddAuthor.UseVisualStyleBackColor = false;
            this.btnAddAuthor.Click += new System.EventHandler(this.btnAddAuthor_Click);
            // 
            // txtAuthorName
            // 
            this.txtAuthorName.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtAuthorName.Location = new System.Drawing.Point(60, 78);
            this.txtAuthorName.Name = "txtAuthorName";
            this.txtAuthorName.Size = new System.Drawing.Size(245, 33);
            this.txtAuthorName.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(56, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(146, 24);
            this.label2.TabIndex = 0;
            this.label2.Text = "Author name";
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.SlateBlue;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Candara", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(371, 58);
            this.label1.TabIndex = 2;
            this.label1.Text = "New Author";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // AddAuthorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(371, 314);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "AddAuthorForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Add Author";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnAddAuthor;
        private System.Windows.Forms.TextBox txtAuthorName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}