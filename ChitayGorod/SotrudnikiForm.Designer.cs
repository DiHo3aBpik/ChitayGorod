namespace ChitayGorod
{
    partial class SotrudnikiForm
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.chitayGorodDataSet1 = new ChitayGorod.ChitayGorodDataSet1();
            this.книгиBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.книгиTableAdapter = new ChitayGorod.ChitayGorodDataSet1TableAdapters.КнигиTableAdapter();
            this.наименованиеDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.артикулDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.возрастныеОграниченияDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.количествоСтраницDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ценаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.описаниеDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.обложкаКнигиDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chitayGorodDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.книгиBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.наименованиеDataGridViewTextBoxColumn,
            this.артикулDataGridViewTextBoxColumn,
            this.возрастныеОграниченияDataGridViewTextBoxColumn,
            this.количествоСтраницDataGridViewTextBoxColumn,
            this.ценаDataGridViewTextBoxColumn,
            this.описаниеDataGridViewTextBoxColumn,
            this.обложкаКнигиDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.книгиBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(27, 106);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(854, 351);
            this.dataGridView1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(27, 463);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(127, 39);
            this.button1.TabIndex = 1;
            this.button1.Text = "Добавить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.Location = new System.Drawing.Point(160, 464);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(127, 38);
            this.button2.TabIndex = 2;
            this.button2.Text = "Изменить";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button3.Location = new System.Drawing.Point(621, 464);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(127, 39);
            this.button3.TabIndex = 3;
            this.button3.Text = "Удалить";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button4.Location = new System.Drawing.Point(754, 464);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(127, 38);
            this.button4.TabIndex = 4;
            this.button4.Text = "Выход";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(97)))), ((int)(((byte)(181)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(905, 100);
            this.panel1.TabIndex = 5;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(97)))), ((int)(((byte)(181)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 517);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(905, 100);
            this.panel2.TabIndex = 6;
            // 
            // chitayGorodDataSet1
            // 
            this.chitayGorodDataSet1.DataSetName = "ChitayGorodDataSet1";
            this.chitayGorodDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // книгиBindingSource
            // 
            this.книгиBindingSource.DataMember = "Книги";
            this.книгиBindingSource.DataSource = this.chitayGorodDataSet1;
            // 
            // книгиTableAdapter
            // 
            this.книгиTableAdapter.ClearBeforeFill = true;
            // 
            // наименованиеDataGridViewTextBoxColumn
            // 
            this.наименованиеDataGridViewTextBoxColumn.DataPropertyName = "Наименование";
            this.наименованиеDataGridViewTextBoxColumn.HeaderText = "Наименование";
            this.наименованиеDataGridViewTextBoxColumn.Name = "наименованиеDataGridViewTextBoxColumn";
            // 
            // артикулDataGridViewTextBoxColumn
            // 
            this.артикулDataGridViewTextBoxColumn.DataPropertyName = "Артикул";
            this.артикулDataGridViewTextBoxColumn.HeaderText = "Артикул";
            this.артикулDataGridViewTextBoxColumn.Name = "артикулDataGridViewTextBoxColumn";
            // 
            // возрастныеОграниченияDataGridViewTextBoxColumn
            // 
            this.возрастныеОграниченияDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.возрастныеОграниченияDataGridViewTextBoxColumn.DataPropertyName = "ВозрастныеОграничения";
            this.возрастныеОграниченияDataGridViewTextBoxColumn.HeaderText = "ВозрастныеОграничения";
            this.возрастныеОграниченияDataGridViewTextBoxColumn.Name = "возрастныеОграниченияDataGridViewTextBoxColumn";
            this.возрастныеОграниченияDataGridViewTextBoxColumn.Width = 160;
            // 
            // количествоСтраницDataGridViewTextBoxColumn
            // 
            this.количествоСтраницDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.количествоСтраницDataGridViewTextBoxColumn.DataPropertyName = "КоличествоСтраниц";
            this.количествоСтраницDataGridViewTextBoxColumn.HeaderText = "КоличествоСтраниц";
            this.количествоСтраницDataGridViewTextBoxColumn.Name = "количествоСтраницDataGridViewTextBoxColumn";
            this.количествоСтраницDataGridViewTextBoxColumn.Width = 133;
            // 
            // ценаDataGridViewTextBoxColumn
            // 
            this.ценаDataGridViewTextBoxColumn.DataPropertyName = "Цена";
            this.ценаDataGridViewTextBoxColumn.HeaderText = "Цена";
            this.ценаDataGridViewTextBoxColumn.Name = "ценаDataGridViewTextBoxColumn";
            // 
            // описаниеDataGridViewTextBoxColumn
            // 
            this.описаниеDataGridViewTextBoxColumn.DataPropertyName = "Описание";
            this.описаниеDataGridViewTextBoxColumn.HeaderText = "Описание";
            this.описаниеDataGridViewTextBoxColumn.Name = "описаниеDataGridViewTextBoxColumn";
            // 
            // обложкаКнигиDataGridViewTextBoxColumn
            // 
            this.обложкаКнигиDataGridViewTextBoxColumn.DataPropertyName = "ОбложкаКниги";
            this.обложкаКнигиDataGridViewTextBoxColumn.HeaderText = "ОбложкаКниги";
            this.обложкаКнигиDataGridViewTextBoxColumn.Name = "обложкаКнигиDataGridViewTextBoxColumn";
            // 
            // SotrudnikiForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.ClientSize = new System.Drawing.Size(905, 617);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "SotrudnikiForm";
            this.Text = "SotrudnikiForm";
            this.Load += new System.EventHandler(this.SotrudnikiForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chitayGorodDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.книгиBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private ChitayGorodDataSet1 chitayGorodDataSet1;
        private System.Windows.Forms.BindingSource книгиBindingSource;
        private ChitayGorodDataSet1TableAdapters.КнигиTableAdapter книгиTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn наименованиеDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn артикулDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn возрастныеОграниченияDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn количествоСтраницDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ценаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn описаниеDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn обложкаКнигиDataGridViewTextBoxColumn;
    }
}