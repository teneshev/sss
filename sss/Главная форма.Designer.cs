
namespace sss
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button9 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.titleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.costDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.durationInSecondsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.discountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mainImagePathDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.serviceBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.b1DataSet = new sss.b1DataSet();
            this.serviceTableAdapter = new sss.b1DataSetTableAdapters.ServiceTableAdapter();
            this.FilterLB = new System.Windows.Forms.Label();
            this.FilterCB = new System.Windows.Forms.ComboBox();
            this.Поиск = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.режимыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.обычныйToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.администраторToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.таблицыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.клиентToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.услугиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.записиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.serviceBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.b1DataSet)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(581, 211);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 13);
            this.label4.TabIndex = 124;
            this.label4.Text = "Mane";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(468, 212);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 13);
            this.label5.TabIndex = 123;
            this.label5.Text = "Discount";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(354, 212);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 13);
            this.label6.TabIndex = 122;
            this.label6.Text = "Description";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(231, 213);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 13);
            this.label3.TabIndex = 121;
            this.label3.Text = "DurationInSeconds";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(158, 213);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 13);
            this.label2.TabIndex = 120;
            this.label2.Text = "Cost";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(58, 213);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 13);
            this.label1.TabIndex = 119;
            this.label1.Text = "Title";
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(441, 232);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(100, 20);
            this.textBox5.TabIndex = 118;
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(547, 232);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(100, 20);
            this.textBox6.TabIndex = 117;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(335, 232);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 20);
            this.textBox4.TabIndex = 116;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(229, 232);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 115;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(123, 232);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 114;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(20, 232);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 113;
            // 
            // button9
            // 
            this.button9.BackColor = System.Drawing.Color.White;
            this.button9.Location = new System.Drawing.Point(653, 226);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(148, 31);
            this.button9.TabIndex = 112;
            this.button9.Text = "Добавить";
            this.button9.UseVisualStyleBackColor = false;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.White;
            this.button6.Location = new System.Drawing.Point(325, 281);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(148, 31);
            this.button6.TabIndex = 111;
            this.button6.Text = "Обновить";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.White;
            this.button7.Location = new System.Drawing.Point(171, 281);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(148, 31);
            this.button7.TabIndex = 110;
            this.button7.Text = "Удалить";
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.Color.White;
            this.button8.Location = new System.Drawing.Point(17, 281);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(148, 31);
            this.button8.TabIndex = 109;
            this.button8.Text = "Редактировать";
            this.button8.UseVisualStyleBackColor = false;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ActiveBorder;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.titleDataGridViewTextBoxColumn,
            this.costDataGridViewTextBoxColumn,
            this.durationInSecondsDataGridViewTextBoxColumn,
            this.descriptionDataGridViewTextBoxColumn,
            this.discountDataGridViewTextBoxColumn,
            this.mainImagePathDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.serviceBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(20, 38);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(774, 170);
            this.dataGridView1.TabIndex = 108;
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.ReadOnly = true;
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
            // serviceBindingSource
            // 
            this.serviceBindingSource.DataMember = "Service";
            this.serviceBindingSource.DataSource = this.b1DataSet;
            // 
            // b1DataSet
            // 
            this.b1DataSet.DataSetName = "b1DataSet";
            this.b1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // serviceTableAdapter
            // 
            this.serviceTableAdapter.ClearBeforeFill = true;
            // 
            // FilterLB
            // 
            this.FilterLB.AutoSize = true;
            this.FilterLB.Location = new System.Drawing.Point(859, 106);
            this.FilterLB.Name = "FilterLB";
            this.FilterLB.Size = new System.Drawing.Size(29, 13);
            this.FilterLB.TabIndex = 133;
            this.FilterLB.Text = "Filter";
            // 
            // FilterCB
            // 
            this.FilterCB.FormattingEnabled = true;
            this.FilterCB.Items.AddRange(new object[] {
            "от 0 до 5%",
            "от 5% до 15%",
            "от 15% до 30%",
            "от 30% до 70%",
            "от 70% до 100%",
            "Все"});
            this.FilterCB.Location = new System.Drawing.Point(819, 122);
            this.FilterCB.Name = "FilterCB";
            this.FilterCB.Size = new System.Drawing.Size(121, 21);
            this.FilterCB.TabIndex = 132;
            this.FilterCB.SelectedIndexChanged += new System.EventHandler(this.FilterCB_SelectedIndexChanged);
            // 
            // Поиск
            // 
            this.Поиск.AutoSize = true;
            this.Поиск.Location = new System.Drawing.Point(859, 67);
            this.Поиск.Name = "Поиск";
            this.Поиск.Size = new System.Drawing.Size(39, 13);
            this.Поиск.TabIndex = 131;
            this.Поиск.Text = "Поиск";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "0",
            "1",
            "2"});
            this.comboBox1.Location = new System.Drawing.Point(171, 0);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 134;
            this.comboBox1.Visible = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.режимыToolStripMenuItem,
            this.таблицыToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(952, 24);
            this.menuStrip1.TabIndex = 135;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // режимыToolStripMenuItem
            // 
            this.режимыToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.обычныйToolStripMenuItem,
            this.администраторToolStripMenuItem});
            this.режимыToolStripMenuItem.Name = "режимыToolStripMenuItem";
            this.режимыToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.режимыToolStripMenuItem.Text = "Режимы";
            // 
            // обычныйToolStripMenuItem
            // 
            this.обычныйToolStripMenuItem.Name = "обычныйToolStripMenuItem";
            this.обычныйToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.обычныйToolStripMenuItem.Text = "Обычный";
            // 
            // администраторToolStripMenuItem
            // 
            this.администраторToolStripMenuItem.Name = "администраторToolStripMenuItem";
            this.администраторToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.администраторToolStripMenuItem.Text = "Администратор";
            // 
            // таблицыToolStripMenuItem
            // 
            this.таблицыToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.клиентToolStripMenuItem,
            this.услугиToolStripMenuItem,
            this.записиToolStripMenuItem});
            this.таблицыToolStripMenuItem.Name = "таблицыToolStripMenuItem";
            this.таблицыToolStripMenuItem.Size = new System.Drawing.Size(68, 20);
            this.таблицыToolStripMenuItem.Text = "Таблицы";
            this.таблицыToolStripMenuItem.Click += new System.EventHandler(this.таблицыToolStripMenuItem_Click);
            // 
            // клиентToolStripMenuItem
            // 
            this.клиентToolStripMenuItem.Name = "клиентToolStripMenuItem";
            this.клиентToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.клиентToolStripMenuItem.Text = "Клиент";
            // 
            // услугиToolStripMenuItem
            // 
            this.услугиToolStripMenuItem.Name = "услугиToolStripMenuItem";
            this.услугиToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.услугиToolStripMenuItem.Text = "Услуги";
            // 
            // записиToolStripMenuItem
            // 
            this.записиToolStripMenuItem.Name = "записиToolStripMenuItem";
            this.записиToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.записиToolStripMenuItem.Text = "Записи";
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "0",
            "1",
            "2"});
            this.comboBox2.Location = new System.Drawing.Point(234, 0);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 21);
            this.comboBox2.TabIndex = 136;
            this.comboBox2.Visible = false;
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(819, 83);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(121, 20);
            this.textBox7.TabIndex = 137;
            this.textBox7.TextChanged += new System.EventHandler(this.textBox7_TextChanged_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(952, 323);
            this.Controls.Add(this.textBox7);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.FilterLB);
            this.Controls.Add(this.FilterCB);
            this.Controls.Add(this.Поиск);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.dataGridView1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Главная форма";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.serviceBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.b1DataSet)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.DataGridView dataGridView1;
        private b1DataSet b1DataSet;
        private System.Windows.Forms.BindingSource serviceBindingSource;
        private b1DataSetTableAdapters.ServiceTableAdapter serviceTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn titleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn costDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn durationInSecondsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn discountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mainImagePathDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label FilterLB;
        private System.Windows.Forms.ComboBox FilterCB;
        private System.Windows.Forms.Label Поиск;
        public System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem режимыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem обычныйToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem администраторToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem таблицыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem клиентToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem услугиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem записиToolStripMenuItem;
        public System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.TextBox textBox7;
    }
}

