
namespace sss
{
    partial class Form3
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
            this.Выход = new System.Windows.Forms.Button();
            this.b1DataSet = new sss.b1DataSet();
            this.productSaleBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.productSaleTableAdapter = new sss.b1DataSetTableAdapters.ProductSaleTableAdapter();
            this.serviceBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.serviceTableAdapter = new sss.b1DataSetTableAdapters.ServiceTableAdapter();
            this.clientBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.clientTableAdapter = new sss.b1DataSetTableAdapters.ClientTableAdapter();
            this.serviceBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.titleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.costDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.durationInSecondsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.discountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mainImagePathDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.b1DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productSaleBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.serviceBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.serviceBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // Выход
            // 
            this.Выход.BackColor = System.Drawing.Color.White;
            this.Выход.Location = new System.Drawing.Point(715, 227);
            this.Выход.Name = "Выход";
            this.Выход.Size = new System.Drawing.Size(117, 33);
            this.Выход.TabIndex = 5;
            this.Выход.Text = "Выход";
            this.Выход.UseVisualStyleBackColor = false;
            this.Выход.Click += new System.EventHandler(this.Выход_Click);
            // 
            // b1DataSet
            // 
            this.b1DataSet.DataSetName = "b1DataSet";
            this.b1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // productSaleBindingSource
            // 
            this.productSaleBindingSource.DataMember = "ProductSale";
            this.productSaleBindingSource.DataSource = this.b1DataSet;
            // 
            // productSaleTableAdapter
            // 
            this.productSaleTableAdapter.ClearBeforeFill = true;
            // 
            // serviceBindingSource
            // 
            this.serviceBindingSource.DataMember = "Service";
            this.serviceBindingSource.DataSource = this.b1DataSet;
            // 
            // serviceTableAdapter
            // 
            this.serviceTableAdapter.ClearBeforeFill = true;
            // 
            // clientBindingSource
            // 
            this.clientBindingSource.DataMember = "Client";
            this.clientBindingSource.DataSource = this.b1DataSet;
            // 
            // clientTableAdapter
            // 
            this.clientTableAdapter.ClearBeforeFill = true;
            // 
            // serviceBindingSource1
            // 
            this.serviceBindingSource1.DataMember = "Service";
            this.serviceBindingSource1.DataSource = this.b1DataSet;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.titleDataGridViewTextBoxColumn,
            this.costDataGridViewTextBoxColumn,
            this.durationInSecondsDataGridViewTextBoxColumn,
            this.descriptionDataGridViewTextBoxColumn,
            this.discountDataGridViewTextBoxColumn,
            this.mainImagePathDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.serviceBindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(26, 12);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(806, 200);
            this.dataGridView2.TabIndex = 6;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "ID";
            this.dataGridViewTextBoxColumn1.HeaderText = "ID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // titleDataGridViewTextBoxColumn
            // 
            this.titleDataGridViewTextBoxColumn.DataPropertyName = "Title";
            this.titleDataGridViewTextBoxColumn.HeaderText = "Title";
            this.titleDataGridViewTextBoxColumn.Name = "titleDataGridViewTextBoxColumn";
            // 
            // costDataGridViewTextBoxColumn
            // 
            this.costDataGridViewTextBoxColumn.DataPropertyName = "Cost";
            this.costDataGridViewTextBoxColumn.HeaderText = "Cost";
            this.costDataGridViewTextBoxColumn.Name = "costDataGridViewTextBoxColumn";
            // 
            // durationInSecondsDataGridViewTextBoxColumn
            // 
            this.durationInSecondsDataGridViewTextBoxColumn.DataPropertyName = "DurationInSeconds";
            this.durationInSecondsDataGridViewTextBoxColumn.HeaderText = "DurationInSeconds";
            this.durationInSecondsDataGridViewTextBoxColumn.Name = "durationInSecondsDataGridViewTextBoxColumn";
            // 
            // descriptionDataGridViewTextBoxColumn
            // 
            this.descriptionDataGridViewTextBoxColumn.DataPropertyName = "Description";
            this.descriptionDataGridViewTextBoxColumn.HeaderText = "Description";
            this.descriptionDataGridViewTextBoxColumn.Name = "descriptionDataGridViewTextBoxColumn";
            // 
            // discountDataGridViewTextBoxColumn
            // 
            this.discountDataGridViewTextBoxColumn.DataPropertyName = "Discount";
            this.discountDataGridViewTextBoxColumn.HeaderText = "Discount";
            this.discountDataGridViewTextBoxColumn.Name = "discountDataGridViewTextBoxColumn";
            // 
            // mainImagePathDataGridViewTextBoxColumn
            // 
            this.mainImagePathDataGridViewTextBoxColumn.DataPropertyName = "MainImagePath";
            this.mainImagePathDataGridViewTextBoxColumn.HeaderText = "MainImagePath";
            this.mainImagePathDataGridViewTextBoxColumn.Name = "mainImagePathDataGridViewTextBoxColumn";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(53, 227);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(148, 31);
            this.button1.TabIndex = 104;
            this.button1.Text = "Записать на услугу";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(855, 272);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.Выход);
            this.Name = "Form3";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.b1DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productSaleBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.serviceBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.serviceBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Выход;
        private b1DataSet b1DataSet;
        private System.Windows.Forms.BindingSource productSaleBindingSource;
        private b1DataSetTableAdapters.ProductSaleTableAdapter productSaleTableAdapter;
        private System.Windows.Forms.BindingSource serviceBindingSource;
        private b1DataSetTableAdapters.ServiceTableAdapter serviceTableAdapter;
        private System.Windows.Forms.BindingSource clientBindingSource;
        private b1DataSetTableAdapters.ClientTableAdapter clientTableAdapter;
        private System.Windows.Forms.BindingSource serviceBindingSource1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn titleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn costDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn durationInSecondsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn discountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mainImagePathDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button1;
    }
}