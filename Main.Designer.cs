namespace BookRecommendationApp
{
    partial class Main
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtTitle = new TextBox();
            FindBook = new Button();
            listBoxResults = new ListBox();
            AddBook = new Button();
            dataGridView1 = new DataGridView();
            UpdateDataGridView = new Button();
            buttondRecommend = new Button();
            buttonDeleteBookForm = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // txtTitle
            // 
            txtTitle.Location = new Point(278, 239);
            txtTitle.Name = "txtTitle";
            txtTitle.Size = new Size(100, 23);
            txtTitle.TabIndex = 0;
            txtTitle.TextChanged += txtTitle_TextChanged;
            // 
            // FindBook
            // 
            FindBook.Location = new Point(406, 238);
            FindBook.Name = "FindBook";
            FindBook.Size = new Size(112, 23);
            FindBook.TabIndex = 1;
            FindBook.Text = "Найти книгу";
            FindBook.UseVisualStyleBackColor = true;
            FindBook.Click += button1_Click;
            // 
            // listBoxResults
            // 
            listBoxResults.FormattingEnabled = true;
            listBoxResults.ItemHeight = 15;
            listBoxResults.Location = new Point(12, 277);
            listBoxResults.Name = "listBoxResults";
            listBoxResults.Size = new Size(752, 34);
            listBoxResults.TabIndex = 2;
            // 
            // AddBook
            // 
            AddBook.Location = new Point(12, 12);
            AddBook.Name = "AddBook";
            AddBook.Size = new Size(148, 23);
            AddBook.TabIndex = 3;
            AddBook.Text = "Добавление книги";
            AddBook.UseVisualStyleBackColor = true;
            AddBook.Click += AddBook_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AllowUserToResizeColumns = false;
            dataGridView1.AllowUserToResizeRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(278, 23);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(240, 150);
            dataGridView1.TabIndex = 4;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // UpdateDataGridView
            // 
            UpdateDataGridView.Location = new Point(307, 193);
            UpdateDataGridView.Name = "UpdateDataGridView";
            UpdateDataGridView.Size = new Size(156, 23);
            UpdateDataGridView.TabIndex = 5;
            UpdateDataGridView.Text = "Обновить базу данных";
            UpdateDataGridView.UseVisualStyleBackColor = true;
            UpdateDataGridView.Click += UpdateDataGridView_Click;
            // 
            // buttondRecommend
            // 
            buttondRecommend.Location = new Point(12, 72);
            buttondRecommend.Name = "buttondRecommend";
            buttondRecommend.Size = new Size(148, 23);
            buttondRecommend.TabIndex = 6;
            buttondRecommend.Text = "Рекоммендация книги";
            buttondRecommend.UseVisualStyleBackColor = true;
            buttondRecommend.Click += buttondRecommend_Click;
            // 
            // buttonDeleteBookForm
            // 
            buttonDeleteBookForm.Location = new Point(12, 119);
            buttonDeleteBookForm.Name = "buttonDeleteBookForm";
            buttonDeleteBookForm.Size = new Size(148, 23);
            buttonDeleteBookForm.TabIndex = 7;
            buttonDeleteBookForm.Text = "Удаление книги";
            buttonDeleteBookForm.UseVisualStyleBackColor = true;
            buttonDeleteBookForm.Click += buttonDeleteBookForm_Click;
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonDeleteBookForm);
            Controls.Add(buttondRecommend);
            Controls.Add(UpdateDataGridView);
            Controls.Add(dataGridView1);
            Controls.Add(AddBook);
            Controls.Add(listBoxResults);
            Controls.Add(FindBook);
            Controls.Add(txtTitle);
            Name = "Main";
            Text = "Выбор книги";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtTitle;
        private Button FindBook;
        private ListBox listBoxResults;
        private Button AddBook;
        private DataGridView dataGridView1;
        private Button UpdateDataGridView;
        private Button buttondRecommend;
        private Button buttonDeleteBookForm;
    }
}