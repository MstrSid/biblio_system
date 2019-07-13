using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;
using System.Data.SqlClient;

namespace Kartoteka
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string path = @"Base\bibl.db"; //Путь к файлу БД
            var conn = new SQLiteConnection(@"Data Source = "+path+"; Version = 3");
            conn.Open();
            SQLiteCommand cmd = new SQLiteCommand("select * from auth where login = '" + textBox1.Text + "' and pass ='" + textBox2.Text + "'", conn);
            cmd.ExecuteNonQuery();
            SQLiteDataReader dr = cmd.ExecuteReader();
            int count = 0;
            while (dr.Read())
            {
                count = count + 1;
            }
            if (count == 1)
            {
                Main frm = new Main();
                frm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Логин или пароль неверны!");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                button1_Click(sender, e);
            }
        }
    }
}
