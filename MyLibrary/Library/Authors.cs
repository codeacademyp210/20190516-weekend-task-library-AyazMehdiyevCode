using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Library.Classes;
using Library.Modal;

namespace Library
{
    public partial class Authors : Form
    {
        public Authors()
        {
            InitializeComponent();
        }

        CheckValues GoChek = new CheckValues();
        private void Authors_Load(object sender, EventArgs e)
        {
            FillAuthorsGrid();
        }
        private void BtnAuthorsCreate_Click(object sender, EventArgs e)
        {
            if (CreateAuthors())
            {
                FillAuthorsGrid();
            }
        }
 
        private void FillAuthorsGrid()
        {
            GridAuthors.Rows.Clear();

            using (MyLibraryEntities db = new MyLibraryEntities())
            {
                List<Author> authors = db.Authors.ToList();

                foreach (var item in authors)
                {
                    GridAuthors.Rows.Add(item.Id, item.AUTName, item.Surname);
                }
            }
        }
        private bool CreateAuthors()
        {
            using (MyLibraryEntities db = new MyLibraryEntities())
            {
                Author tableAuthor = new Author();
                if (GoChek.IsEmpityOrMaxChar(textBoxAuthorsName.Text) && GoChek.IsStringValue(textBoxAuthorsName.Text))
                {
                    tableAuthor.AUTName = GoChek.ClearValue;
                }
                else { return false; }
                if (GoChek.IsEmpityOrMaxChar(textBoxAuthorsSurname.Text) && GoChek.IsStringValue(textBoxAuthorsSurname.Text))
                {
                    tableAuthor.Surname = GoChek.ClearValue;
                }
                else { return false; }

                db.Authors.Add(tableAuthor);
                return GoChek.isSave(db.SaveChanges());
            }
        }
        int SelectedRowId;
        private void GridAuthors_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            ChangeBtnToUpdate();
            SelectedRowId = Convert.ToInt32(GridAuthors.Rows[e.RowIndex].Cells[0].Value);
            using (MyLibraryEntities db = new MyLibraryEntities())
            {
                Author authors = db.Authors.Where(x => x.Id == SelectedRowId).FirstOrDefault();
                this.textBoxAuthorsName.Text = authors.AUTName;
                this.textBoxAuthorsSurname.Text = authors.Surname;
            }
        }

        private void BtnAuthorUpdate_Click(object sender, EventArgs e)
        {
            if (UpdateAuthor())
            {
                FillAuthorsGrid();
            }
        }
        private bool UpdateAuthor()
        {
            using (MyLibraryEntities db = new MyLibraryEntities())
            {
                Author author = db.Authors.Where(x => x.Id == SelectedRowId).FirstOrDefault();

                if (GoChek.IsEmpityOrMaxChar(textBoxAuthorsName.Text) && GoChek.IsStringValue(textBoxAuthorsName.Text))
                {
                    author.AUTName = GoChek.ClearValue;
                }
                else { return false; }
                if (GoChek.IsEmpityOrMaxChar(textBoxAuthorsSurname.Text) && GoChek.IsStringValue(textBoxAuthorsSurname.Text))
                {
                    author.Surname = GoChek.ClearValue;
                }
                else { return false; }

                return GoChek.isSave(db.SaveChanges());
            }
        }
        private void ChangeBtnToUpdate()
        {
            this.btnAuthorsCreate.Text = "Update";
            this.btnAuthorsDelete.Enabled = true;
            this.btnAuthorsCreate.Click -= new System.EventHandler(this.BtnAuthorsCreate_Click);
            this.btnAuthorsCreate.Click += new System.EventHandler(this.BtnAuthorUpdate_Click);


        }
        private void ChangeBtnToCreate()
        {
            this.btnAuthorsCreate.Text = "Create";
            this.btnAuthorsDelete.Enabled = false;
            this.btnAuthorsCreate.Click -= new System.EventHandler(this.BtnAuthorUpdate_Click);
            this.btnAuthorsCreate.Click += new System.EventHandler(this.BtnAuthorsCreate_Click);

        }
        private void ClearTextBoxs()
        {
            this.textBoxAuthorsName.Text = "";
            this.textBoxAuthorsSurname.Text = "";

        }

        private void BtnAuthorsDelete_Click(object sender, EventArgs e)
        {
            if (DeleteAuhor())
            {
                ClearTextBoxs();
                ChangeBtnToCreate();
                FillAuthorsGrid();
            }
        }
        private bool DeleteAuhor()
        {
            using (MyLibraryEntities db = new MyLibraryEntities())
            {
                string nameAuthor = db.Authors.Where(x => x.Id == SelectedRowId).FirstOrDefault().AUTName.ToString();
                string Dialog = "Seçilmiş " + nameAuthor + " Müəllifi silmək istəyirsiniz?";
                DialogResult result = MessageBox.Show(Dialog, "Silmək Sorğusu!", MessageBoxButtons.YesNo);

                if (DialogResult.Yes != result)
                {
                    MessageBox.Show("Seçilmiş " + nameAuthor + " Müəllifi Silinmədi.", "Silmək Sorğusuna cavab");
                    return false;
                }
                else
                {
                    Author author = db.Authors.Where(i => i.Id == SelectedRowId).FirstOrDefault();
                    db.Authors.Remove(author);
                    return GoChek.isDeleted(db.SaveChanges());
                }

            }

        }





        private void BtnAuthorsReset_Click(object sender, EventArgs e)
        {
            ClearTextBoxs();
            ChangeBtnToCreate();
        }


    }
}
