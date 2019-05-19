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
    public partial class Categories : Form
    {
        public Categories()
        {
            InitializeComponent();
        }
        CheckValues GoChek = new CheckValues();

        private void Categories_Load(object sender, EventArgs e)
        {
            FillCategoriesGrid();
        }

        private void BtnCategoriesCreate_Click(object sender, EventArgs e)
        {
            if (CreateCategory())
            {
                FillCategoriesGrid();
            }
        }

        private void FillCategoriesGrid()
        {
            GridCategories.Rows.Clear();

            using (MyLibraryEntities db =new MyLibraryEntities())
            {
                List < Catagory > catagories = db.Catagories.ToList();

                foreach (var item in catagories)
                {
                    GridCategories.Rows.Add(item.Id, item.CTName);
                }
            }
        }

        private bool CreateCategory()
        {
             using (MyLibraryEntities db = new MyLibraryEntities())
            {
                Catagory tableCatagory = new Catagory();
                if (GoChek.IsEmpityOrMaxChar(textBoxCategoriesName.Text) && GoChek.IsStringValue(textBoxCategoriesName.Text))
                {
                    tableCatagory.CTName = GoChek.ClearValue;
                }
                else
                {
                    return false;
                }
                db.Catagories.Add(tableCatagory);
                return GoChek.isSave(db.SaveChanges());
            }
        }
        int SelectedRowId;
        private void GridCategories_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {

            ChangeBtnToUpdate();
            SelectedRowId = Convert.ToInt32(GridCategories.Rows[e.RowIndex].Cells[0].Value);
            using (MyLibraryEntities db = new MyLibraryEntities())
            {
                this.textBoxCategoriesName.Text = db.Catagories.Where(x => x.Id == SelectedRowId).FirstOrDefault().CTName;
            }
        }

        private void BtnCategoriesReset_Click(object sender, EventArgs e)
        {
            ClearTextBoxs();
            ChangeBtnToCreate();
        }

        private void ClearTextBoxs()
        {
            this.textBoxCategoriesName.Text = "";
        }

        private void ChangeBtnToUpdate()
        {
            this.btnCategoriesCreate.Text = "Update";
            this.btnCatagoriesDelete.Enabled = true;
            this.btnCategoriesCreate.Click -= new System.EventHandler(this.BtnCategoriesCreate_Click);
            this.btnCategoriesCreate.Click += new System.EventHandler(this.BtnCategoriesUpdate_Click);


        }
        private void ChangeBtnToCreate()
        {
            this.btnCategoriesCreate.Text = "Create";
            this.btnCatagoriesDelete.Enabled = false;
            this.btnCategoriesCreate.Click -= new System.EventHandler(this.BtnCategoriesUpdate_Click);
            this.btnCategoriesCreate.Click += new System.EventHandler(this.BtnCategoriesCreate_Click);

        }
        private void BtnCategoriesUpdate_Click(object sender, EventArgs e)
        {
            if (UpdateCategory())
            {
                FillCategoriesGrid();
            }
        }
        private bool UpdateCategory()
        {
            using (MyLibraryEntities db = new MyLibraryEntities())
            {
                Catagory Catagory = db.Catagories.Where(x => x.Id == SelectedRowId).FirstOrDefault();
                
                if (GoChek.IsEmpityOrMaxChar(textBoxCategoriesName.Text) && GoChek.IsStringValue(textBoxCategoriesName.Text))
                {
                     Catagory.CTName = GoChek.ClearValue;
                }
                else
                {
                    return false;
                }
                return GoChek.isSave(db.SaveChanges());
            }
        }

        private void BtnCatagoriesDelete_Click(object sender, EventArgs e)
        {

           
            if (DeleteCategory())
            {
                ClearTextBoxs();
                ChangeBtnToCreate();
                FillCategoriesGrid();
            }

        }
        private bool DeleteCategory()
        {
            using (MyLibraryEntities db = new MyLibraryEntities())
            {
                string nameCategory  = db.Catagories.Where(x => x.Id == SelectedRowId).FirstOrDefault().CTName.ToString();
                string Dialog = "Seçilmiş " + nameCategory + " Kateqoriyanı silmək istəyirsiniz?";
                DialogResult result = MessageBox.Show(Dialog, "Silmək Sorğusu!",MessageBoxButtons.YesNo);

                if (DialogResult.Yes != result)
                {
                    MessageBox.Show("Seçilmiş " + nameCategory + " Kateqoriyansı Silinmədi.", "Silmək Sorğusuna cavab");
                    return false;
                }
                else
                {
                    Catagory catagory = db.Catagories.Where(i => i.Id == SelectedRowId).FirstOrDefault();
                    db.Catagories.Remove(catagory);
                    return GoChek.isDeleted(db.SaveChanges());
                }

            }

        }
    }
}
