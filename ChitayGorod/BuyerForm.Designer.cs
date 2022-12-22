namespace ChitayGorod
{
    partial class BuyerForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.chitayGorodDataSet = new ChitayGorod.ChitayGorodDataSet();
            this.книгиBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.книгиTableAdapter = new ChitayGorod.ChitayGorodDataSetTableAdapters.КнигиTableAdapter();
            this.panel2 = new System.Windows.Forms.Panel();
            this.книгиBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.наименованиеDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.артикулDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.возрастныеОграниченияDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.количествоСтраницDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ценаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.описаниеDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.обложкаКнигиDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chitayGorodDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.книгиBindingSource1)).BeginInit();
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
            this.dataGridView1.DataSource = this.книгиBindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(12, 116);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(840, 356);
            this.dataGridView1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(97)))), ((int)(((byte)(181)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(873, 100);
            this.panel1.TabIndex = 1;
            // 
            // chitayGorodDataSet
            // 
            this.chitayGorodDataSet.DataSetName = "ChitayGorodDataSet";
            this.chitayGorodDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // книгиBindingSource1
            // 
            this.книгиBindingSource1.DataMember = "Книги";
            this.книгиBindingSource1.DataSource = this.chitayGorodDataSet;
            // 
            // книгиTableAdapter
            // 
            this.книгиTableAdapter.ClearBeforeFill = true;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(97)))), ((int)(((byte)(181)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 488);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(873, 100);
            this.panel2.TabIndex = 2;
            // 
            // книгиBindingSource
            // 
            this.книгиBindingSource.DataSource = typeof(ChitayGorod.Data.Книги);
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
            // BuyerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.ClientSize = new System.Drawing.Size(873, 588);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "BuyerForm";
            this.Text = "BuyerForm";
            this.Load += new System.EventHandler(this.BuyerForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chitayGorodDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.книгиBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.книгиBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource книгиBindingSource;
        private System.Windows.Forms.Panel panel1;
        private ChitayGorodDataSet chitayGorodDataSet;
        private System.Windows.Forms.BindingSource книгиBindingSource1;
        private ChitayGorodDataSetTableAdapters.КнигиTableAdapter книгиTableAdapter;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridViewTextBoxColumn наименованиеDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn артикулDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn возрастныеОграниченияDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn количествоСтраницDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ценаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn описаниеDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn обложкаКнигиDataGridViewTextBoxColumn;
    }
}