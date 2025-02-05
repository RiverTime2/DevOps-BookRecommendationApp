namespace BookRecommendationApp
{
    partial class AddBook
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            BookAdding = new Button();
            txtTitle = new TextBox();
            txtAuthor = new TextBox();
            txtRating = new TextBox();
            txtGenre = new TextBox();
            AuthorLabel = new Label();
            TitleLabel = new Label();
            GenreLabel = new Label();
            RatingLabel = new Label();
            SuspendLayout();
            // 
            // BookAdding
            // 
            BookAdding.Location = new Point(287, 257);
            BookAdding.Name = "BookAdding";
            BookAdding.Size = new Size(206, 23);
            BookAdding.TabIndex = 0;
            BookAdding.Text = "Добавить книгу";
            BookAdding.UseVisualStyleBackColor = true;
            BookAdding.Click += button1_Click;
            // 
            // txtTitle
            // 
            txtTitle.Location = new Point(74, 197);
            txtTitle.Name = "txtTitle";
            txtTitle.Size = new Size(100, 23);
            txtTitle.TabIndex = 1;
            txtTitle.TextChanged += txtTitle_TextChanged;
            // 
            // txtAuthor
            // 
            txtAuthor.Location = new Point(216, 197);
            txtAuthor.Name = "txtAuthor";
            txtAuthor.Size = new Size(100, 23);
            txtAuthor.TabIndex = 2;
            txtAuthor.TextChanged += txtAuthor_TextChanged;
            // 
            // txtRating
            // 
            txtRating.Location = new Point(489, 197);
            txtRating.Name = "txtRating";
            txtRating.Size = new Size(100, 23);
            txtRating.TabIndex = 3;
            txtRating.TextChanged += txtRating_TextChanged;
            // 
            // txtGenre
            // 
            txtGenre.Location = new Point(350, 197);
            txtGenre.Name = "txtGenre";
            txtGenre.Size = new Size(100, 23);
            txtGenre.TabIndex = 4;
            txtGenre.TextChanged += textBox4_TextChanged;
            // 
            // AuthorLabel
            // 
            AuthorLabel.AutoSize = true;
            AuthorLabel.Location = new Point(247, 165);
            AuthorLabel.Name = "AuthorLabel";
            AuthorLabel.Size = new Size(40, 15);
            AuthorLabel.TabIndex = 5;
            AuthorLabel.Text = "Автор";
            // 
            // TitleLabel
            // 
            TitleLabel.AutoSize = true;
            TitleLabel.Location = new Point(93, 165);
            TitleLabel.Name = "TitleLabel";
            TitleLabel.Size = new Size(59, 15);
            TitleLabel.TabIndex = 6;
            TitleLabel.Text = "Название";
            // 
            // GenreLabel
            // 
            GenreLabel.AutoSize = true;
            GenreLabel.Location = new Point(380, 165);
            GenreLabel.Name = "GenreLabel";
            GenreLabel.Size = new Size(38, 15);
            GenreLabel.TabIndex = 7;
            GenreLabel.Text = "Жанр";
            // 
            // RatingLabel
            // 
            RatingLabel.AutoSize = true;
            RatingLabel.Location = new Point(516, 165);
            RatingLabel.Name = "RatingLabel";
            RatingLabel.Size = new Size(51, 15);
            RatingLabel.TabIndex = 8;
            RatingLabel.Text = "Рейтинг";
            // 
            // AddBook
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(RatingLabel);
            Controls.Add(GenreLabel);
            Controls.Add(TitleLabel);
            Controls.Add(AuthorLabel);
            Controls.Add(txtGenre);
            Controls.Add(txtRating);
            Controls.Add(txtAuthor);
            Controls.Add(txtTitle);
            Controls.Add(BookAdding);
            Name = "AddBook";
            Text = "Добавление книги";
            Load += AddBook_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button BookAdding;
        private TextBox txtTitle;
        private TextBox txtAuthor;
        private TextBox txtRating;
        private TextBox txtGenre;
        private Label AuthorLabel;
        private Label TitleLabel;
        private Label GenreLabel;
        private Label RatingLabel;
    }
}