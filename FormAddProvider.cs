using System;
using System.Windows.Forms;

namespace Warehouse
{
    public partial class FormAddProvider : Form
    {
        public FormAddProvider()
        {
            InitializeComponent();
        }

        private void FormAddProvider_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'warehouseDataSet.Providers' table. You can move, or remove it, as needed.
            this.providersTableAdapter.Fill(this.warehouseDataSet.Providers);

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbName.Text)) return;

            providersTableAdapter.Insert(tbName.Text);
            this.providersTableAdapter.Fill(this.warehouseDataSet.Providers);
        }
    }
}
