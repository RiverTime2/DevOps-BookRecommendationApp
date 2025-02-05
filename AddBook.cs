using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookRecommendationApp
{
    public partial class AddBook : Form
    {
        public AddBook()
        {
            InitializeComponent();
        }

        private void AddBook_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Получаем данные из текстовых полей
            string title = txtTitle.Text;
            string author = txtAuthor.Text;
            string genre = txtGenre.Text;
            string rating = txtRating.Text;

            // Настраиваем строку подключения к базе данных

            string connectionString = "Data Source=books.db;Version=3;";

            using (var connection = new SQLiteConnection(connectionString))
            {
                connection.Open();

                // Запрос для вставки данных о книге
                string insertQuery = "INSERT INTO Books (Title, Author, Genre, Rating) VALUES (@title, @author, @genre, @rating)";
                using (var command = new SQLiteCommand(insertQuery, connection))
                {
                    // Добавляем параметры для запроса
                    command.Parameters.AddWithValue("@title", title);
                    command.Parameters.AddWithValue("@author", author);
                    command.Parameters.AddWithValue("@genre", genre);
                    command.Parameters.AddWithValue("@rating", rating);

                    // Выполняем запрос
                    command.ExecuteNonQuery();
                }
            }

            // Сообщаем пользователю о том, что книга была добавлена
            MessageBox.Show("Книга добавлена!");
            this.Close(); // Закрываем форму после добавления
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtRating_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtAuthor_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtTitle_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}