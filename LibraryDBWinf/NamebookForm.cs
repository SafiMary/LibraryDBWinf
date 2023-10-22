using MySql.Data.MySqlClient;
using MySqlX.XDevAPI;
using MySqlX.XDevAPI.CRUD;
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
    public partial class NamebookForm : Form
    {
        private string findBook = $"SELECT * FROM books  WHERE book_title = @book_title";//поиск книги по названию
        private string countBook = $"SELECT SUM(number_total) book_title FROM books WHERE book_title = @book_title";
        SqlConnection connection;
       
        public NamebookForm()
        {
            InitializeComponent();
            connection = new SqlConnection();
            connection.ConnectionString = ConfigurationManager.ConnectionStrings["MyConnString"].ConnectionString;
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            string name = textBoxname.Text;// содержимое текстбокс сложили в строку

            connection.Open();
            DataTable table = new DataTable();//создана пустая таблица
            SqlCommand sqlCommand = new SqlCommand(findBook, connection);
            SqlDataAdapter adapter = new SqlDataAdapter(sqlCommand);
            sqlCommand.Parameters.Add("@book_title", SqlDbType.Char).Value = name;
            adapter.SelectCommand = sqlCommand;//указали что нужно выполнить именно эту команду
            adapter.Fill(table);//зполняем таблицу данными которые получили
            if (table.Rows.Count > 0)
            {
                textBoxInstock.Text = "есть в наличии";
            }
            else
            {
                textBoxInstock.Text = "нет в наличии";
            }
            //получаем скалярное выражение,а  именно количество книг с данным названием
            sqlCommand.CommandText = countBook;// изменили текст команды на другую
            object count = sqlCommand.ExecuteScalar();
            textBoxCount.Text = count.ToString();//вывели в текст бокс

            connection.Close();


        }
       

        }
        }
    

