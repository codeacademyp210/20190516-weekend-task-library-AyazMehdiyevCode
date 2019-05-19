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
    public partial class Books : Form
    {
        public Books()
        {
            InitializeComponent();
        }

        private void BtnShowAutorsForm_Click(object sender, EventArgs e)
        {
            Authors AuthorsForm = new Authors();
            AuthorsForm.ShowDialog();
        }

        private void BtnShowCategoryForm_Click(object sender, EventArgs e)
        {
            Categories CategoriesForm = new Categories();
            CategoriesForm.ShowDialog();
        }
        CheckValues GoChek = new CheckValues();
        private void BtnBooksCreate_Click(object sender, EventArgs e)
        {
            if (CreateBooks())
            {
                FillBooksGrid();
            }
        }



        private void BtnBooksReset_Click(object sender, EventArgs e)
        {
            ClearTextBoxs();
            ChangeBtnToCreate();
        }

        private void Books_Load(object sender, EventArgs e)
        {
            FillBooksGrid();
            FillComboCatagory();
            FillComboAuthor();
        }

 
        private void FillComboCatagory()
        {
            using (MyLibraryEntities db = new MyLibraryEntities())
            {
                this.comboBoxBooksCategory.DataSource = db.Catagories.Select(b => b.CTName).ToList();
            }
            
        }
        private void FillComboAuthor()
        {
            using (MyLibraryEntities db = new MyLibraryEntities())
            {
                this.comboBoxBooksAuthors.DataSource = db.Authors.Select(b => b.AUTName).ToList();
            }

        }
        private void FillBooksGrid()
        {
            GridBooks.Rows.Clear();

            using (MyLibraryEntities db = new MyLibraryEntities())
            {
                List<Book> books = db.Books.ToList() ;
                List<AuthorsBook> authorsBooks = db.AuthorsBooks.ToList();

                foreach (var item in books)
                {
                    GridBooks.Rows.Add(item.Id, item.BKName, 
                        db.AuthorsBooks.Where(x=> x.BookId==item.Id).ToList().FirstOrDefault().Author.AUTName, 
                        item.Price, 
                        db.Catagories.Where(x=> x.Id==item.CatagoryId).ToList().FirstOrDefault().CTName, 
                        item.BKCount);
                }
            }
        }
        private bool CreateBooks()
        {
            using (MyLibraryEntities db = new MyLibraryEntities())
            {
                Book book = new Book();
                if (GoChek.IsEmpityOrMaxChar(textBoxBooksName.Text) && GoChek.IsStringValue(textBoxBooksName.Text))
                {
                    book.BKName = GoChek.ClearValue;
                }
                if (GoChek.IsEmpityOrMaxChar(textBoxBooksPrice.Text) && GoChek.isPrice(textBoxBooksPrice.Text))
                {
                    book.Price = Convert.ToDecimal(GoChek.ClearValue);
                }
                else { return false; }
                book.CatagoryId = (db.Catagories.Where(x => x.CTName == comboBoxBooksCategory.SelectedItem.ToString()).FirstOrDefault().Id);
                book.BKCount = 10;
                db.Books.Add(book);
                AuthorsBook authorsBook = new AuthorsBook();
                authorsBook.AuthorId = db.Authors.Where(x => x.AUTName == comboBoxBooksAuthors.SelectedItem.ToString()).FirstOrDefault().Id;
                authorsBook.BookId = book.Id;
                db.AuthorsBooks.Add(authorsBook);
                return GoChek.isSave(db.SaveChanges());
            }
        }
        int SelectedRowId;
        private void GridBooks_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            ChangeBtnToUpdate();
            SelectedRowId = Convert.ToInt32(GridBooks.Rows[e.RowIndex].Cells[0].Value);
            using (MyLibraryEntities db = new MyLibraryEntities())
            {
                Book book = db.Books.Where(x => x.Id == SelectedRowId).FirstOrDefault();
                this.textBoxBooksName.Text = book.BKName;
                this.textBoxBooksPrice.Text = book.Price.ToString();
                this.comboBoxBooksAuthors.SelectedItem = db.Authors.Where(x => x.AUTName == GridBooks.Rows[e.RowIndex].Cells[2].Value.ToString()); 
                this.comboBoxBooksCategory.SelectedItem = db.Catagories.Where(x => x.CTName == GridBooks.Rows[e.RowIndex].Cells[4].Value.ToString());
            }
        }


        private void BtnBookUpdate_Click(object sender, EventArgs e)
        {
            if (UpdateBooks())
            {
                FillBooksGrid();
            }
        }
        private bool UpdateBooks()
        {
            using (MyLibraryEntities db = new MyLibraryEntities())
            {
                Book book = db.Books.Where(x => x.Id == SelectedRowId).FirstOrDefault();
                AuthorsBook authorsBook=db.AuthorsBooks.Where(x => x.BookId == SelectedRowId).FirstOrDefault();
                if (GoChek.IsEmpityOrMaxChar(textBoxBooksName.Text) && GoChek.IsStringValue(textBoxBooksName.Text))
                {
                    book.BKName = GoChek.ClearValue;
                }
                else { return false; }
                if (GoChek.IsEmpityOrMaxChar(textBoxBooksPrice.Text) && GoChek.isPrice(textBoxBooksPrice.Text))
                {
                    book.Price = Convert.ToDecimal(GoChek.ClearValue);
                }
                else { return false; }
                book.CatagoryId = (db.Catagories.Where(x => x.CTName == comboBoxBooksCategory.SelectedItem.ToString()).FirstOrDefault().Id);
                book.BKCount = 10;
                authorsBook.AuthorId = db.Authors.Where(x => x.AUTName == comboBoxBooksAuthors.SelectedItem.ToString()).FirstOrDefault().Id;
                authorsBook.BookId = book.Id;
                return GoChek.isSave(db.SaveChanges());
            }
        }
        private void ChangeBtnToUpdate()
        {
            this.btnBooksCreate.Text = "Update";
            this.btnBooksDelete.Enabled = true;
            this.btnBooksCreate.Click -= new System.EventHandler(this.BtnBooksCreate_Click);
            this.btnBooksCreate.Click += new System.EventHandler(this.BtnBookUpdate_Click);


        }
        private void ChangeBtnToCreate()
        {
            this.btnBooksCreate.Text = "Create";
            this.btnBooksDelete.Enabled = false;
            this.btnBooksCreate.Click -= new System.EventHandler(this.BtnBookUpdate_Click);
            this.btnBooksCreate.Click += new System.EventHandler(this.BtnBooksCreate_Click);

        }
        private void ClearTextBoxs()
        {
            this.textBoxBooksName.Text = "";
            this.textBoxBooksPrice.Text = "";
            this.comboBoxBooksAuthors.Text = "";
            this.comboBoxBooksCategory.Text = "";
        }

        private void BtnBooksDelete_Click(object sender, EventArgs e)
        {
            if (DeleteBooks())
            {
                ClearTextBoxs();
                ChangeBtnToCreate();
                FillBooksGrid();
            }
        }
        private bool DeleteBooks()
        {
            using (MyLibraryEntities db = new MyLibraryEntities())
            {
                string namebook = db.Books.Where(x => x.Id == SelectedRowId).FirstOrDefault().BKName.ToString();
                string Dialog = "Seçilmiş " + namebook + " Kitabı silmək istəyirsiniz?";
                DialogResult result = MessageBox.Show(Dialog, "Silmək Sorğusu!", MessageBoxButtons.YesNo);

                if (DialogResult.Yes != result)
                {
                    MessageBox.Show("Seçilmiş " + namebook + " Kitabı Silinmədi.", "Silmək Sorğusuna cavab");
                    return false;
                }
                else
                {
                    Book books = db.Books.Where(i => i.Id == SelectedRowId).FirstOrDefault();
                    AuthorsBook authorsBook = db.AuthorsBooks.Where(x => x.BookId == db.Books.Where(bx => bx.Id == SelectedRowId).FirstOrDefault().Id).FirstOrDefault();
                    db.AuthorsBooks.Remove(authorsBook);
                    db.Books.Remove(books);
                    return GoChek.isDeleted(db.SaveChanges());
                }

            }

        }

        private void Books_Activated(object sender, EventArgs e)
        {
            FillComboCatagory();
            FillComboAuthor();
        }
    }
}
