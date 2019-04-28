using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SQLite;
using System.Data.SqlClient;

namespace Kartoteka
{
    public partial class Streets : Form
    {

        static string path = @"Base\bibl.db"; //Путь к файлу БД
        SQLiteConnection con = new SQLiteConnection("Data Source=" + path + ";Version=3;new=False;foreign keys=true;datetimeformat=CurrentCulture");
        SQLiteCommand cmd;
        SQLiteDataAdapter adapt;
        public Streets()
        {
            InitializeComponent();
        }
        public void show_streets()
        {
            con.Open();
            DataTable dt = new DataTable();
            SQLiteDataAdapter adapt = new SQLiteDataAdapter("select name from streets", con);
            adapt.Fill(dt);
            streetstbl.DataSource = dt;
            con.Close();
            streetstbl.Columns[0].HeaderText = "Улица";
            streetstbl.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        private void clear_data()
        {

            txt_Street.Text = "";
        }

            private void Streets_Shown(object sender, EventArgs e)
        {
            show_streets();
        }

        private void streetstbl_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            Filial readers = this.Owner as Filial;
            readers.txt_Ulica.Text = streetstbl.Rows[e.RowIndex].Cells[0].Value.ToString();
            Close();
        }

        private void addbtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (txt_Street.Text != "")
                {
                    cmd = new SQLiteCommand("insert into streets(name) values(@name)", con);
                    con.Open();
                    cmd.Parameters.AddWithValue("@name", txt_Street.Text);
                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Добавлено.");
                    show_streets();
                    clear_data();
                }
                else
                {
                    MessageBox.Show("Проверьте введенные данные!");
                }
            }
            catch
            {
                MessageBox.Show("Ошибка.");
            }
            }

        private void updbtn_Click(object sender, EventArgs e)
        {

        }

        private void streetstbl_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            txt_Street.Text = streetstbl.Rows[e.RowIndex].Cells[0].Value.ToString();
        }

        private void delbtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (txt_Street.Text != "")
                {
                    cmd = new SQLiteCommand("delete from streets where name=@name", con);
                    con.Open();
                    cmd.Parameters.AddWithValue("@name", txt_Street.Text);
                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Удалено.");
                    show_streets();
                    clear_data();
                }
                else
                {
                    MessageBox.Show("Проверьте введенные данные!");
                }
            }
            catch
            {
                MessageBox.Show("Ошибка.");
            }
        }
    }
}
