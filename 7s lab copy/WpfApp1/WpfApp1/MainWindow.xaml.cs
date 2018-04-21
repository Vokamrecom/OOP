using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.IO;
using System.Xml.Serialization;
using System.Xml.Linq;
using System.Configuration;
using System.Data.SqlClient;
using System.Threading.Tasks;
using System.Data;


namespace WpfApp1
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        static string info = "";
        string sqlExpAuthors = "";
        string sqlExpBooks = "";
        string sqlExpPubhouses = "";
        string sql1 = "SELECT * FROM Books";
        string sql2 = "SELECT * FROM Authors";
        string sql3 = "SELECT * FROM Pubhouses";
        SqlDataAdapter adapter;
        DataTable LibTable1 = new DataTable();
        DataTable LibTable2 = new DataTable();
        DataTable LibTable3 = new DataTable();


        string connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;


        public MainWindow()
        {
            InitializeComponent();
            textBox5.VerticalScrollBarVisibility = ScrollBarVisibility.Visible;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                MessageBox.Show("Подключение открыто");
                info += "\tСтрока подключения: " + connection.ConnectionString;
                info += "\n\tБаза данных: " + connection.Database;
                info += "\n\tСервер: " + connection.DataSource;
                info += "\n\tВерсия сервера: " + connection.ServerVersion;
                info += "\n\tСостояние: " + connection.State;
                info += "\n\tWorkstationld: " + connection.WorkstationId;
            }

            using (SqlConnection connection = new SqlConnection(connectionString)) //для вывода информации
            {
                connection.Open();
                // Создаем объект DataAdapter
                SqlDataAdapter adapter1 = new SqlDataAdapter(sql1, connection);
                //  SqlDataAdapter adapter2 = new SqlDataAdapter(sql2, connection);
                //   SqlDataAdapter adapter3 = new SqlDataAdapter(sql3, connection);

                // Заполняем Dataset
                adapter1.Fill(LibTable1);
                //  adapter2.Fill(LibTable2);
                // adapter3.Fill(LibTable3);

                // Отображаем данные
                BooksGrid.ItemsSource = LibTable1.DefaultView;
                // AuthorsGrid.ItemsSource = LibTable2.DefaultView;
                //    PubGrid.ItemsSource = LibTable3.DefaultView;

            }

            Console.Read();

            textBox5.Text += info;

        }

        private void UpdateButton_Click(object sender, RoutedEventArgs e)
        {
            // вывод всех пользователей

            // название процедуры
            string sqlExpression = "sp_GetBooks";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlDataAdapter command = new SqlDataAdapter(sqlExpression, connection);
                // указываем, что команда представляет хранимую процедуру


                LibTable1.Clear();

                // Заполняем Dataset
                command.Fill(LibTable1);

                // Отображаем данные
                BooksGrid.ItemsSource = LibTable1.DefaultView;

            }

            // UpdateDB();
        }

        private void DeleteButton_Click(object sender, RoutedEventArgs e)
        {

            string sqlExpression = $"DELETE  FROM Books WHERE Name='{BookSearch.Text}'";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(sqlExpression, connection);
                int number = command.ExecuteNonQuery();
                MessageBox.Show("Удалено ");

            }

            UpdateDB();

        }

        private void UpdateDB()
        {
            string sqlExpression = "sp_GetBooks";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlDataAdapter command = new SqlDataAdapter(sqlExpression, connection);
                // указываем, что команда представляет хранимую процедуру


                LibTable1.Clear();

                // Заполняем Dataset
                command.Fill(LibTable1);

                // Отображаем данные
                BooksGrid.ItemsSource = LibTable1.DefaultView;

            }
        }

        private void Button1_Click(object sender, EventArgs e) //автор
        {
            AuthorWindow author = new AuthorWindow();
            author.Show();
        }


        private void Button2_Click(object sender, EventArgs e) //издатель
        {
            PubhouseWindow pubhouse = new PubhouseWindow();
            pubhouse.Show();
        }

        private void Button3_Click(object sender, EventArgs e) //добавить
        {
            try
            {
                string sqlExpression =
                    $"INSERT INTO Books (UDK, Name,  Pages, Year, Date) VALUES ('{textBox2.Text}', '{textBox1.Text}', '{textBox4.Text}', '{textBox3.Text}' , '{dateTimePicker1.Text}')";

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand(sqlExpression, connection);
                    int number = command.ExecuteNonQuery();
                    MessageBox.Show("Книга добавлена");


                    textBox5.Text += "Книга добавлена" + Environment.NewLine;
                }

                UpdateDB();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Button4_Click(object sender, EventArgs e) //назад
        {
            textBox5.Undo();
//            if (pageNumber == 0) return;
//            pageNumber--;

            //            using (SqlConnection connection = new SqlConnection(connectionString))
            //            {
            //                adapter = new SqlDataAdapter(GetSql(), connection);

            //                ds.Tables["Books"].Rows.Clear();

            //                adapter.Fill(ds, "Books");
            //            }
        }

        // обработчик кнопки Вперед
        private void Button5_Click(object sender, EventArgs e)
        {
            //    if (ds.Tables["Books"].Rows.Count < pageSize) return;

            //    pageNumber++;
            //    using (SqlConnection connection = new SqlConnection(connectionString))
            //    {
            //        adapter = new SqlDataAdapter(GetSql(), connection);

            //        ds.Tables["Books"].Rows.Clear();

            //        adapter.Fill(ds, "Books");
            //    }
        }

        private void Button6_Click(object sender, EventArgs e) //очистка
        {
            LibTable1.Clear();
            //            using (FileStream fs = new FileStream("books.xml", FileMode.Create))
            //            {
            //                textBox5.Clear();
            //                textBox5.Text += "XML файл очищен.";
            //            }
        }

        private void zap1_Click(object sender, RoutedEventArgs e) //запрос
        {
            string sqlExpression = "sp_GetZap1";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlDataAdapter command = new SqlDataAdapter(sqlExpression, connection);

                LibTable1.Clear();

                // Заполняем Dataset
                command.Fill(LibTable1);
                // adapter2.Fill(LibTable2);
                // adapter3.Fill(LibTable3);

            }
        }

        private void AbProg_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Library version 1.1. Powered by Ermakov Kiril.");
        }


        private void SortAuthorClick(object sender, EventArgs e) //
        {
            //bool ur = true;
            //textBox5.Clear();

            //string book = "books.xml";
            //using (FileStream fs = new FileStream("books.xml", FileMode.OpenOrCreate))
            //{
            //    if (fs.Length == 0)
            //    {
            //        MessageBox.Show("Файл пуст.");
            //        ur = false;
            //    }
            //}
            //if (ur)
            //{
            //    XDocument doc = XDocument.Load(book);
            //    List<Book> Sorter = new List<Book>();
            //    var items = from xe in doc.Root.Elements("Book")
            //                orderby xe.Element("AuthorFIO").Value
            //                select xe;
            //    foreach (var bk in items)
            //    {
            //        textBox5.Text += "Название: " + bk.Element("Name").Value + Environment.NewLine + "УДК: " + bk.Element("Udk").Value + Environment.NewLine + "Год издания: " + bk.Element("Year").Value + Environment.NewLine + "Кол.во страниц: " + bk.Element("Pages").Value + Environment.NewLine + "Наличие CD, DVD: " + bk.Element("Cd").Value + "," + bk.Element("Dvd").Value + Environment.NewLine + "Дата поступления: " + bk.Element("Date").Value + Environment.NewLine;
            //        textBox5.Text += "Автор: " + bk.Element("AuthorFIO").Value + Environment.NewLine + "Страна: " + bk.Element("AuthorCountry").Value + Environment.NewLine + "Пол: " + bk.Element("AuthorSex").Value + Environment.NewLine;
            //        textBox5.Text += "Издательство: " + bk.Element("Pubname").Value + Environment.NewLine + "Страна: " + bk.Element("PubCountry").Value + Environment.NewLine + "Город: " + bk.Element("PubCity").Value + Environment.NewLine + "Тип: " + bk.Element("Type").Value + Environment.NewLine;
            //    }
            //    var box = from t in Box.box
            //              orderby t.AuthorFIO
            //              select t;
            //    foreach (var bk in box)
            //    {
            //        Sorter.Add(bk);
            //    }
            //    XmlSerializer formatter1 = new XmlSerializer(typeof(List<Book>));
            //    using (FileStream fs = new FileStream("books.xml", FileMode.OpenOrCreate))
            //    {
            //        formatter1.Serialize(fs, Sorter);
            //    }
            //    MessageBox.Show("Сортировка по году успешно выполнена! Файл перезаписан.");
            //}

        }

        private void SortYearClick(object sender, EventArgs e)
        {
            //textBox5.Clear();
            //bool ur = true;
            //string book = "books.xml";
            //List<Book> Sorter = new List<Book>();
            //using (FileStream fs = new FileStream("books.xml", FileMode.OpenOrCreate))
            //{
            //    if (fs.Length == 0)
            //    {
            //        MessageBox.Show("Файл пуст.");
            //        ur = false;
            //    }
            //}
            //if (ur)
            //{
            //    XDocument doc = XDocument.Load(book);
            //    var items = from xe in doc.Root.Elements("Book")
            //                orderby int.Parse(xe.Element("Year").Value)
            //                select xe;
            //    foreach (var bk in items)
            //    {
            //        // textBox5.Text += "Название: " + bk.Element("Name").Value + Environment.NewLine + "УДК: " + bk.Element("Udk").Value + Environment.NewLine + "Год издания: " + bk.Element("Year").Value + Environment.NewLine + "Кол.во страниц: " + bk.Element("Pages").Value + Environment.NewLine + "Наличие CD, DVD: " + bk.Element("Cd").Value + "," + bk.Element("Dvd").Value + Environment.NewLine + "Дата поступления: " + bk.Element("Date").Value + Environment.NewLine;
            //        textBox5.Text += "Автор: " + bk.Element("AuthorFIO").Value + Environment.NewLine + "Страна: " + bk.Element("AuthorCountry").Value + Environment.NewLine + "Пол: " + bk.Element("AuthorSex").Value + Environment.NewLine;
            //        //textBox5.Text += "Издательство: " + bk.Element("Pubname").Value + Environment.NewLine + "Страна: " + bk.Element("PubCountry").Value + Environment.NewLine + "Город: " + bk.Element("PubCity").Value + Environment.NewLine + "Тип: " + bk.Element("Type").Value + Environment.NewLine;

            //    }
            //    var box = from t in Box.box
            //              orderby t.Year
            //              select t;
            //    foreach (var bk in box)
            //    {
            //        Sorter.Add(bk);
            //    }
            //    XmlSerializer formatter1 = new XmlSerializer(typeof(List<Book>));
            //    using (FileStream fs = new FileStream("books.xml", FileMode.OpenOrCreate))
            //    {
            //        formatter1.Serialize(fs, Sorter);
            //    }
            //    MessageBox.Show("Сортировка по авторам успешно выполнена! Файл перезаписан.");
            //}
        }

        private void Search_Click(object sender, RoutedEventArgs e)
        {
            //try
            //{
            string sqlExpression =
                $"Select  * From Books where Name like '%{BookSearch.Text}%'";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlDataAdapter command = new SqlDataAdapter(sqlExpression, connection);
                // указываем, что команда представляет хранимую процедуру


                LibTable1.Clear();

                // Заполняем Dataset
                command.Fill(LibTable1);

                // Отображаем данные
                BooksGrid.ItemsSource = LibTable1.DefaultView;
                //    using (SqlConnection connection = new SqlConnection(connectionString))
                //    {
                //        connection.Open();
                //        SqlCommand command = new SqlCommand(sqlExpression, connection);
                //        int number = command.ExecuteNonQuery();
                //        MessageBox.Show("Поиск");


                //        textBox5.Text += "Книга найдена" + Environment.NewLine;
                //    }
                //    UpdateDB();
                //}
                //catch (Exception ex)
                //{
                //    MessageBox.Show(ex.Message);
                //}
            }
        }

        private void Change_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                // $"INSERT INTO Books (UDK, Name,  Pages, Year, Date) VALUES ('{textBox2.Text}', '{textBox1.Text}', '{textBox4.Text}', '{textBox3.Text}' , '{dateTimePicker1.Text}')";
                if (textBox1.Text != "" || textBox2.Text != "" || textBox3.Text != "" || textBox4.Text != "" || dateTimePicker1.Text != "")
                {
                    string sqlExpression =
                        $"Update Books Set Name= '{textBox1.Text}', UDK='{textBox2.Text}', Pages='{textBox3.Text}', Year='{textBox4.Text}', Date='{dateTimePicker1.Text}' where Name='{BookSearch.Text}'";
                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        connection.Open();
                        SqlCommand command = new SqlCommand(sqlExpression, connection);
                        int number = command.ExecuteNonQuery();
                        MessageBox.Show("имя изменено");


                        textBox5.Text += "имя изменено" + Environment.NewLine;
                    }

                
                }

                UpdateDB();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}

























