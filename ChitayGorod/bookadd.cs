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
    public partial class bookadd : Form
    {
        public Model1 database { get; set; }
        public bookadd()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox2.Text == "" || textBox7.Text == "" || textBox8.Text == "" ||
              textBox6.Text == "" || textBox3.Text == "" || textBox11.Text == "" ||
              textBox1.Text == "" ||
              textBox4.Text == "" || textBox9.Text == "" ||
              textBox10.Text == "" || textBox5.Text == "")
            {
                MessageBox.Show("Необходимо ввести все требуемые данные!");
                return;
            }

            int IDBook = 0;
            int IDProduction = 0;
            int IDGenre = 0;
            int IDStell = 0;
            bool values_not_null = int.TryParse(textBox1.Text, out IDBook);
            bool values_not_null1 = int.TryParse(textBox2.Text, out IDProduction);
            bool values_not_null2 = int.TryParse(textBox3.Text, out IDGenre);
            bool values_not_null3 = int.TryParse(textBox4.Text, out IDStell);

            if (!values_not_null && !values_not_null1 && !values_not_null2 && !values_not_null3)
            {
                MessageBox.Show("Проверьте корректность введённых данных");
                return;
            }

            Книги book = new Книги();
            book.IDКниги = IDBook;
            book.IDИздательства = IDProduction;
            book.IDЖанра = IDGenre;
            book.IDСтеллажа = IDStell;
            book.Наименование = textBox5.Text;
            book.Артикул = Convert.ToInt32(textBox6.Text);
            book.ВозрастныеОграничения = textBox7.Text; ;
            book.КоличествоСтраниц = textBox8.Text;
            book.Цена = Convert.ToDecimal(textBox9.Text);
            book.Описание= textBox10.Text;
            book.ОбложкаКниги= textBox11.Text; ;
            database.Книги.Add(book);
            try
            {
                database.SaveChanges();
                DialogResult = DialogResult.OK;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.InnerException.InnerException.Message);
            }

        }
    }
}
