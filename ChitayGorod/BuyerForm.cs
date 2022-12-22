using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChitayGorod
{
    public partial class BuyerForm : Form
    {
        public BuyerForm()
        {
            InitializeComponent();
        }

        private void BuyerForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "chitayGorodDataSet.Книги". При необходимости она может быть перемещена или удалена.
            this.книгиTableAdapter.Fill(this.chitayGorodDataSet.Книги);

        }
    }
}
