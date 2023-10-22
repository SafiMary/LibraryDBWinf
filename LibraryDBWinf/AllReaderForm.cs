using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryDBWinf
{
    public partial class AllReaderForm : Form
    {
        private SqlDataReader reader;
        private DataTable table;
        private SqlConnection connection;
        private string readerBook = $"SELECT r.firstName+' '+r.lastName+' '+patronymic AS 'Читатель' FROM books b, readers r WHERE b.id = r.book_Id AND b.book_title= @book_title";// поиск читателя который взял конкретную книжку
        public AllReaderForm()
        {
            InitializeComponent();
            connection = new SqlConnection();
            connection.ConnectionString = ConfigurationManager.ConnectionStrings["MyConnString"].ConnectionString;
            //DataGridViewColumn column = dataGridView1.Columns[0];
            //column.Width = 20;
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            string name = textBoxName.Text;// содержимое текстбокс сложили в строку
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.Parameters.Add("@book_title", SqlDbType.Char).Value = name;
            sqlCommand.CommandText = readerBook;
            sqlCommand.Connection = connection;
            dataGridView1.DataSource = null;
            connection.Open();
            table = new DataTable();
            reader = sqlCommand.ExecuteReader();
            int line = 0;
            do
            {
                while (reader.Read())
                {
                    if (line == 0)
                    {
                        for (int i = 0; i <
                        reader.FieldCount; i++)
                        {
                            table.Columns.Add(reader.
                            GetName(i));
                        }
                        line++;
                    }
                    DataRow row = table.NewRow();
                    for (int i = 0; i <
                    reader.FieldCount; i++)
                    {
                        row[i] = reader[i];
                    }
                    table.Rows.Add(row);
                }
            } while (reader.NextResult());
            dataGridView1.DataSource = table;


            connection.Close();

            reader.Close();
        }
    }
}
