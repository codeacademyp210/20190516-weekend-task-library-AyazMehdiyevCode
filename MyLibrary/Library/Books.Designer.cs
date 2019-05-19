namespace Library
{
    partial class Books
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Books));
            this.btnBooksReset = new System.Windows.Forms.Button();
            this.btnBooksDelete = new System.Windows.Forms.Button();
            this.btnBooksCreate = new System.Windows.Forms.Button();
            this.textBoxBooksPrice = new System.Windows.Forms.TextBox();
            this.textBoxBooksName = new System.Windows.Forms.TextBox();
            this.labelBooksCategory = new System.Windows.Forms.Label();
            this.labelBooksPrice = new System.Windows.Forms.Label();
            this.labelBooksAuthors = new System.Windows.Forms.Label();
            this.labelBooksName = new System.Windows.Forms.Label();
            this.GridBooks = new System.Windows.Forms.DataGridView();
            this.BookId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BookName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AuthorName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BookPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BookCategory = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BookCount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.comboBoxBooksAuthors = new System.Windows.Forms.ComboBox();
            this.comboBoxBooksCategory = new System.Windows.Forms.ComboBox();
            this.btnShowAutorsForm = new System.Windows.Forms.Button();
            this.btnShowCategoryForm = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.GridBooks)).BeginInit();
            this.SuspendLayout();
            // 
            // btnBooksReset
            // 
            this.btnBooksReset.Location = new System.Drawing.Point(122, 263);
            this.btnBooksReset.Name = "btnBooksReset";
            this.btnBooksReset.Size = new System.Drawing.Size(94, 22);
            this.btnBooksReset.TabIndex = 32;
            this.btnBooksReset.Text = "Reset";
            this.btnBooksReset.UseVisualStyleBackColor = true;
            this.btnBooksReset.Click += new System.EventHandler(this.BtnBooksReset_Click);
            // 
            // btnBooksDelete
            // 
            this.btnBooksDelete.Enabled = false;
            this.btnBooksDelete.Location = new System.Drawing.Point(16, 262);
            this.btnBooksDelete.Name = "btnBooksDelete";
            this.btnBooksDelete.Size = new System.Drawing.Size(94, 22);
            this.btnBooksDelete.TabIndex = 33;
            this.btnBooksDelete.Text = "Delete";
            this.btnBooksDelete.UseVisualStyleBackColor = true;
            this.btnBooksDelete.Click += new System.EventHandler(this.BtnBooksDelete_Click);
            // 
            // btnBooksCreate
            // 
            this.btnBooksCreate.Location = new System.Drawing.Point(16, 235);
            this.btnBooksCreate.Name = "btnBooksCreate";
            this.btnBooksCreate.Size = new System.Drawing.Size(200, 22);
            this.btnBooksCreate.TabIndex = 34;
            this.btnBooksCreate.Text = "Create";
            this.btnBooksCreate.UseVisualStyleBackColor = true;
            this.btnBooksCreate.Click += new System.EventHandler(this.BtnBooksCreate_Click);
            // 
            // textBoxBooksPrice
            // 
            this.textBoxBooksPrice.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxBooksPrice.Location = new System.Drawing.Point(16, 151);
            this.textBoxBooksPrice.Name = "textBoxBooksPrice";
            this.textBoxBooksPrice.Size = new System.Drawing.Size(200, 22);
            this.textBoxBooksPrice.TabIndex = 29;
            // 
            // textBoxBooksName
            // 
            this.textBoxBooksName.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxBooksName.Location = new System.Drawing.Point(16, 38);
            this.textBoxBooksName.Name = "textBoxBooksName";
            this.textBoxBooksName.Size = new System.Drawing.Size(200, 22);
            this.textBoxBooksName.TabIndex = 31;
            // 
            // labelBooksCategory
            // 
            this.labelBooksCategory.AutoSize = true;
            this.labelBooksCategory.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBooksCategory.Location = new System.Drawing.Point(12, 178);
            this.labelBooksCategory.Name = "labelBooksCategory";
            this.labelBooksCategory.Size = new System.Drawing.Size(106, 24);
            this.labelBooksCategory.TabIndex = 24;
            this.labelBooksCategory.Text = "Category";
            // 
            // labelBooksPrice
            // 
            this.labelBooksPrice.AutoSize = true;
            this.labelBooksPrice.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBooksPrice.Location = new System.Drawing.Point(12, 122);
            this.labelBooksPrice.Name = "labelBooksPrice";
            this.labelBooksPrice.Size = new System.Drawing.Size(70, 24);
            this.labelBooksPrice.TabIndex = 25;
            this.labelBooksPrice.Text = "Price";
            // 
            // labelBooksAuthors
            // 
            this.labelBooksAuthors.AutoSize = true;
            this.labelBooksAuthors.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBooksAuthors.Location = new System.Drawing.Point(12, 65);
            this.labelBooksAuthors.Name = "labelBooksAuthors";
            this.labelBooksAuthors.Size = new System.Drawing.Size(82, 24);
            this.labelBooksAuthors.TabIndex = 26;
            this.labelBooksAuthors.Text = "Author";
            // 
            // labelBooksName
            // 
            this.labelBooksName.AutoSize = true;
            this.labelBooksName.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBooksName.Location = new System.Drawing.Point(12, 9);
            this.labelBooksName.Name = "labelBooksName";
            this.labelBooksName.Size = new System.Drawing.Size(58, 24);
            this.labelBooksName.TabIndex = 27;
            this.labelBooksName.Text = "Name";
            // 
            // GridBooks
            // 
            this.GridBooks.AllowUserToAddRows = false;
            this.GridBooks.AllowUserToDeleteRows = false;
            this.GridBooks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridBooks.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.BookId,
            this.BookName,
            this.AuthorName,
            this.BookPrice,
            this.BookCategory,
            this.BookCount});
            this.GridBooks.Location = new System.Drawing.Point(225, 12);
            this.GridBooks.Name = "GridBooks";
            this.GridBooks.ReadOnly = true;
            this.GridBooks.Size = new System.Drawing.Size(563, 272);
            this.GridBooks.TabIndex = 23;
            this.GridBooks.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.GridBooks_RowHeaderMouseDoubleClick);
            // 
            // BookId
            // 
            this.BookId.HeaderText = "Id";
            this.BookId.Name = "BookId";
            this.BookId.ReadOnly = true;
            this.BookId.Visible = false;
            // 
            // BookName
            // 
            this.BookName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.BookName.HeaderText = "Name";
            this.BookName.Name = "BookName";
            this.BookName.ReadOnly = true;
            // 
            // AuthorName
            // 
            this.AuthorName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.AuthorName.HeaderText = "Author";
            this.AuthorName.Name = "AuthorName";
            this.AuthorName.ReadOnly = true;
            // 
            // BookPrice
            // 
            this.BookPrice.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.BookPrice.HeaderText = "Price";
            this.BookPrice.Name = "BookPrice";
            this.BookPrice.ReadOnly = true;
            // 
            // BookCategory
            // 
            this.BookCategory.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.BookCategory.HeaderText = "Category";
            this.BookCategory.Name = "BookCategory";
            this.BookCategory.ReadOnly = true;
            // 
            // BookCount
            // 
            this.BookCount.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.BookCount.HeaderText = "Count";
            this.BookCount.Name = "BookCount";
            this.BookCount.ReadOnly = true;
            // 
            // comboBoxBooksAuthors
            // 
            this.comboBoxBooksAuthors.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxBooksAuthors.FormattingEnabled = true;
            this.comboBoxBooksAuthors.Location = new System.Drawing.Point(16, 94);
            this.comboBoxBooksAuthors.Name = "comboBoxBooksAuthors";
            this.comboBoxBooksAuthors.Size = new System.Drawing.Size(167, 23);
            this.comboBoxBooksAuthors.TabIndex = 35;
            // 
            // comboBoxBooksCategory
            // 
            this.comboBoxBooksCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxBooksCategory.FormattingEnabled = true;
            this.comboBoxBooksCategory.Location = new System.Drawing.Point(16, 207);
            this.comboBoxBooksCategory.Name = "comboBoxBooksCategory";
            this.comboBoxBooksCategory.Size = new System.Drawing.Size(167, 23);
            this.comboBoxBooksCategory.TabIndex = 35;
            // 
            // btnShowAutorsForm
            // 
            this.btnShowAutorsForm.Location = new System.Drawing.Point(189, 94);
            this.btnShowAutorsForm.Name = "btnShowAutorsForm";
            this.btnShowAutorsForm.Size = new System.Drawing.Size(26, 23);
            this.btnShowAutorsForm.TabIndex = 36;
            this.btnShowAutorsForm.Text = "...";
            this.btnShowAutorsForm.UseVisualStyleBackColor = true;
            this.btnShowAutorsForm.Click += new System.EventHandler(this.BtnShowAutorsForm_Click);
            // 
            // btnShowCategoryForm
            // 
            this.btnShowCategoryForm.Location = new System.Drawing.Point(189, 207);
            this.btnShowCategoryForm.Name = "btnShowCategoryForm";
            this.btnShowCategoryForm.Size = new System.Drawing.Size(26, 23);
            this.btnShowCategoryForm.TabIndex = 36;
            this.btnShowCategoryForm.Text = "...";
            this.btnShowCategoryForm.UseVisualStyleBackColor = true;
            this.btnShowCategoryForm.Click += new System.EventHandler(this.BtnShowCategoryForm_Click);
            // 
            // Books
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 301);
            this.Controls.Add(this.btnShowCategoryForm);
            this.Controls.Add(this.btnShowAutorsForm);
            this.Controls.Add(this.comboBoxBooksCategory);
            this.Controls.Add(this.comboBoxBooksAuthors);
            this.Controls.Add(this.btnBooksReset);
            this.Controls.Add(this.btnBooksDelete);
            this.Controls.Add(this.btnBooksCreate);
            this.Controls.Add(this.textBoxBooksPrice);
            this.Controls.Add(this.textBoxBooksName);
            this.Controls.Add(this.labelBooksCategory);
            this.Controls.Add(this.labelBooksPrice);
            this.Controls.Add(this.labelBooksAuthors);
            this.Controls.Add(this.labelBooksName);
            this.Controls.Add(this.GridBooks);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Books";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Books";
            this.Activated += new System.EventHandler(this.Books_Activated);
            this.Load += new System.EventHandler(this.Books_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GridBooks)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBooksReset;
        private System.Windows.Forms.Button btnBooksDelete;
        private System.Windows.Forms.Button btnBooksCreate;
        private System.Windows.Forms.TextBox textBoxBooksPrice;
        private System.Windows.Forms.TextBox textBoxBooksName;
        private System.Windows.Forms.Label labelBooksCategory;
        private System.Windows.Forms.Label labelBooksPrice;
        private System.Windows.Forms.Label labelBooksAuthors;
        private System.Windows.Forms.Label labelBooksName;
        private System.Windows.Forms.DataGridView GridBooks;
        private System.Windows.Forms.ComboBox comboBoxBooksAuthors;
        private System.Windows.Forms.ComboBox comboBoxBooksCategory;
        private System.Windows.Forms.DataGridViewTextBoxColumn BookId;
        private System.Windows.Forms.DataGridViewTextBoxColumn BookName;
        private System.Windows.Forms.DataGridViewTextBoxColumn AuthorName;
        private System.Windows.Forms.DataGridViewTextBoxColumn BookPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn BookCategory;
        private System.Windows.Forms.DataGridViewTextBoxColumn BookCount;
        private System.Windows.Forms.Button btnShowAutorsForm;
        private System.Windows.Forms.Button btnShowCategoryForm;
    }
}