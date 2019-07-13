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
    public partial class Filial : Form
    {

        static string path = @"Base\bibl.db"; //Путь к файлу БД
        SQLiteConnection con = new SQLiteConnection("Data Source=" + path + ";Version=3;new=False;foreign keys=true;datetimeformat=CurrentCulture");
        SQLiteCommand cmd;
        SQLiteDataAdapter adapt;
        public Filial()
        {
            InitializeComponent();
        }

        public void show_readers()
        {
            con.Open();
            DataTable dt = new DataTable();
            SQLiteDataAdapter adapt = new SQLiteDataAdapter("select distinct filial.regn, filial.filname, filial.type, filial.zaved, adresid.streetid, adresid.house, adresid.tel from filial, zaved, adresid, streets where filial.regn=adresid.regn", con);
            adapt.Fill(dt);
            readerstbl.DataSource = dt;
            con.Close();

            readerstbl.Columns[0].HeaderText = "Номер филиала";
            readerstbl.Columns[1].HeaderText = "Название филиала";
            readerstbl.Columns[2].HeaderText = "Тип";
            readerstbl.Columns[3].HeaderText = "Заведующий";
            readerstbl.Columns[4].HeaderText = "Улица";
            readerstbl.Columns[5].HeaderText = "Дом";
            readerstbl.Columns[6].HeaderText = "Телефон";
            readerstbl.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            readerstbl.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            readerstbl.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            readerstbl.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            readerstbl.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            readerstbl.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            readerstbl.Columns[6].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        private void clear_data()
        {

            txt_Regn.Text = "";
            txt_Nazv.Text = "";
            txt_Type.Text = "";
            txt_Zaved.Text = "";
            txt_Ulica.Text = "";
            txt_Dom.Text = "";
            txt_Tel.Text = "";
        }

        private void Readers_Shown(object sender, EventArgs e)
        {
            show_readers();
        }

        private void addbtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (txt_Nazv.Text != "")
                {
                    cmd = new SQLiteCommand("insert into filial(filname, type, zaved) values(@filname, @type, @zaved)", con);
                    con.Open();
                    cmd.Parameters.AddWithValue("@filname", txt_Nazv.Text);
                    cmd.Parameters.AddWithValue("@type", txt_Type.Text);
                    cmd.Parameters.AddWithValue("@zaved", txt_Zaved.Text);
                    cmd.ExecuteNonQuery();
                    con.Close();

                    cmd = new SQLiteCommand("select regn from filial where regn=(select max(regn) from filial)", con);
                    con.Open();
                    string regn = cmd.ExecuteScalar().ToString();
                    int regn2 = Int32.Parse(regn);
                    cmd.ExecuteNonQuery();
                    con.Close();

                    cmd = new SQLiteCommand("insert into adresid(regn,streetid, house, tel) values(@regn, @streetid, @house, @tel)", con);
                    con.Open();
                    cmd.Parameters.AddWithValue("@regn", regn2);
                    cmd.Parameters.AddWithValue("@streetid", txt_Ulica.Text);
                    cmd.Parameters.AddWithValue("@house", txt_Dom.Text);
                    cmd.Parameters.AddWithValue("@tel", txt_Tel.Text);

                    cmd.ExecuteNonQuery();


                    con.Close();
                    MessageBox.Show("Добавлено.");
                    show_readers();
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

        private void readerstbl_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {

            txt_Regn.Text = readerstbl.Rows[e.RowIndex].Cells[0].Value.ToString();
            txt_Nazv.Text = readerstbl.Rows[e.RowIndex].Cells[1].Value.ToString();
            txt_Type.Text = readerstbl.Rows[e.RowIndex].Cells[2].Value.ToString();
            txt_Zaved.Text = readerstbl.Rows[e.RowIndex].Cells[3].Value.ToString();
            txt_Ulica.Text = readerstbl.Rows[e.RowIndex].Cells[4].Value.ToString();
            txt_Dom.Text = readerstbl.Rows[e.RowIndex].Cells[5].Value.ToString();
            txt_Tel.Text = readerstbl.Rows[e.RowIndex].Cells[6].Value.ToString();


        }

        private void updbtn_Click(object sender, EventArgs e)
        {

            if (txt_Nazv.Text != "")
            {
                cmd = new SQLiteCommand("update filial set filname=@filname, type=@type, zaved=@zaved where regn=@regn", con);
                con.Open();
                cmd.Parameters.AddWithValue("@regn", txt_Regn.Text);
                cmd.Parameters.AddWithValue("@filname", txt_Nazv.Text);
                cmd.Parameters.AddWithValue("@type", txt_Type.Text);
                cmd.Parameters.AddWithValue("@zaved", txt_Zaved.Text);
                cmd.ExecuteNonQuery();
                con.Close();

                cmd = new SQLiteCommand("update adresid set streetid=@streetid, house=@house, tel=@tel where regn=@regn", con);
                 con.Open();
                 cmd.Parameters.AddWithValue("@regn", txt_Regn);
                 cmd.Parameters.AddWithValue("@streetid", txt_Ulica.Text);
                 cmd.Parameters.AddWithValue("@house", txt_Dom.Text);
                 cmd.Parameters.AddWithValue("@tel", txt_Tel.Text);

                 cmd.ExecuteNonQuery();


                 con.Close();
                MessageBox.Show("Обновлено.");
                show_readers();
                clear_data();
            }
            else
            {
                MessageBox.Show("Проверьте введенные данные!");
            }
         
        }

        private void spravbtn_Click(object sender, EventArgs e)
        {
            Streets streets = new Streets();
            streets.Owner = this;
            streets.Show();
        }

        private void delbtn_Click(object sender, EventArgs e)
        {
            if (txt_Regn.Text != "")
            {


                cmd = new SQLiteCommand("delete from adresid where regn=@regn", con);
                con.Open();
                cmd.Parameters.AddWithValue("@regn", txt_Regn);
                cmd.ExecuteNonQuery();


                con.Close();

                cmd = new SQLiteCommand("delete from filial where regn=@regn", con);
                con.Open();
                cmd.Parameters.AddWithValue("@regn", txt_Regn.Text);
                cmd.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("Удалено.");
                show_readers();
                clear_data();
            }
            else
            {
                MessageBox.Show("Проверьте введенные данные!");
            }

        }

        private void spravmrab_Click(object sender, EventArgs e)
        {
            Zaved zaved = new Zaved();
            zaved.Owner = this;
            zaved.Show();
        }

        private void Readers_FormClosing(object sender, FormClosingEventArgs e)
        {
         
        }
    }
}