//static string info = "";
//string sqlExpAuthors = "";
//string sqlExpBooks = "";
//string sqlExpPubhouses = "";
//string sql1 = "SELECT * FROM Books";
//string sql2 = "SELECT * FROM Authors";
//string sql3 = "SELECT * FROM Pubhouses";
//SqlDataAdapter adapter;
//DataTable LibTable1 = new DataTable();
//DataTable LibTable2 = new DataTable();
//DataTable LibTable3 = new DataTable();


//string connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;

//public MainWindow()
//{
//InitializeComponent();
//textBox5.VerticalScrollBarVisibility = ScrollBarVisibility.Visible;
//using (SqlConnection connection = new SqlConnection(connectionString))
//{
//    connection.Open();
//    MessageBox.Show("Подключение открыто");
//    info += "\tСтрока подключения: " + connection.ConnectionString;
//    info += "\n\tБаза данных: " + connection.Database;
//    info += "\n\tСервер: " + connection.DataSource;
//    info += "\n\tВерсия сервера: " + connection.ServerVersion;
//    info += "\n\tСостояние: " + connection.State;
//    info += "\n\tWorkstationld: " + connection.WorkstationId;
//}


//using (SqlConnection connection = new SqlConnection(connectionString))
//{
//connection.Open();
//// Создаем объект DataAdapter
//SqlDataAdapter adapter1 = new SqlDataAdapter(sql1, connection);
//SqlDataAdapter adapter2 = new SqlDataAdapter(sql2, connection);
//SqlDataAdapter adapter3 = new SqlDataAdapter(sql3, connection);

//// Заполняем Dataset
//adapter1.Fill(LibTable1);
//adapter2.Fill(LibTable2);
//adapter3.Fill(LibTable3);

//// Отображаем данные
//BooksGrid.ItemsSource = LibTable1.DefaultView;
//AuthorsGrid.ItemsSource = LibTable2.DefaultView;
//PubGrid.ItemsSource = LibTable3.DefaultView;

//}
////ConnectWithDB().GetAwaiter();
//textBox5.Text += info;
//}




//}
//}