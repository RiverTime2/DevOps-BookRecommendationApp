using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;

namespace BookRecommendationApp
{
    public partial class DeleteBookForm : Form
    {
        public DeleteBookForm()
        {
            InitializeComponent();
        }

        private void DeleteBookForm_Load(object sender, EventArgs e)
        {
            // Здесь можно добавить код, который должен выполняться при загрузке формы.
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string title = txtTitle.Text;

            if (string.IsNullOrWhiteSpace(title))
            {
                MessageBox.Show("Пожалуйста, введите название книги.");
                return;
            }

            using (SQLiteConnection conn = new SQLiteConnection("Data Source=books.db"))
            {
                conn.Open();

                string query = "DELETE FROM Books WHERE Title = @Title";
                using (SQLiteCommand cmd = new SQLiteCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Title", title);

                    int rowsAffected = cmd.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Книга успешно удалена.");
                    }
                    else
                    {
                        MessageBox.Show("Книга не найдена.");
                    }
                }
            }
        }

        private void txtTitle_TextChanged(object sender, EventArgs e)
        {
            // Код для обработки изменения текста в txtTitle
        }

        private void NameBookDeleteLabel_Click(object sender, EventArgs e)
        {
            // Код для обработки клика по элементу NameBookDeleteLabel
        }
    }
}
