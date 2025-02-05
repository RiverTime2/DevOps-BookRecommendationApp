namespace BookRecommendationApp
{
    partial class DeleteBookForm
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
            txtTitle = new TextBox();
            btnDelete = new Button();
            NameBookDeleteLabel = new Label();
            SuspendLayout();
            // 
            // txtTitle
            // 
            txtTitle.Location = new Point(201, 186);
            txtTitle.Name = "txtTitle";
            txtTitle.Size = new Size(394, 23);
            txtTitle.TabIndex = 0;
            txtTitle.TextChanged += txtTitle_TextChanged;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(302, 228);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(187, 23);
            btnDelete.TabIndex = 1;
            btnDelete.Text = "Удалить книгу";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // NameBookDeleteLabel
            // 
            NameBookDeleteLabel.AutoSize = true;
            NameBookDeleteLabel.Location = new Point(258, 144);
            NameBookDeleteLabel.Name = "NameBookDeleteLabel";
            NameBookDeleteLabel.Size = new Size(298, 15);
            NameBookDeleteLabel.TabIndex = 2;
            NameBookDeleteLabel.Text = "Введите название книги, которую вы хотите удалить:";
            NameBookDeleteLabel.Click += NameBookDeleteLabel_Click;
            // 
            // DeleteBookForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(NameBookDeleteLabel);
            Controls.Add(btnDelete);
            Controls.Add(txtTitle);
            Name = "DeleteBookForm";
            Text = "Form1";
            Load += DeleteBookForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtTitle;
        private Button btnDelete;
        private Label NameBookDeleteLabel;
    }
}