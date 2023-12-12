namespace Warehouse
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.productsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.categoriesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.providersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.providersBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.btnAddCategory = new System.Windows.Forms.Button();
            this.btnAddProvider = new System.Windows.Forms.Button();
            this.dgvProducts = new System.Windows.Forms.DataGridView();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.productsBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.providersBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.categoriesBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.bindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.warehouseDataSet = new Warehouse.WarehouseDataSet();
            this.productsTableAdapter = new Warehouse.WarehouseDataSetTableAdapters.ProductsTableAdapter();
            this.categoriesTableAdapter = new Warehouse.WarehouseDataSetTableAdapters.CategoriesTableAdapter();
            this.providersTableAdapter = new Warehouse.WarehouseDataSetTableAdapters.ProvidersTableAdapter();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.titleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.providerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.categoryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.qTYDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoriesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.providersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.providersBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.providersBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoriesBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.warehouseDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // productsBindingSource
            // 
            this.productsBindingSource.DataMember = "Products";
            this.productsBindingSource.DataSource = this.bindingSource;
            this.productsBindingSource.CurrentChanged += new System.EventHandler(this.productsBindingSource_CurrentChanged);
            // 
            // categoriesBindingSource
            // 
            this.categoriesBindingSource.DataMember = "Categories";
            this.categoriesBindingSource.DataSource = this.bindingSource;
            // 
            // providersBindingSource
            // 
            this.providersBindingSource.DataMember = "Providers";
            this.providersBindingSource.DataSource = this.bindingSource;
            // 
            // providersBindingSource1
            // 
            this.providersBindingSource1.DataMember = "Providers";
            this.providersBindingSource1.DataSource = this.bindingSource;
            // 
            // btnAddCategory
            // 
            this.btnAddCategory.Location = new System.Drawing.Point(12, 12);
            this.btnAddCategory.Name = "btnAddCategory";
            this.btnAddCategory.Size = new System.Drawing.Size(121, 23);
            this.btnAddCategory.TabIndex = 5;
            this.btnAddCategory.Text = "Add Category";
            this.btnAddCategory.UseVisualStyleBackColor = true;
            this.btnAddCategory.Click += new System.EventHandler(this.btnAddCategory_Click);
            // 
            // btnAddProvider
            // 
            this.btnAddProvider.Location = new System.Drawing.Point(153, 12);
            this.btnAddProvider.Name = "btnAddProvider";
            this.btnAddProvider.Size = new System.Drawing.Size(121, 23);
            this.btnAddProvider.TabIndex = 6;
            this.btnAddProvider.Text = "Add Provider";
            this.btnAddProvider.UseVisualStyleBackColor = true;
            this.btnAddProvider.Click += new System.EventHandler(this.btnAddProvider_Click);
            // 
            // dgvProducts
            // 
            this.dgvProducts.AutoGenerateColumns = false;
            this.dgvProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProducts.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.titleDataGridViewTextBoxColumn,
            this.providerDataGridViewTextBoxColumn,
            this.categoryDataGridViewTextBoxColumn,
            this.qTYDataGridViewTextBoxColumn,
            this.priceDataGridViewTextBoxColumn});
            this.dgvProducts.DataSource = this.productsBindingSource1;
            this.dgvProducts.Location = new System.Drawing.Point(12, 60);
            this.dgvProducts.Name = "dgvProducts";
            this.dgvProducts.Size = new System.Drawing.Size(776, 246);
            this.dgvProducts.TabIndex = 7;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(318, 12);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 8;
            this.btnUpdate.Text = "Update all data";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // productsBindingSource1
            // 
            this.productsBindingSource1.DataMember = "Products";
            this.productsBindingSource1.DataSource = this.bindingSource;
            // 
            // providersBindingSource2
            // 
            this.providersBindingSource2.DataMember = "Providers";
            this.providersBindingSource2.DataSource = this.bindingSource;
            // 
            // categoriesBindingSource1
            // 
            this.categoriesBindingSource1.DataMember = "Categories";
            this.categoriesBindingSource1.DataSource = this.bindingSource;
            // 
            // bindingSource
            // 
            this.bindingSource.DataSource = this.warehouseDataSet;
            this.bindingSource.Position = 0;
            this.bindingSource.CurrentChanged += new System.EventHandler(this.bindingSource1_CurrentChanged);
            // 
            // warehouseDataSet
            // 
            this.warehouseDataSet.DataSetName = "WarehouseDataSet";
            this.warehouseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // productsTableAdapter
            // 
            this.productsTableAdapter.ClearBeforeFill = true;
            // 
            // categoriesTableAdapter
            // 
            this.categoriesTableAdapter.ClearBeforeFill = true;
            // 
            // providersTableAdapter
            // 
            this.providersTableAdapter.ClearBeforeFill = true;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // titleDataGridViewTextBoxColumn
            // 
            this.titleDataGridViewTextBoxColumn.DataPropertyName = "Title";
            this.titleDataGridViewTextBoxColumn.HeaderText = "Title";
            this.titleDataGridViewTextBoxColumn.Name = "titleDataGridViewTextBoxColumn";
            // 
            // providerDataGridViewTextBoxColumn
            // 
            this.providerDataGridViewTextBoxColumn.DataPropertyName = "Provider";
            this.providerDataGridViewTextBoxColumn.DataSource = this.providersBindingSource2;
            this.providerDataGridViewTextBoxColumn.DisplayMember = "ProviderName";
            this.providerDataGridViewTextBoxColumn.HeaderText = "Provider";
            this.providerDataGridViewTextBoxColumn.Name = "providerDataGridViewTextBoxColumn";
            this.providerDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.providerDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.providerDataGridViewTextBoxColumn.ValueMember = "Id";
            // 
            // categoryDataGridViewTextBoxColumn
            // 
            this.categoryDataGridViewTextBoxColumn.DataPropertyName = "Category";
            this.categoryDataGridViewTextBoxColumn.DataSource = this.categoriesBindingSource1;
            this.categoryDataGridViewTextBoxColumn.DisplayMember = "CategoryName";
            this.categoryDataGridViewTextBoxColumn.HeaderText = "Category";
            this.categoryDataGridViewTextBoxColumn.Name = "categoryDataGridViewTextBoxColumn";
            this.categoryDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.categoryDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.categoryDataGridViewTextBoxColumn.ValueMember = "Id";
            // 
            // qTYDataGridViewTextBoxColumn
            // 
            this.qTYDataGridViewTextBoxColumn.DataPropertyName = "QTY";
            this.qTYDataGridViewTextBoxColumn.HeaderText = "QTY";
            this.qTYDataGridViewTextBoxColumn.Name = "qTYDataGridViewTextBoxColumn";
            // 
            // priceDataGridViewTextBoxColumn
            // 
            this.priceDataGridViewTextBoxColumn.DataPropertyName = "Price";
            this.priceDataGridViewTextBoxColumn.HeaderText = "Price";
            this.priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.dgvProducts);
            this.Controls.Add(this.btnAddProvider);
            this.Controls.Add(this.btnAddCategory);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoriesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.providersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.providersBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.providersBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoriesBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.warehouseDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource bindingSource;
        private WarehouseDataSet warehouseDataSet;
        private System.Windows.Forms.BindingSource productsBindingSource;
        private WarehouseDataSetTableAdapters.ProductsTableAdapter productsTableAdapter;
        private System.Windows.Forms.BindingSource categoriesBindingSource;
        private WarehouseDataSetTableAdapters.CategoriesTableAdapter categoriesTableAdapter;
        private System.Windows.Forms.BindingSource providersBindingSource;
        private WarehouseDataSetTableAdapters.ProvidersTableAdapter providersTableAdapter;
        private System.Windows.Forms.BindingSource providersBindingSource1;
        private System.Windows.Forms.Button btnAddCategory;
        private System.Windows.Forms.Button btnAddProvider;
        private System.Windows.Forms.DataGridView dgvProducts;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.BindingSource productsBindingSource1;
        private System.Windows.Forms.BindingSource providersBindingSource2;
        private System.Windows.Forms.BindingSource categoriesBindingSource1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn titleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn providerDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn categoryDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn qTYDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
    }
}

