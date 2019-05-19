using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Library.Modal;
using Library.Classes;




namespace Library
{
    public partial class Clients : Form
    {
        public Clients()
        {
            InitializeComponent();
        }
        CheckValues GoChek = new CheckValues();
        private void Clients_Load(object sender, EventArgs e)
        {
            FillClientsGrid();
        }
        private void BtnClientsCreate_Click(object sender, EventArgs e)
        {
            if (CreateClients())
            {
                FillClientsGrid();
            }
        }
        private void FillClientsGrid()
        {
            GridClients.Rows.Clear();

            using (MyLibraryEntities db = new MyLibraryEntities())
            {
                List<Client> clients = db.Clients.ToList();

                foreach (var item in clients)
                {
                    GridClients.Rows.Add(item.Id, item.CLName,item.Surname,item.Phone,item.Email,item.Status);
                }
            }
        }
        private bool CreateClients()
        {
            using (MyLibraryEntities db = new MyLibraryEntities())
            {
                Client tableClient = new Client();
                if (GoChek.IsEmpityOrMaxChar(textBoxClientsName.Text) && GoChek.IsStringValue(textBoxClientsName.Text))
                {
                    tableClient.CLName = GoChek.ClearValue;
                }
                else{return false;}
                if (GoChek.IsEmpityOrMaxChar(textBoxClientsSurname.Text) && GoChek.IsStringValue(textBoxClientsSurname.Text))
                {
                    tableClient.Surname = GoChek.ClearValue;
                }
                else { return false; }
                if (GoChek.IsEmpityOrMaxChar(textBoxClientsEmail.Text) && GoChek.IsEmailValue(textBoxClientsEmail.Text))
                {
                    tableClient.Email = GoChek.ClearValue;
                }
                else { return false; }
                if (GoChek.IsEmpityOrMaxChar(textBoxClientsPhone.Text) && GoChek.IsPhoneValue(textBoxClientsPhone.Text))
                {
                    tableClient.Phone = GoChek.ClearValue;
                }
                else { return false; }

                db.Clients.Add(tableClient);
                return GoChek.isSave(db.SaveChanges());
            }
        }
        int SelectedRowId;
        private void GridClients_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            ChangeBtnToUpdate();
            SelectedRowId = Convert.ToInt32(GridClients.Rows[e.RowIndex].Cells[0].Value);
            using (MyLibraryEntities db = new MyLibraryEntities())
            {
                Client client = db.Clients.Where(x => x.Id == SelectedRowId).FirstOrDefault();
                this.textBoxClientsName.Text = client.CLName;
                this.textBoxClientsSurname.Text = client.Surname;
                this.textBoxClientsPhone.Text = client.Phone;
                this.textBoxClientsEmail.Text = client.Email;
            }
        }
        private void BtnClientUpdate_Click(object sender, EventArgs e)
        {
            if (UpdateClient())
            {
                FillClientsGrid();
            }
        }
        private bool UpdateClient()
         {
                using (MyLibraryEntities db = new MyLibraryEntities())
                {
                    Client client = db.Clients.Where(x => x.Id == SelectedRowId).FirstOrDefault();

                if (GoChek.IsEmpityOrMaxChar(textBoxClientsName.Text) && GoChek.IsStringValue(textBoxClientsName.Text))
                {
                    client.CLName = GoChek.ClearValue;
                }
                else { return false; }
                if (GoChek.IsEmpityOrMaxChar(textBoxClientsSurname.Text) && GoChek.IsStringValue(textBoxClientsSurname.Text))
                {
                    client.Surname = GoChek.ClearValue;
                }
                else { return false; }
                if (GoChek.IsEmpityOrMaxChar(textBoxClientsEmail.Text) && GoChek.IsEmailValue(textBoxClientsEmail.Text))
                {
                    client.Email = GoChek.ClearValue;
                }
                else { return false; }
                if (GoChek.IsEmpityOrMaxChar(textBoxClientsPhone.Text) && GoChek.IsPhoneValue(textBoxClientsPhone.Text))
                {
                    client.Phone = GoChek.ClearValue;
                }
                else { return false; }

                return GoChek.isSave(db.SaveChanges());
                }
        }
        private void ChangeBtnToUpdate()
        {
            this.btnClientsCreate.Text = "Update";
            this.btnClientsDelete.Enabled = true;
            this.btnClientsCreate.Click -= new System.EventHandler(this.BtnClientsCreate_Click);
            this.btnClientsCreate.Click += new System.EventHandler(this.BtnClientUpdate_Click);


        }
        private void ChangeBtnToCreate()
        {
            this.btnClientsCreate.Text = "Create";
            this.btnClientsDelete.Enabled = false;
            this.btnClientsCreate.Click -= new System.EventHandler(this.BtnClientUpdate_Click);
            this.btnClientsCreate.Click += new System.EventHandler(this.BtnClientsCreate_Click);

        }
        private void ClearTextBoxs()
        {
            this.textBoxClientsName.Text = "";
            this.textBoxClientsSurname.Text = "";
            this.textBoxClientsPhone.Text = "";
            this.textBoxClientsEmail.Text = "";

        }
        private void BtnClientsDelete_Click(object sender, EventArgs e)
        {


            if (DeleteClient())
            {
                ClearTextBoxs();
                ChangeBtnToCreate();
                FillClientsGrid();
            }

        }
        private bool DeleteClient()
        {
            using (MyLibraryEntities db = new MyLibraryEntities())
            {
                string nameClient = db.Clients.Where(x => x.Id == SelectedRowId).FirstOrDefault().CLName.ToString();
                string Dialog = "Seçilmiş " + nameClient + " Müştərini silmək istəyirsiniz?";
                DialogResult result = MessageBox.Show(Dialog, "Silmək Sorğusu!", MessageBoxButtons.YesNo);

                if (DialogResult.Yes != result)
                {
                    MessageBox.Show("Seçilmiş " + nameClient + " Müştəri Silinmədi.", "Silmək Sorğusuna cavab");
                    return false;
                }
                else
                {
                    Client client = db.Clients.Where(i => i.Id == SelectedRowId).FirstOrDefault();
                    db.Clients.Remove(client);
                    return GoChek.isDeleted(db.SaveChanges());
                }

            }

        }

        private void BtnClientsReset_Click(object sender, EventArgs e)
        {
            ClearTextBoxs();
            ChangeBtnToCreate();
        }
    }
}
