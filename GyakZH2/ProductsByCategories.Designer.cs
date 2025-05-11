namespace GyakZH2
{
    partial class ProductsByCategories
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
            listBox1 = new ListBox();
            categoryBindingSource = new BindingSource(components);
            dataGridView1 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)categoryBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // listBox1
            // 
            listBox1.DataSource = categoryBindingSource;
            listBox1.DisplayMember = "CategoryName";
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(18, 23);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(162, 559);
            listBox1.TabIndex = 0;
            // 
            // categoryBindingSource
            // 
            categoryBindingSource.DataSource = typeof(BikestoreModels.Category);
            categoryBindingSource.CurrentChanged += categoryBindingSource_CurrentChanged;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(186, 23);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(646, 569);
            dataGridView1.TabIndex = 1;
            // 
            // ProductsByCategories
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(dataGridView1);
            Controls.Add(listBox1);
            Name = "ProductsByCategories";
            Size = new Size(832, 592);
            Load += ProductsByCategories_Load;
            ((System.ComponentModel.ISupportInitialize)categoryBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private ListBox listBox1;
        private BindingSource categoryBindingSource;
        private DataGridView dataGridView1;
    }
}
