using System;
using System.Windows.Forms;

namespace Warehouse
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void bindingSource1_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'warehouseDataSet.Providers' table. You can move, or remove it, as needed.
            this.providersTableAdapter.Fill(this.warehouseDataSet.Providers);
            // TODO: This line of code loads data into the 'warehouseDataSet.Providers' table. You can move, or remove it, as needed.
            this.providersTableAdapter.Fill(this.warehouseDataSet.Providers);
            // TODO: This line of code loads data into the 'warehouseDataSet.Categories' table. You can move, or remove it, as needed.
            this.categoriesTableAdapter.Fill(this.warehouseDataSet.Categories);
            // TODO: This line of code loads data into the 'warehouseDataSet.Products' table. You can move, or remove it, as needed.
            this.productsTableAdapter.Fill(this.warehouseDataSet.Products);

        }

        private void productsBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
        }

        private void btnAddCategory_Click(object sender, EventArgs e)
        {
            var form = new FormAddCategory();
            form.ShowDialog();
        }

        private void btnAddProvider_Click(object sender, EventArgs e)
        {
            var form = new FormAddProvider();
            form.ShowDialog();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            this.productsTableAdapter.Fill(this.warehouseDataSet.Products);
        }
    }
}
