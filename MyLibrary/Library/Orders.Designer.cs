namespace Library
{
    partial class Orders
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Orders));
            this.btnSearchOrders = new System.Windows.Forms.Button();
            this.textBoxSearchOrders = new System.Windows.Forms.TextBox();
            this.labelOrdersOrder = new System.Windows.Forms.Label();
            this.GridOrder = new System.Windows.Forms.DataGridView();
            this.OrderId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OrderClientFullName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OrderBookName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OrderDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OrderReturnDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.GridOrder)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSearchOrders
            // 
            this.btnSearchOrders.Location = new System.Drawing.Point(566, 11);
            this.btnSearchOrders.Name = "btnSearchOrders";
            this.btnSearchOrders.Size = new System.Drawing.Size(75, 22);
            this.btnSearchOrders.TabIndex = 6;
            this.btnSearchOrders.Text = "Search";
            this.btnSearchOrders.UseVisualStyleBackColor = true;
            // 
            // textBoxSearchOrders
            // 
            this.textBoxSearchOrders.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxSearchOrders.Location = new System.Drawing.Point(319, 11);
            this.textBoxSearchOrders.Name = "textBoxSearchOrders";
            this.textBoxSearchOrders.Size = new System.Drawing.Size(241, 22);
            this.textBoxSearchOrders.TabIndex = 5;
            // 
            // labelOrdersOrder
            // 
            this.labelOrdersOrder.AutoSize = true;
            this.labelOrdersOrder.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelOrdersOrder.Location = new System.Drawing.Point(12, 9);
            this.labelOrdersOrder.Name = "labelOrdersOrder";
            this.labelOrdersOrder.Size = new System.Drawing.Size(82, 24);
            this.labelOrdersOrder.TabIndex = 4;
            this.labelOrdersOrder.Text = "Orders";
            // 
            // GridOrder
            // 
            this.GridOrder.AllowUserToAddRows = false;
            this.GridOrder.AllowUserToDeleteRows = false;
            this.GridOrder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridOrder.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.OrderId,
            this.OrderClientFullName,
            this.OrderBookName,
            this.OrderDate,
            this.OrderReturnDate});
            this.GridOrder.Location = new System.Drawing.Point(16, 39);
            this.GridOrder.Name = "GridOrder";
            this.GridOrder.ReadOnly = true;
            this.GridOrder.Size = new System.Drawing.Size(625, 258);
            this.GridOrder.TabIndex = 16;
            // 
            // OrderId
            // 
            this.OrderId.HeaderText = "Id";
            this.OrderId.Name = "OrderId";
            this.OrderId.ReadOnly = true;
            this.OrderId.Visible = false;
            // 
            // OrderClientFullName
            // 
            this.OrderClientFullName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.OrderClientFullName.HeaderText = "Client FullName";
            this.OrderClientFullName.Name = "OrderClientFullName";
            this.OrderClientFullName.ReadOnly = true;
            // 
            // OrderBookName
            // 
            this.OrderBookName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.OrderBookName.HeaderText = "Book Name";
            this.OrderBookName.Name = "OrderBookName";
            this.OrderBookName.ReadOnly = true;
            // 
            // OrderDate
            // 
            this.OrderDate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.OrderDate.HeaderText = "Order Date";
            this.OrderDate.Name = "OrderDate";
            this.OrderDate.ReadOnly = true;
            // 
            // OrderReturnDate
            // 
            this.OrderReturnDate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.OrderReturnDate.HeaderText = "Return Date";
            this.OrderReturnDate.Name = "OrderReturnDate";
            this.OrderReturnDate.ReadOnly = true;
            // 
            // Orders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(656, 312);
            this.Controls.Add(this.GridOrder);
            this.Controls.Add(this.btnSearchOrders);
            this.Controls.Add(this.textBoxSearchOrders);
            this.Controls.Add(this.labelOrdersOrder);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Orders";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Orders";
            ((System.ComponentModel.ISupportInitialize)(this.GridOrder)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSearchOrders;
        private System.Windows.Forms.TextBox textBoxSearchOrders;
        private System.Windows.Forms.Label labelOrdersOrder;
        private System.Windows.Forms.DataGridView GridOrder;
        private System.Windows.Forms.DataGridViewTextBoxColumn OrderId;
        private System.Windows.Forms.DataGridViewTextBoxColumn OrderClientFullName;
        private System.Windows.Forms.DataGridViewTextBoxColumn OrderBookName;
        private System.Windows.Forms.DataGridViewTextBoxColumn OrderDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn OrderReturnDate;
    }
}