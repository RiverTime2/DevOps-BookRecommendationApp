namespace BookRecommendationApp
{
    partial class RecommendationForm
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
            textBoxTitle = new TextBox();
            textBoxAuthor = new TextBox();
            textBoxGenre = new TextBox();
            textBoxRating = new TextBox();
            buttonRecommend = new Button();
            richTextBoxResults = new RichTextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            SuspendLayout();
            // 
            // textBoxTitle
            // 
            textBoxTitle.Location = new Point(303, 76);
            textBoxTitle.Name = "textBoxTitle";
            textBoxTitle.Size = new Size(342, 23);
            textBoxTitle.TabIndex = 0;
            // 
            // textBoxAuthor
            // 
            textBoxAuthor.Location = new Point(303, 147);
            textBoxAuthor.Name = "textBoxAuthor";
            textBoxAuthor.Size = new Size(342, 23);
            textBoxAuthor.TabIndex = 1;
            // 
            // textBoxGenre
            // 
            textBoxGenre.Location = new Point(303, 213);
            textBoxGenre.Name = "textBoxGenre";
            textBoxGenre.Size = new Size(342, 23);
            textBoxGenre.TabIndex = 2;
            // 
            // textBoxRating
            // 
            textBoxRating.Location = new Point(303, 286);
            textBoxRating.Name = "textBoxRating";
            textBoxRating.Size = new Size(342, 23);
            textBoxRating.TabIndex = 3;
            // 
            // buttonRecommend
            // 
            buttonRecommend.Location = new Point(381, 332);
            buttonRecommend.Name = "buttonRecommend";
            buttonRecommend.Size = new Size(206, 23);
            buttonRecommend.TabIndex = 4;
            buttonRecommend.Text = "Узнать рекомендуемые книги";
            buttonRecommend.UseVisualStyleBackColor = true;
            buttonRecommend.Click += buttonRecommend_Click;
            // 
            // richTextBoxResults
            // 
            richTextBoxResults.Location = new Point(328, 391);
            richTextBoxResults.Name = "richTextBoxResults";
            richTextBoxResults.Size = new Size(305, 96);
            richTextBoxResults.TabIndex = 5;
            richTextBoxResults.Text = "";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(401, 45);
            label1.Name = "label1";
            label1.Size = new Size(141, 15);
            label1.TabIndex = 6;
            label1.Text = "Какое название у книги?";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(418, 119);
            label2.Name = "label2";
            label2.Size = new Size(100, 15);
            label2.TabIndex = 7;
            label2.Text = "Кто автор книги?";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(381, 183);
            label3.Name = "label3";
            label3.Size = new Size(183, 15);
            label3.TabIndex = 8;
            label3.Text = "В каком жанре написана книга?";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(340, 256);
            label4.Name = "label4";
            label4.Size = new Size(282, 15);
            label4.TabIndex = 9;
            label4.Text = "Сколько рейтинг у книги по 5-ти бальной шкале?";
            label4.Click += label4_Click;
            // 
            // RecommendationForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(942, 548);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(richTextBoxResults);
            Controls.Add(buttonRecommend);
            Controls.Add(textBoxRating);
            Controls.Add(textBoxGenre);
            Controls.Add(textBoxAuthor);
            Controls.Add(textBoxTitle);
            Name = "RecommendationForm";
            Text = "Рекомендация книги";
            Load += RecommendationForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxTitle;
        private TextBox textBoxAuthor;
        private TextBox textBoxGenre;
        private TextBox textBoxRating;
        private Button buttonRecommend;
        private RichTextBox richTextBoxResults;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
    }
}