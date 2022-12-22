using ChitayGorod.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChitayGorod
{
    public partial class SotrudnikiForm : Form
    {
        Model1 database = new Model1();
        public SotrudnikiForm()
        {
            InitializeComponent();
        }

        private void SotrudnikiForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "chitayGorodDataSet1.Книги". При необходимости она может быть перемещена или удалена.
            this.книгиTableAdapter.Fill(this.chitayGorodDataSet1.Книги);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            bookadd book = new bookadd();

            book.database = database;

            DialogResult dialogResult = book.ShowDialog();
            if (dialogResult == DialogResult.OK)
            {
                книгиBindingSource.DataSource = database.Книги.ToList();
            }
        }
    }
}
