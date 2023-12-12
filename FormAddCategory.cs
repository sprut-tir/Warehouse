using System;
using System.Windows.Forms;

namespace Warehouse
{
    public partial class FormAddCategory : Form
    {
        public FormAddCategory()
        {
            InitializeComponent();
        }

        private void FormAddCategory_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'warehouseDataSet.Categories' table. You can move, or remove it, as needed.
            this.categoriesTableAdapter.Fill(this.warehouseDataSet.Categories);

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbName.Text)) return;

            categoriesTableAdapter.Insert(tbName.Text);
            this.categoriesTableAdapter.Fill(this.warehouseDataSet.Categories);
        }

        private void tbName_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
