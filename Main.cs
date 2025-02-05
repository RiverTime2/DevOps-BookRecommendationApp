using System;
using System.Data;
using System.Data.SQLite;
using System.Windows.Forms;

namespace BookRecommendationApp
{

    public partial class Main : Form
    {
        private string connectionString = "Data Source=books.db;Version=3;";
        public Main()
        {
            InitializeComponent();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string title = txtTitle.Text;

            string connectionString = "Data Source=books.db;Version=3;";
            using (var connection = new SQLiteConnection(connectionString))
            {
                connection.Open();

                string searchQuery = "SELECT * FROM Books WHERE Title LIKE @title";
                var command = new SQLiteCommand(searchQuery, connection);
                command.Parameters.AddWithValue("@title", "%" + title + "%");

                using (var reader = command.ExecuteReader())
                {
                    listBoxResults.Items.Clear();
                    while (reader.Read())
                    {
                        string bookInfo = $"{reader["Title"]} автора {reader["Author"]} - Жанр: {reader["Genre"]}, Рейтинг: {reader["Rating"]}";
                        listBoxResults.Items.Add(bookInfo);
                    }
                }
            }
        }

        private void AddBook_Click(object sender, EventArgs e)
        {
            AddBook addBookForm = new AddBook();
            addBookForm.FormClosed += (s, args) => this.Show(); // Показываем Form1 после закрытия AddBook
            this.Hide(); // Скрываем Form1
            addBookForm.Show(); // Показываем форму AddBook


        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            using (var connection = new SQLiteConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT * FROM Books";
                using (var command = new SQLiteCommand(query, connection))
                {
                    using (var adapter = new SQLiteDataAdapter(command))
                    {
                        var dataTable = new DataTable();
                        adapter.Fill(dataTable);

                        dataGridView1.DataSource = dataTable; // Устанавливаем источник данных для DataGridView
                    }
                }
            }
        }


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // Проверка, что выбрана не строка заголовка
            {
                var cellValue = dataGridView1.Rows[e.RowIndex].Cells["Id"].Value;
                if (cellValue != null && int.TryParse(cellValue.ToString(), out int id))
                {
                    using (SQLiteConnection connection = new SQLiteConnection(connectionString))
                    {
                        connection.Open();
                        string query = "SELECT * FROM Books WHERE Id = @Id";
                        using (SQLiteCommand command = new SQLiteCommand(query, connection))
                        {
                            command.Parameters.AddWithValue("@Id", id);
                            using (SQLiteDataReader reader = command.ExecuteReader())
                            {
                                if (reader.Read())
                                {
                                    string title = reader["Title"]?.ToString() ?? "Неизвестно"; // Используйте оператор null-объединения
                                    MessageBox.Show("Название книги: " + title);
                                }
                            }
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Недействительный Id.");
                }
            }
        }

        private void txtTitle_TextChanged(object sender, EventArgs e)
        {

        }

        private void UpdateDataGridView_Click(object sender, EventArgs e)
        {
            LoadData(); // Обновляем данные в DataGridView
        }

        private void buttondRecommend_Click(object sender, EventArgs e)
        {
            RecommendationForm recommendationForm = new RecommendationForm();
            recommendationForm.FormClosed += (s, args) => this.Show(); // Показываем Main после закрытия Recommendation
            this.Hide(); // Скрываем Main
            recommendationForm.Show(); // Показываем форму Recommendation
        }

        private void buttonDeleteBookForm_Click(object sender, EventArgs e)
        {
            DeleteBookForm deletebookForm = new DeleteBookForm();
            deletebookForm.FormClosed += (s, args) => this.Show(); // Показываем Main после закрытия DeleteBookForm
            this.Hide(); // Скрываем Main
            deletebookForm.Show(); // Показываем форму DeleteBookForm

        }
    }
}



