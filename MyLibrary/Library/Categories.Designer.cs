namespace Library
{
    partial class Categories
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Categories));
            this.GridCategories = new System.Windows.Forms.DataGridView();
            this.CategoryId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CategoryName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.labelCategoriesName = new System.Windows.Forms.Label();
            this.btnCategoriesCreate = new System.Windows.Forms.Button();
            this.textBoxCategoriesName = new System.Windows.Forms.TextBox();
            this.btnCatagoriesDelete = new System.Windows.Forms.Button();
            this.btnCategoriesReset = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.GridCategories)).BeginInit();
            this.SuspendLayout();
            // 
            // GridCategories
            // 
            this.GridCategories.AllowUserToAddRows = false;
            this.GridCategories.AllowUserToDeleteRows = false;
            this.GridCategories.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridCategories.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CategoryId,
            this.CategoryName});
            this.GridCategories.Location = new System.Drawing.Point(222, 12);
            this.GridCategories.Name = "GridCategories";
            this.GridCategories.ReadOnly = true;
            this.GridCategories.Size = new System.Drawing.Size(193, 102);
            this.GridCategories.TabIndex = 0;
            this.GridCategories.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.GridCategories_RowHeaderMouseClick);
            // 
            // CategoryId
            // 
            this.CategoryId.HeaderText = "Id";
            this.CategoryId.Name = "CategoryId";
            this.CategoryId.ReadOnly = true;
            this.CategoryId.Visible = false;
            // 
            // CategoryName
            // 
            this.CategoryName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.CategoryName.HeaderText = "Name";
            this.CategoryName.Name = "CategoryName";
            this.CategoryName.ReadOnly = true;
            // 
            // labelCategoriesName
            // 
            this.labelCategoriesName.AutoSize = true;
            this.labelCategoriesName.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCategoriesName.Location = new System.Drawing.Point(12, 9);
            this.labelCategoriesName.Name = "labelCategoriesName";
            this.labelCategoriesName.Size = new System.Drawing.Size(58, 24);
            this.labelCategoriesName.TabIndex = 6;
            this.labelCategoriesName.Text = "Name";
            // 
            // btnCategoriesCreate
            // 
            this.btnCategoriesCreate.Location = new System.Drawing.Point(16, 64);
            this.btnCategoriesCreate.Name = "btnCategoriesCreate";
            this.btnCategoriesCreate.Size = new System.Drawing.Size(200, 22);
            this.btnCategoriesCreate.TabIndex = 8;
            this.btnCategoriesCreate.Text = "Create";
            this.btnCategoriesCreate.UseVisualStyleBackColor = true;
            this.btnCategoriesCreate.Click += new System.EventHandler(this.BtnCategoriesCreate_Click);
            // 
            // textBoxCategoriesName
            // 
            this.textBoxCategoriesName.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxCategoriesName.Location = new System.Drawing.Point(16, 36);
            this.textBoxCategoriesName.Name = "textBoxCategoriesName";
            this.textBoxCategoriesName.Size = new System.Drawing.Size(200, 22);
            this.textBoxCategoriesName.TabIndex = 7;
            // 
            // btnCatagoriesDelete
            // 
            this.btnCatagoriesDelete.Enabled = false;
            this.btnCatagoriesDelete.Location = new System.Drawing.Point(16, 92);
            this.btnCatagoriesDelete.Name = "btnCatagoriesDelete";
            this.btnCatagoriesDelete.Size = new System.Drawing.Size(94, 22);
            this.btnCatagoriesDelete.TabIndex = 8;
            this.btnCatagoriesDelete.Text = "Delete";
            this.btnCatagoriesDelete.UseVisualStyleBackColor = true;
            this.btnCatagoriesDelete.Click += new System.EventHandler(this.BtnCatagoriesDelete_Click);
            // 
            // btnCategoriesReset
            // 
            this.btnCategoriesReset.Location = new System.Drawing.Point(122, 92);
            this.btnCategoriesReset.Name = "btnCategoriesReset";
            this.btnCategoriesReset.Size = new System.Drawing.Size(94, 22);
            this.btnCategoriesReset.TabIndex = 8;
            this.btnCategoriesReset.Text = "Reset";
            this.btnCategoriesReset.UseVisualStyleBackColor = true;
            this.btnCategoriesReset.Click += new System.EventHandler(this.BtnCategoriesReset_Click);
            // 
            // Categories
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(430, 126);
            this.Controls.Add(this.btnCategoriesReset);
            this.Controls.Add(this.btnCatagoriesDelete);
            this.Controls.Add(this.btnCategoriesCreate);
            this.Controls.Add(this.textBoxCategoriesName);
            this.Controls.Add(this.labelCategoriesName);
            this.Controls.Add(this.GridCategories);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Categories";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Categories";
            this.Load += new System.EventHandler(this.Categories_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GridCategories)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView GridCategories;
        private System.Windows.Forms.Label labelCategoriesName;
        private System.Windows.Forms.Button btnCategoriesCreate;
        private System.Windows.Forms.TextBox textBoxCategoriesName;
        private System.Windows.Forms.Button btnCatagoriesDelete;
        private System.Windows.Forms.Button btnCategoriesReset;
        private System.Windows.Forms.DataGridViewTextBoxColumn CategoryId;
        private System.Windows.Forms.DataGridViewTextBoxColumn CategoryName;
    }
}