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
    public partial class PopularbookForm : Form
    {
        private SqlDataReader reader;
        private DataTable table;
        private SqlConnection connection;
        private string popularBook = $"SELECT b.book_title AS 'Популярная книга' FROM books b, readers r WHERE b.id = r.book_Id GROUP BY b.book_title HAVING COUNT(b.id) > 10";//поиск популярной книги
        private string unpopularBook = $"SELECT b.book_title AS 'Непопулярная книга' FROM books b, readers r WHERE b.id = r.book_Id GROUP BY b.book_title HAVING COUNT(b.id) < 10";//поиск непопулярной книги
        public PopularbookForm()
        {
            InitializeComponent();
            connection = new SqlConnection();
            connection = new SqlConnection();
            connection.ConnectionString = ConfigurationManager.ConnectionStrings["MyConnString"].ConnectionString;
            //DataGridViewColumn column = dataGridView1.Columns[0];
            //column.Width = 20;
        }

        private void buttonpopular_Click(object sender, EventArgs e)
        {
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.CommandText = popularBook;
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

        private void buttonUnpopular_Click(object sender, EventArgs e)
        {
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.CommandText = unpopularBook;
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
   

