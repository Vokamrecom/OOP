using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;


namespace WpfApp1
{
    /// <summary>
    /// Логика взаимодействия для AuthorWindow.xaml
    /// </summary>
    public partial class AuthorWindow : Window
    {
        public AuthorWindow()
        {
            InitializeComponent();
            comboBox1.Items.Add("Мужчина");
            comboBox1.Items.Add("Женщина");
          
        }
        string connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;

        private void Button1_Click(object sender, EventArgs e)
        {
            Author.AuthorFIO = textBox1.Text;
            Author.AuthorCountry = textBox2.Text;
            Author.AuthorSex = comboBox1.Text;

            string sqlExpression = $"INSERT INTO Authors ( AuthorFIO,  AuthorCountry, AuthorSex) VALUES ('{textBox1.Text}', '{textBox2.Text}', '{comboBox1.Text}')";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(sqlExpression, connection);
                int number = command.ExecuteNonQuery();
                // Console.WriteLine("Добавлено объектов: {0}", number);
              //  int number2 = command.ExecuteNonQuery();

               // textBox5.Text += "Книга добавлена" + Environment.NewLine;
            }
           // UpdateDB();


            this.Close();
        }
       

    }
}
