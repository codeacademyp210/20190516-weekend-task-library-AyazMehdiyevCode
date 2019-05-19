namespace Library
{
    partial class Clients
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Clients));
            this.btnClientsReset = new System.Windows.Forms.Button();
            this.btnClientsDelete = new System.Windows.Forms.Button();
            this.btnClientsCreate = new System.Windows.Forms.Button();
            this.textBoxClientsSurname = new System.Windows.Forms.TextBox();
            this.textBoxClientsName = new System.Windows.Forms.TextBox();
            this.labelClientsSurname = new System.Windows.Forms.Label();
            this.labelClientsName = new System.Windows.Forms.Label();
            this.GridClients = new System.Windows.Forms.DataGridView();
            this.ClientId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClientName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClientSurname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClientPhone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClientEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StatusClient = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.labelClientsEmail = new System.Windows.Forms.Label();
            this.textBoxClientsEmail = new System.Windows.Forms.TextBox();
            this.labelClientsPhone = new System.Windows.Forms.Label();
            this.textBoxClientsPhone = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.GridClients)).BeginInit();
            this.SuspendLayout();
            // 
            // btnClientsReset
            // 
            this.btnClientsReset.Location = new System.Drawing.Point(122, 248);
            this.btnClientsReset.Name = "btnClientsReset";
            this.btnClientsReset.Size = new System.Drawing.Size(94, 22);
            this.btnClientsReset.TabIndex = 20;
            this.btnClientsReset.Text = "Reset";
            this.btnClientsReset.UseVisualStyleBackColor = true;
            this.btnClientsReset.Click += new System.EventHandler(this.BtnClientsReset_Click);
            // 
            // btnClientsDelete
            // 
            this.btnClientsDelete.Enabled = false;
            this.btnClientsDelete.Location = new System.Drawing.Point(16, 248);
            this.btnClientsDelete.Name = "btnClientsDelete";
            this.btnClientsDelete.Size = new System.Drawing.Size(94, 22);
            this.btnClientsDelete.TabIndex = 21;
            this.btnClientsDelete.Text = "Delete";
            this.btnClientsDelete.UseVisualStyleBackColor = true;
            this.btnClientsDelete.Click += new System.EventHandler(this.BtnClientsDelete_Click);
            // 
            // btnClientsCreate
            // 
            this.btnClientsCreate.Location = new System.Drawing.Point(16, 220);
            this.btnClientsCreate.Name = "btnClientsCreate";
            this.btnClientsCreate.Size = new System.Drawing.Size(200, 22);
            this.btnClientsCreate.TabIndex = 22;
            this.btnClientsCreate.Text = "Create";
            this.btnClientsCreate.UseVisualStyleBackColor = true;
            this.btnClientsCreate.Click += new System.EventHandler(this.BtnClientsCreate_Click);
            // 
            // textBoxClientsSurname
            // 
            this.textBoxClientsSurname.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxClientsSurname.Location = new System.Drawing.Point(16, 88);
            this.textBoxClientsSurname.Name = "textBoxClientsSurname";
            this.textBoxClientsSurname.Size = new System.Drawing.Size(200, 22);
            this.textBoxClientsSurname.TabIndex = 18;
            // 
            // textBoxClientsName
            // 
            this.textBoxClientsName.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxClientsName.Location = new System.Drawing.Point(16, 36);
            this.textBoxClientsName.Name = "textBoxClientsName";
            this.textBoxClientsName.Size = new System.Drawing.Size(200, 22);
            this.textBoxClientsName.TabIndex = 19;
            // 
            // labelClientsSurname
            // 
            this.labelClientsSurname.AutoSize = true;
            this.labelClientsSurname.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelClientsSurname.Location = new System.Drawing.Point(12, 61);
            this.labelClientsSurname.Name = "labelClientsSurname";
            this.labelClientsSurname.Size = new System.Drawing.Size(94, 24);
            this.labelClientsSurname.TabIndex = 16;
            this.labelClientsSurname.Text = "Surname";
            // 
            // labelClientsName
            // 
            this.labelClientsName.AutoSize = true;
            this.labelClientsName.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelClientsName.Location = new System.Drawing.Point(12, 9);
            this.labelClientsName.Name = "labelClientsName";
            this.labelClientsName.Size = new System.Drawing.Size(58, 24);
            this.labelClientsName.TabIndex = 17;
            this.labelClientsName.Text = "Name";
            // 
            // GridClients
            // 
            this.GridClients.AllowUserToAddRows = false;
            this.GridClients.AllowUserToDeleteRows = false;
            this.GridClients.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridClients.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ClientId,
            this.ClientName,
            this.ClientSurname,
            this.ClientPhone,
            this.ClientEmail,
            this.StatusClient});
            this.GridClients.Location = new System.Drawing.Point(225, 12);
            this.GridClients.Name = "GridClients";
            this.GridClients.ReadOnly = true;
            this.GridClients.Size = new System.Drawing.Size(563, 258);
            this.GridClients.TabIndex = 15;
            this.GridClients.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.GridClients_RowHeaderMouseDoubleClick);
            // 
            // ClientId
            // 
            this.ClientId.HeaderText = "Id";
            this.ClientId.Name = "ClientId";
            this.ClientId.ReadOnly = true;
            this.ClientId.Visible = false;
            // 
            // ClientName
            // 
            this.ClientName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ClientName.HeaderText = "Name";
            this.ClientName.Name = "ClientName";
            this.ClientName.ReadOnly = true;
            // 
            // ClientSurname
            // 
            this.ClientSurname.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ClientSurname.HeaderText = "Surname";
            this.ClientSurname.Name = "ClientSurname";
            this.ClientSurname.ReadOnly = true;
            // 
            // ClientPhone
            // 
            this.ClientPhone.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ClientPhone.HeaderText = "Phone";
            this.ClientPhone.Name = "ClientPhone";
            this.ClientPhone.ReadOnly = true;
            // 
            // ClientEmail
            // 
            this.ClientEmail.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ClientEmail.HeaderText = "Email";
            this.ClientEmail.Name = "ClientEmail";
            this.ClientEmail.ReadOnly = true;
            // 
            // StatusClient
            // 
            this.StatusClient.HeaderText = "Status";
            this.StatusClient.Name = "StatusClient";
            this.StatusClient.ReadOnly = true;
            this.StatusClient.Visible = false;
            // 
            // labelClientsEmail
            // 
            this.labelClientsEmail.AutoSize = true;
            this.labelClientsEmail.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelClientsEmail.Location = new System.Drawing.Point(12, 165);
            this.labelClientsEmail.Name = "labelClientsEmail";
            this.labelClientsEmail.Size = new System.Drawing.Size(70, 24);
            this.labelClientsEmail.TabIndex = 16;
            this.labelClientsEmail.Text = "Email";
            // 
            // textBoxClientsEmail
            // 
            this.textBoxClientsEmail.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxClientsEmail.Location = new System.Drawing.Point(16, 192);
            this.textBoxClientsEmail.Name = "textBoxClientsEmail";
            this.textBoxClientsEmail.Size = new System.Drawing.Size(200, 22);
            this.textBoxClientsEmail.TabIndex = 18;
            // 
            // labelClientsPhone
            // 
            this.labelClientsPhone.AutoSize = true;
            this.labelClientsPhone.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelClientsPhone.Location = new System.Drawing.Point(12, 113);
            this.labelClientsPhone.Name = "labelClientsPhone";
            this.labelClientsPhone.Size = new System.Drawing.Size(70, 24);
            this.labelClientsPhone.TabIndex = 16;
            this.labelClientsPhone.Text = "Phone";
            // 
            // textBoxClientsPhone
            // 
            this.textBoxClientsPhone.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxClientsPhone.Location = new System.Drawing.Point(16, 140);
            this.textBoxClientsPhone.Name = "textBoxClientsPhone";
            this.textBoxClientsPhone.Size = new System.Drawing.Size(200, 22);
            this.textBoxClientsPhone.TabIndex = 18;
            // 
            // Clients
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 285);
            this.Controls.Add(this.btnClientsReset);
            this.Controls.Add(this.btnClientsDelete);
            this.Controls.Add(this.btnClientsCreate);
            this.Controls.Add(this.textBoxClientsPhone);
            this.Controls.Add(this.textBoxClientsEmail);
            this.Controls.Add(this.textBoxClientsSurname);
            this.Controls.Add(this.textBoxClientsName);
            this.Controls.Add(this.labelClientsPhone);
            this.Controls.Add(this.labelClientsEmail);
            this.Controls.Add(this.labelClientsSurname);
            this.Controls.Add(this.labelClientsName);
            this.Controls.Add(this.GridClients);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Clients";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Clients";
            this.Load += new System.EventHandler(this.Clients_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GridClients)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnClientsReset;
        private System.Windows.Forms.Button btnClientsDelete;
        private System.Windows.Forms.Button btnClientsCreate;
        private System.Windows.Forms.TextBox textBoxClientsSurname;
        private System.Windows.Forms.TextBox textBoxClientsName;
        private System.Windows.Forms.Label labelClientsSurname;
        private System.Windows.Forms.Label labelClientsName;
        private System.Windows.Forms.DataGridView GridClients;
        private System.Windows.Forms.Label labelClientsEmail;
        private System.Windows.Forms.TextBox textBoxClientsEmail;
        private System.Windows.Forms.Label labelClientsPhone;
        private System.Windows.Forms.TextBox textBoxClientsPhone;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClientId;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClientName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClientSurname;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClientPhone;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClientEmail;
        private System.Windows.Forms.DataGridViewTextBoxColumn StatusClient;
    }
}