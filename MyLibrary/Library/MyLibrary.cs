using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library
{
    public partial class MyLibrary : Form
    {
        public MyLibrary()
        {
            InitializeComponent();

        }

        private void BooksToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Books BooksForm = new Books();
            BooksForm.ShowDialog();
        }

        private void AuthorsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Authors AuthorsForm = new Authors();
            AuthorsForm.ShowDialog();
        }

        private void ClientsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Clients ClientsForm = new Clients();
            ClientsForm.ShowDialog();
        }

        private void OrdersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Orders OrdersForm = new Orders();
            OrdersForm.ShowDialog();
        }

        private void CategoriesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Categories CategoresForm = new Categories();
            CategoresForm.ShowDialog();
        }
    }
}
