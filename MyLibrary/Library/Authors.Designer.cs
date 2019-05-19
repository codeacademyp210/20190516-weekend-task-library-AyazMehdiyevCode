namespace Library
{
    partial class Authors
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Authors));
            this.btnAuthorsReset = new System.Windows.Forms.Button();
            this.btnAuthorsDelete = new System.Windows.Forms.Button();
            this.btnAuthorsCreate = new System.Windows.Forms.Button();
            this.textBoxAuthorsName = new System.Windows.Forms.TextBox();
            this.labelAuthorsName = new System.Windows.Forms.Label();
            this.GridAuthors = new System.Windows.Forms.DataGridView();
            this.AuthorId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AuthorName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AuthorSurname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.labelAuthorsSurname = new System.Windows.Forms.Label();
            this.textBoxAuthorsSurname = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.GridAuthors)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAuthorsReset
            // 
            this.btnAuthorsReset.Location = new System.Drawing.Point(122, 144);
            this.btnAuthorsReset.Name = "btnAuthorsReset";
            this.btnAuthorsReset.Size = new System.Drawing.Size(94, 22);
            this.btnAuthorsReset.TabIndex = 12;
            this.btnAuthorsReset.Text = "Reset";
            this.btnAuthorsReset.UseVisualStyleBackColor = true;
            this.btnAuthorsReset.Click += new System.EventHandler(this.BtnAuthorsReset_Click);
            // 
            // btnAuthorsDelete
            // 
            this.btnAuthorsDelete.Enabled = false;
            this.btnAuthorsDelete.Location = new System.Drawing.Point(16, 144);
            this.btnAuthorsDelete.Name = "btnAuthorsDelete";
            this.btnAuthorsDelete.Size = new System.Drawing.Size(94, 22);
            this.btnAuthorsDelete.TabIndex = 13;
            this.btnAuthorsDelete.Text = "Delete";
            this.btnAuthorsDelete.UseVisualStyleBackColor = true;
            this.btnAuthorsDelete.Click += new System.EventHandler(this.BtnAuthorsDelete_Click);
            // 
            // btnAuthorsCreate
            // 
            this.btnAuthorsCreate.Location = new System.Drawing.Point(16, 116);
            this.btnAuthorsCreate.Name = "btnAuthorsCreate";
            this.btnAuthorsCreate.Size = new System.Drawing.Size(200, 22);
            this.btnAuthorsCreate.TabIndex = 14;
            this.btnAuthorsCreate.Text = "Create";
            this.btnAuthorsCreate.UseVisualStyleBackColor = true;
            this.btnAuthorsCreate.Click += new System.EventHandler(this.BtnAuthorsCreate_Click);
            // 
            // textBoxAuthorsName
            // 
            this.textBoxAuthorsName.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxAuthorsName.Location = new System.Drawing.Point(16, 36);
            this.textBoxAuthorsName.Name = "textBoxAuthorsName";
            this.textBoxAuthorsName.Size = new System.Drawing.Size(200, 22);
            this.textBoxAuthorsName.TabIndex = 11;
            // 
            // labelAuthorsName
            // 
            this.labelAuthorsName.AutoSize = true;
            this.labelAuthorsName.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAuthorsName.Location = new System.Drawing.Point(12, 9);
            this.labelAuthorsName.Name = "labelAuthorsName";
            this.labelAuthorsName.Size = new System.Drawing.Size(58, 24);
            this.labelAuthorsName.TabIndex = 10;
            this.labelAuthorsName.Text = "Name";
            // 
            // GridAuthors
            // 
            this.GridAuthors.AllowUserToAddRows = false;
            this.GridAuthors.AllowUserToDeleteRows = false;
            this.GridAuthors.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridAuthors.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.AuthorId,
            this.AuthorName,
            this.AuthorSurname});
            this.GridAuthors.Location = new System.Drawing.Point(225, 12);
            this.GridAuthors.Name = "GridAuthors";
            this.GridAuthors.ReadOnly = true;
            this.GridAuthors.Size = new System.Drawing.Size(293, 154);
            this.GridAuthors.TabIndex = 9;
            this.GridAuthors.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.GridAuthors_RowHeaderMouseDoubleClick);
            // 
            // AuthorId
            // 
            this.AuthorId.HeaderText = "Id";
            this.AuthorId.Name = "AuthorId";
            this.AuthorId.ReadOnly = true;
            this.AuthorId.Visible = false;
            // 
            // AuthorName
            // 
            this.AuthorName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.AuthorName.HeaderText = "Name";
            this.AuthorName.Name = "AuthorName";
            this.AuthorName.ReadOnly = true;
            // 
            // AuthorSurname
            // 
            this.AuthorSurname.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.AuthorSurname.HeaderText = "Surname";
            this.AuthorSurname.Name = "AuthorSurname";
            this.AuthorSurname.ReadOnly = true;
            // 
            // labelAuthorsSurname
            // 
            this.labelAuthorsSurname.AutoSize = true;
            this.labelAuthorsSurname.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAuthorsSurname.Location = new System.Drawing.Point(12, 61);
            this.labelAuthorsSurname.Name = "labelAuthorsSurname";
            this.labelAuthorsSurname.Size = new System.Drawing.Size(94, 24);
            this.labelAuthorsSurname.TabIndex = 10;
            this.labelAuthorsSurname.Text = "Surname";
            // 
            // textBoxAuthorsSurname
            // 
            this.textBoxAuthorsSurname.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxAuthorsSurname.Location = new System.Drawing.Point(16, 88);
            this.textBoxAuthorsSurname.Name = "textBoxAuthorsSurname";
            this.textBoxAuthorsSurname.Size = new System.Drawing.Size(200, 22);
            this.textBoxAuthorsSurname.TabIndex = 11;
            // 
            // Authors
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(530, 179);
            this.Controls.Add(this.btnAuthorsReset);
            this.Controls.Add(this.btnAuthorsDelete);
            this.Controls.Add(this.btnAuthorsCreate);
            this.Controls.Add(this.textBoxAuthorsSurname);
            this.Controls.Add(this.textBoxAuthorsName);
            this.Controls.Add(this.labelAuthorsSurname);
            this.Controls.Add(this.labelAuthorsName);
            this.Controls.Add(this.GridAuthors);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Authors";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Authors";
            this.Load += new System.EventHandler(this.Authors_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GridAuthors)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAuthorsReset;
        private System.Windows.Forms.Button btnAuthorsDelete;
        private System.Windows.Forms.Button btnAuthorsCreate;
        private System.Windows.Forms.TextBox textBoxAuthorsName;
        private System.Windows.Forms.Label labelAuthorsName;
        private System.Windows.Forms.DataGridView GridAuthors;
        private System.Windows.Forms.Label labelAuthorsSurname;
        private System.Windows.Forms.TextBox textBoxAuthorsSurname;
        private System.Windows.Forms.DataGridViewTextBoxColumn AuthorId;
        private System.Windows.Forms.DataGridViewTextBoxColumn AuthorName;
        private System.Windows.Forms.DataGridViewTextBoxColumn AuthorSurname;
    }
}