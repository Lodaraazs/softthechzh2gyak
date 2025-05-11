namespace GyakZH2
{
    partial class Products1
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            label1 = new Label();
            textBox1 = new TextBox();
            dataGridView1 = new DataGridView();
            categoryBindingSource1 = new BindingSource(components);
            productBindingSource = new BindingSource(components);
            categoryBindingSource = new BindingSource(components);
            brandBindingSource = new BindingSource(components);
            productSkDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            productNameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            brandIdDataGridViewTextBoxColumn = new DataGridViewComboBoxColumn();
            categoryFkDataGridViewTextBoxColumn = new DataGridViewComboBoxColumn();
            modelYearDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            listPriceDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            brandDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            categoryFkNavigationDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            orderItemsDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            stocksDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)categoryBindingSource1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)productBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)categoryBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)brandBindingSource).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 26.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(3, 12);
            label1.Name = "label1";
            label1.Size = new Size(157, 47);
            label1.TabIndex = 0;
            label1.Text = "Products";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(13, 62);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(136, 23);
            textBox1.TabIndex = 1;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // dataGridView1
            // 
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { productSkDataGridViewTextBoxColumn, productNameDataGridViewTextBoxColumn, brandIdDataGridViewTextBoxColumn, categoryFkDataGridViewTextBoxColumn, modelYearDataGridViewTextBoxColumn, listPriceDataGridViewTextBoxColumn, brandDataGridViewTextBoxColumn, categoryFkNavigationDataGridViewTextBoxColumn, orderItemsDataGridViewTextBoxColumn, stocksDataGridViewTextBoxColumn });
            dataGridView1.DataSource = productBindingSource;
            dataGridView1.Location = new Point(0, 91);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(1044, 420);
            dataGridView1.TabIndex = 2;
            // 
            // categoryBindingSource1
            // 
            categoryBindingSource1.DataSource = typeof(BikestoreModels.Category);
            // 
            // productBindingSource
            // 
            productBindingSource.DataSource = typeof(BikestoreModels.Product);
            // 
            // categoryBindingSource
            // 
            categoryBindingSource.DataSource = typeof(BikestoreModels.Category);
            // 
            // brandBindingSource
            // 
            brandBindingSource.DataSource = typeof(BikestoreModels.Brand);
            // 
            // productSkDataGridViewTextBoxColumn
            // 
            productSkDataGridViewTextBoxColumn.DataPropertyName = "ProductSk";
            productSkDataGridViewTextBoxColumn.HeaderText = "ProductSk";
            productSkDataGridViewTextBoxColumn.Name = "productSkDataGridViewTextBoxColumn";
            productSkDataGridViewTextBoxColumn.Resizable = DataGridViewTriState.True;
            // 
            // productNameDataGridViewTextBoxColumn
            // 
            productNameDataGridViewTextBoxColumn.DataPropertyName = "ProductName";
            productNameDataGridViewTextBoxColumn.HeaderText = "ProductName";
            productNameDataGridViewTextBoxColumn.Name = "productNameDataGridViewTextBoxColumn";
            // 
            // brandIdDataGridViewTextBoxColumn
            // 
            brandIdDataGridViewTextBoxColumn.DataPropertyName = "BrandId";
            brandIdDataGridViewTextBoxColumn.DataSource = brandBindingSource;
            brandIdDataGridViewTextBoxColumn.DisplayMember = "BrandName";
            brandIdDataGridViewTextBoxColumn.HeaderText = "BrandId";
            brandIdDataGridViewTextBoxColumn.Name = "brandIdDataGridViewTextBoxColumn";
            brandIdDataGridViewTextBoxColumn.Resizable = DataGridViewTriState.True;
            brandIdDataGridViewTextBoxColumn.SortMode = DataGridViewColumnSortMode.Automatic;
            brandIdDataGridViewTextBoxColumn.ValueMember = "BrandSk";
            // 
            // categoryFkDataGridViewTextBoxColumn
            // 
            categoryFkDataGridViewTextBoxColumn.DataPropertyName = "CategoryFk";
            categoryFkDataGridViewTextBoxColumn.DataSource = categoryBindingSource1;
            categoryFkDataGridViewTextBoxColumn.DisplayMember = "CategoryName";
            categoryFkDataGridViewTextBoxColumn.HeaderText = "CategoryFk";
            categoryFkDataGridViewTextBoxColumn.Name = "categoryFkDataGridViewTextBoxColumn";
            categoryFkDataGridViewTextBoxColumn.Resizable = DataGridViewTriState.True;
            categoryFkDataGridViewTextBoxColumn.SortMode = DataGridViewColumnSortMode.Automatic;
            categoryFkDataGridViewTextBoxColumn.ValueMember = "CategorySk";
            // 
            // modelYearDataGridViewTextBoxColumn
            // 
            modelYearDataGridViewTextBoxColumn.DataPropertyName = "ModelYear";
            modelYearDataGridViewTextBoxColumn.HeaderText = "ModelYear";
            modelYearDataGridViewTextBoxColumn.Name = "modelYearDataGridViewTextBoxColumn";
            // 
            // listPriceDataGridViewTextBoxColumn
            // 
            listPriceDataGridViewTextBoxColumn.DataPropertyName = "ListPrice";
            listPriceDataGridViewTextBoxColumn.HeaderText = "ListPrice";
            listPriceDataGridViewTextBoxColumn.Name = "listPriceDataGridViewTextBoxColumn";
            // 
            // brandDataGridViewTextBoxColumn
            // 
            brandDataGridViewTextBoxColumn.DataPropertyName = "Brand";
            brandDataGridViewTextBoxColumn.HeaderText = "Brand";
            brandDataGridViewTextBoxColumn.Name = "brandDataGridViewTextBoxColumn";
            // 
            // categoryFkNavigationDataGridViewTextBoxColumn
            // 
            categoryFkNavigationDataGridViewTextBoxColumn.DataPropertyName = "CategoryFkNavigation";
            categoryFkNavigationDataGridViewTextBoxColumn.HeaderText = "CategoryFkNavigation";
            categoryFkNavigationDataGridViewTextBoxColumn.Name = "categoryFkNavigationDataGridViewTextBoxColumn";
            // 
            // orderItemsDataGridViewTextBoxColumn
            // 
            orderItemsDataGridViewTextBoxColumn.DataPropertyName = "OrderItems";
            orderItemsDataGridViewTextBoxColumn.HeaderText = "OrderItems";
            orderItemsDataGridViewTextBoxColumn.Name = "orderItemsDataGridViewTextBoxColumn";
            // 
            // stocksDataGridViewTextBoxColumn
            // 
            stocksDataGridViewTextBoxColumn.DataPropertyName = "Stocks";
            stocksDataGridViewTextBoxColumn.HeaderText = "Stocks";
            stocksDataGridViewTextBoxColumn.Name = "stocksDataGridViewTextBoxColumn";
            // 
            // Products1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(dataGridView1);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Name = "Products1";
            Size = new Size(1043, 511);
            Load += Products1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)categoryBindingSource1).EndInit();
            ((System.ComponentModel.ISupportInitialize)productBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)categoryBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)brandBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBox1;
        private DataGridView dataGridView1;
        private BindingSource productBindingSource;
        private BindingSource categoryBindingSource;
        private BindingSource categoryBindingSource1;
        private DataGridViewTextBoxColumn productSkDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn productNameDataGridViewTextBoxColumn;
        private DataGridViewComboBoxColumn brandIdDataGridViewTextBoxColumn;
        private BindingSource brandBindingSource;
        private DataGridViewComboBoxColumn categoryFkDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn modelYearDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn listPriceDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn brandDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn categoryFkNavigationDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn orderItemsDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn stocksDataGridViewTextBoxColumn;
    }
}
