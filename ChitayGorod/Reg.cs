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
    public partial class Reg : Form
    {
        Model1 db = new Model1();
        public Reg()
        {
            InitializeComponent();
        }

        private void buttonReg_Click(object sender, EventArgs e)
        {
            if (LoginTextBox.Text == "" || PassTextBox.Text == "" || RoleTextBox.Text == "" || NameTextBox.Text == "")
            {
                MessageBox.Show("Нужно заполнить все данные");
                return;
            }
            Пользователи usr = db.Пользователи.Find(LoginTextBox.Text);
            if (usr != null)
            {
                MessageBox.Show("Пользователь с таким логином существует");
                return;
            }
            usr = new Пользователи();
            usr.Логин = LoginTextBox.Text;
            usr.Пароль = PassTextBox.Text;
            usr.Роль = RoleTextBox.Text;
            usr.Имя = NameTextBox.Text;
            db.Пользователи.Add(usr);
            try
            {
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
            MessageBox.Show("Пользователь" + usr.Логин + "Зарегистрирован");
            Autoriz auth = new Autoriz();
            this.Close();
            return;
        }
    }
}
