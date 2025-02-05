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
    public partial class RecommendationForm : Form
    {
        // Объявляем метки
        private Label TitleLabel;
        private Label AuthorLabel;
        private Label GenreLabel;
        private Label RatingLabel;
        public RecommendationForm()
        {
            InitializeComponent();


        }




        private void buttonRecommend_Click(object sender, EventArgs e)
        {
            string title = textBoxTitle.Text;
            string author = textBoxAuthor.Text;
            string genre = textBoxGenre.Text;
            string rating = textBoxRating.Text;

            List<string> recommendations = new List<string>();

            using (SQLiteConnection connection = new SQLiteConnection("Data Source=books.db;Version=3;"))
            {
                connection.Open();
                List<string> conditions = new List<string>();

                // Проверка других полей
                if (!string.IsNullOrWhiteSpace(title))
                    conditions.Add("Title LIKE @title");
                if (!string.IsNullOrWhiteSpace(author))
                    conditions.Add("Author LIKE @author");
                if (!string.IsNullOrWhiteSpace(genre))
                    conditions.Add("Genre LIKE @genre");

                double? ratingValue = null; // Используем nullable double

                // Проверка рейтинга
                if (!string.IsNullOrWhiteSpace(rating) && double.TryParse(rating, out double parsedRatingValue))
                {
                    ratingValue = parsedRatingValue; // Присваиваем значение только если успешно распарсили

                    if (ratingValue.Value % 1 != 0) // Если введенное значение не целое, используем точное значение
                    {
                        conditions.Add("Rating = @ratingValue");
                    }
                    else // Если введенное значение целое, ищем в диапазоне
                    {
                        if (ratingValue.Value >= 1 && ratingValue.Value < 2)
                        {
                            conditions.Add("Rating BETWEEN 1 AND 2");
                        }
                        else if (ratingValue.Value >= 2 && ratingValue.Value < 3)
                        {
                            conditions.Add("Rating BETWEEN 2 AND 3");
                        }
                        else if (ratingValue.Value >= 3 && ratingValue.Value < 4)
                        {
                            conditions.Add("Rating BETWEEN 3 AND 4");
                        }
                        else if (ratingValue.Value >= 4 && ratingValue.Value <= 5)
                        {
                            conditions.Add("Rating BETWEEN 4 AND 5");
                        }
                        else
                        {
                            // Для значений вне диапазона
                            MessageBox.Show("Пожалуйста, введите рейтинг между 1 и 5.");
                            return;
                        }
                    }
                }

                string query = "SELECT * FROM books";
                if (conditions.Count > 0)
                {
                    query += " WHERE " + string.Join(" AND ", conditions);
                }

                using (SQLiteCommand command = new SQLiteCommand(query, connection))
                {
                    if (conditions.Contains("Title LIKE @title"))
                        command.Parameters.AddWithValue("@title", $"%{title}%");
                    if (conditions.Contains("Author LIKE @author"))
                        command.Parameters.AddWithValue("@author", $"%{author}%");
                    if (conditions.Contains("Genre LIKE @genre"))
                        command.Parameters.AddWithValue("@genre", $"%{genre}%");

                    // Добавляем параметр рейтинга только если он успешно распаршен
                    if (ratingValue.HasValue)
                        command.Parameters.AddWithValue("@ratingValue", ratingValue.Value);

                    using (SQLiteDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string bookInfo = $"Название: {reader["Title"]}, Автор: {reader["Author"]}, Жанр: {reader["Genre"]}, Рейтинг: {reader["Rating"]}";
                            recommendations.Add(bookInfo);
                        }
                    }
                }
            }

            richTextBoxResults.Clear();
            foreach (string recommendation in recommendations)
            {
                richTextBoxResults.AppendText(recommendation + Environment.NewLine);
            }
        }



        private void RecommendationForm_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
