using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryDBWinf
{
    public partial class Form1 : Form
    {
        Form NamebookForm = null;
        Form AuthorbookForm = null;
        Form PopularbookForm = null;
        Form AllReaderForm = null;


        public Form1()
        {
            InitializeComponent();
        }

        private void name_book_Click(object sender, EventArgs e)
        {
            if (NamebookForm == null)
            {
                NamebookForm = new NamebookForm();
                NamebookForm.Show();
            }
            else
            {
                if (MessageBox.Show(
                    "Закрыть окно ?", "Окно уже открыто",
                    MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    NamebookForm.Close();
                    NamebookForm = null;
                }
            }
        }

        private void author_book_Click(object sender, EventArgs e)
        {
            if (AuthorbookForm == null)
            {
                AuthorbookForm = new AuthorbookForm();
                AuthorbookForm.Show();
            }
            else
            {
                if (MessageBox.Show(
                    "Закрыть окно ?", "Окно уже открыто",
                    MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    AuthorbookForm.Close();
                    AuthorbookForm = null;
                }
            }
        }

        private void popular_book_Click(object sender, EventArgs e)
        {
            if (PopularbookForm == null)
            {
                PopularbookForm = new PopularbookForm();
                PopularbookForm.Show();
            }
            else
            {
                if (MessageBox.Show(
                    "Закрыть окно ?", "Окно уже открыто",
                    MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    PopularbookForm.Close();
                    PopularbookForm = null;
                }
            }
        }

        private void all_readers_Click(object sender, EventArgs e)
        {
            if (AllReaderForm == null)
            {
                AllReaderForm = new AllReaderForm();
                AllReaderForm.Show();
            }
            else
            {
                if (MessageBox.Show(
                    "Закрыть окно ?", "Окно уже открыто",
                    MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    AllReaderForm.Close();
                    AllReaderForm = null;
                }
            }
        }
    }
}
