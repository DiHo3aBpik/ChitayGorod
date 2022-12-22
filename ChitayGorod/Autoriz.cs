using ChitayGorod.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChitayGorod
{
  
    public partial class Autoriz : Form

    {
        public Autoriz()
        {
            InitializeComponent();
        }
       
        Model1 db = new Model1();

        public Пользователи USER { get; private set; }

        private void buttonReg_Click(object sender, EventArgs e)
        {
            Reg reg = new Reg();
            reg.Show();
            this.Hide();
        }

        private void Autoriz_Load(object sender, EventArgs e)
        {
            Random rnd = new Random();
            string text = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz1234567890";
            for (int i = 0; i<5; i++)
            {
                CapchaLabel.Text += text[rnd.Next(text.Length)];
            }
        }

        private void buttonNext_Click(object sender, EventArgs e)
        {
            if (LoginTextBox.Text == "" || PassTextBox.Text == "")
            {
                MessageBox.Show("Нужно задать логин и пароль");
                return;
            }
            if (CapchaTextBox.Text != CapchaLabel.Text)
            {
                MessageBox.Show("Капча неверная");
                return;
            }
            Пользователи usr = db.Пользователи.Find(LoginTextBox.Text);
            if ((usr != null) && (usr.Пароль == PassTextBox.Text))
            {
                USER = usr;
                if (usr.Роль == "Покупатель")
                {
                    BuyerForm buyer = new BuyerForm();
                    buyer.Show();
                    this.Hide();
                }
                else if (usr.Роль == "Продавец")
                {
                    SotrudnikiForm sotr = new SotrudnikiForm();
                    sotr.Show();
                    this.Hide();
                }
                else if (usr.Роль == "Менеджер")
                {
                    ManagerForm manager = new ManagerForm();
                    manager.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show($"Роли {usr.Роль} в системе нет");
                    return;
                }
            }
            else
            {
                MessageBox.Show("Пользователя с таким логином и паролем не существует");
                return;
            }
        }
    }
}
