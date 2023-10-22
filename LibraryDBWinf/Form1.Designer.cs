namespace LibraryDBWinf
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuBook = new System.Windows.Forms.ToolStripMenuItem();
            this.name_book = new System.Windows.Forms.ToolStripMenuItem();
            this.author_book = new System.Windows.Forms.ToolStripMenuItem();
            this.popular_book = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuReader = new System.Windows.Forms.ToolStripMenuItem();
            this.all_readers = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuBook,
            this.toolStripMenuReader});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(9, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(582, 36);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuBook
            // 
            this.toolStripMenuBook.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.name_book,
            this.author_book,
            this.popular_book});
            this.toolStripMenuBook.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.toolStripMenuBook.Name = "toolStripMenuBook";
            this.toolStripMenuBook.Size = new System.Drawing.Size(142, 32);
            this.toolStripMenuBook.Text = "Поиск книги";
            // 
            // name_book
            // 
            this.name_book.Name = "name_book";
            this.name_book.Size = new System.Drawing.Size(340, 32);
            this.name_book.Text = "Поиск по названию книги";
            this.name_book.Click += new System.EventHandler(this.name_book_Click);
            // 
            // author_book
            // 
            this.author_book.Name = "author_book";
            this.author_book.Size = new System.Drawing.Size(340, 32);
            this.author_book.Text = "Поиск по автору книги";
            this.author_book.Click += new System.EventHandler(this.author_book_Click);
            // 
            // popular_book
            // 
            this.popular_book.Name = "popular_book";
            this.popular_book.Size = new System.Drawing.Size(340, 32);
            this.popular_book.Text = "Рейтинг книг";
            this.popular_book.Click += new System.EventHandler(this.popular_book_Click);
            // 
            // toolStripMenuReader
            // 
            this.toolStripMenuReader.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.all_readers});
            this.toolStripMenuReader.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.toolStripMenuReader.Name = "toolStripMenuReader";
            this.toolStripMenuReader.Size = new System.Drawing.Size(170, 32);
            this.toolStripMenuReader.Text = "Поиск читатели";
            // 
            // all_readers
            // 
            this.all_readers.Name = "all_readers";
            this.all_readers.Size = new System.Drawing.Size(339, 32);
            this.all_readers.Text = "Вывести список читателей";
            this.all_readers.Click += new System.EventHandler(this.all_readers_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(582, 453);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximumSize = new System.Drawing.Size(600, 500);
            this.MinimumSize = new System.Drawing.Size(600, 500);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "БИБЛИОТЕКА";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuBook;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuReader;
        private System.Windows.Forms.ToolStripMenuItem name_book;
        private System.Windows.Forms.ToolStripMenuItem author_book;
        private System.Windows.Forms.ToolStripMenuItem popular_book;
        private System.Windows.Forms.ToolStripMenuItem all_readers;
    }
}

