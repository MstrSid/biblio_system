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
    public partial class Zaved : Form
    {
        static string path = @"Base\bibl.db"; //Путь к файлу БД
        SQLiteConnection con = new SQLiteConnection("Data Source=" + path + ";Version=3;new=False;foreign keys=true;datetimeformat=CurrentCulture");
        SQLiteCommand cmd;
        SQLiteDataAdapter adapt;
        public Zaved()
        {
            InitializeComponent();
        }

        public void show_mrab()
        {
            con.Open();
            DataTable dt = new DataTable();
            SQLiteDataAdapter adapt = new SQLiteDataAdapter("select zaved from zaved", con);
            adapt.Fill(dt);
            mrabtbl.DataSource = dt;
            con.Close();
            mrabtbl.Columns[0].HeaderText = "Инфо";
            mrabtbl.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }
        private void clear_data()
        {

            txt_Zaved.Text = "";
        }

        private void Mrab_Shown(object sender, EventArgs e)
        {
            show_mrab();
        }

        private void mrabtbl_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Filial filial = this.Owner as Filial;
            filial.txt_Zaved.Text = mrabtbl.Rows[e.RowIndex].Cells[0].Value.ToString();
            Close();
        }

        private void addbtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (txt_Zaved.Text != "")
                {
                    cmd = new SQLiteCommand("insert into zaved(zaved) values(@zaved)", con);
                    con.Open();
                    cmd.Parameters.AddWithValue("@zaved", txt_Zaved.Text);
                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Добавлено.");
                    show_mrab();
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

        private void delbtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (txt_Zaved.Text != "")
                {
                    cmd = new SQLiteCommand("delete from zaved where zaved=@zaved", con);
                    con.Open();
                    cmd.Parameters.AddWithValue("@zaved", txt_Zaved.Text);
                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Удалено.");
                    show_mrab();
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

        private void mrabtbl_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void mrabtbl_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            txt_Zaved.Text = mrabtbl.Rows[e.RowIndex].Cells[0].Value.ToString();
        }
    }
}
