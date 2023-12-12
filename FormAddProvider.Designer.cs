namespace Warehouse
{
    partial class FormAddProvider
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
            this.btnAdd = new System.Windows.Forms.Button();
            this.tbName = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.warehouseDataSet = new Warehouse.WarehouseDataSet();
            this.providersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.providersTableAdapter = new Warehouse.WarehouseDataSetTableAdapters.ProvidersTableAdapter();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.providerNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.warehouseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.providersBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(271, 246);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 7;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(53, 246);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(208, 20);
            this.tbName.TabIndex = 6;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.providerNameDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.providersBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(372, 216);
            this.dataGridView1.TabIndex = 5;
            // 
            // warehouseDataSet
            // 
            this.warehouseDataSet.DataSetName = "WarehouseDataSet";
            this.warehouseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // providersBindingSource
            // 
            this.providersBindingSource.DataMember = "Providers";
            this.providersBindingSource.DataSource = this.warehouseDataSet;
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
            this.idDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.idDataGridViewTextBoxColumn.Visible = false;
            // 
            // providerNameDataGridViewTextBoxColumn
            // 
            this.providerNameDataGridViewTextBoxColumn.DataPropertyName = "ProviderName";
            this.providerNameDataGridViewTextBoxColumn.HeaderText = "ProviderName";
            this.providerNameDataGridViewTextBoxColumn.Name = "providerNameDataGridViewTextBoxColumn";
            this.providerNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.providerNameDataGridViewTextBoxColumn.Width = 300;
            // 
            // FormAddProvider
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(408, 338);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.dataGridView1);
            this.Name = "FormAddProvider";
            this.Text = "FormAddProvider";
            this.Load += new System.EventHandler(this.FormAddProvider_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.warehouseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.providersBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.DataGridView dataGridView1;
        private WarehouseDataSet warehouseDataSet;
        private System.Windows.Forms.BindingSource providersBindingSource;
        private WarehouseDataSetTableAdapters.ProvidersTableAdapter providersTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn providerNameDataGridViewTextBoxColumn;
    }
}