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
    public partial class Givebook : Form
    {
        static string path = @"Base\bibl.db"; //Путь к файлу БД
        SQLiteConnection con = new SQLiteConnection("Data Source=" + path + ";Version=3;new=False;foreign keys=true;datetimeformat=CurrentCulture");
        SQLiteCommand cmd;
        SQLiteDataAdapter adapt;
        //ID variable used in Updating and Deleting Record  
        int shifr = 0;
        int regn;
        public Givebook()
        {
            InitializeComponent();
           

        }
        public void show_info_read()
        {
            con.Open();
            DataTable dt = new DataTable();
            SQLiteDataAdapter adapt = new SQLiteDataAdapter("select filial.regn, filial.filname, filial.type, filial.zaved from filial where regn='" + regn + "'", con);
            adapt.Fill(dt);
            readinftbl.DataSource = dt;
            con.Close();
            readinftbl.Columns[0].HeaderText = "Рег. номер";
            readinftbl.Columns[1].HeaderText = "Название";
            readinftbl.Columns[2].HeaderText = "Тип";
            readinftbl.Columns[3].HeaderText = "Заведующий";
            readinftbl.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            readinftbl.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            readinftbl.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            readinftbl.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }
        public void show_cntbase()
        {
            con.Open();
            DataTable dt = new DataTable();
            SQLiteDataAdapter adapt = new SQLiteDataAdapter("select cntbase.shifr,  books.nazv, books.avtor, cntbase.data_pol, cntbase.data_inv from cntbase, books where cntbase.regn='" + regn + "' and books.shifr=cntbase.shifr", con);
            adapt.Fill(dt);
            givebooktbl.DataSource = dt;
            con.Close();
            //givebooktbl.Columns[0].HeaderText = "Рег. номер";
            givebooktbl.Columns[0].HeaderText = "Инв. номер";
            givebooktbl.Columns[1].HeaderText = "Название";
            givebooktbl.Columns[2].HeaderText = "Автор";
            givebooktbl.Columns[3].HeaderText = "Дата получения";
            givebooktbl.Columns[4].HeaderText = "Дата инвентаризации";
            givebooktbl.Columns[3].DefaultCellStyle.Format = "dd.MM.yyyy";
            givebooktbl.Columns[4].DefaultCellStyle.Format = "dd.MM.yyyy";
            givebooktbl.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            givebooktbl.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            givebooktbl.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            givebooktbl.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            givebooktbl.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            //givebooktbl.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }
        private void clear_data()
        {
            txt_DPol.Value = DateTime.Now;
            txt_DInv.Value = DateTime.Now.AddDays(1);
            txt_Shifr.Text = "";
            //ID = 0;
        }

        private void givebooktbl_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {  
            //ID = Convert.ToInt32(givebooktbl.Rows[e.RowIndex].Cells[0].Value.ToString());
            //txt_Regn.Text = givebooktbl.Rows[e.RowIndex].Cells[0].Value.ToString();
            txt_DPol.Value = DateTime.Parse(givebooktbl.Rows[e.RowIndex].Cells[3].Value.ToString());
            txt_DInv.Value= DateTime.Parse(givebooktbl.Rows[e.RowIndex].Cells[4].Value.ToString());
            txt_Shifr.Text = givebooktbl.Rows[e.RowIndex].Cells[0].Value.ToString();
        }

    private void Givebook_Shown(object sender, EventArgs e)
        {
            Main main = this.Owner as Main;
            regn = main.regn;
            show_cntbase();
            show_info_read();
            txt_DPol.Value = DateTime.Now;
            txt_DInv.Value = DateTime.Now.AddDays(1);
            txt_Shifr.Text = "";

        }

        private void insertbtn_Click(object sender, EventArgs e)
        {

            try
            {
                if (txt_Shifr.Text != "")
                {
                    cmd = new SQLiteCommand("insert into cntbase(regn, data_pol, data_inv, shifr) values(@regn, @data_pol, @data_inv, @shifr)", con);
                    con.Open();
                    cmd.Parameters.AddWithValue("@regn", regn);
                    cmd.Parameters.AddWithValue("@data_pol", txt_DPol.Value);
                    cmd.Parameters.AddWithValue("@data_inv", txt_DInv.Value);
                    cmd.Parameters.AddWithValue("@shifr", txt_Shifr.Text);

                    cmd.ExecuteNonQuery();


                    con.Close();
                    MessageBox.Show("Книга записана.");
                    show_cntbase();
                    clear_data();
                }
                else
                {
                    MessageBox.Show("Проверьте введенные данные!");
                }
            }
            catch
            {
                MessageBox.Show("Такой книги не обнаружено");
            }
        }

        private void updatebtn_Click(object sender, EventArgs e)
        {
            if (txt_Shifr.Text != "")
            {
                cmd = new SQLiteCommand("update cntbase set regn=@regn, data_pol=@data_pol, data_inv=@data_inv, shifr=@shifr where shifr=@shifr", con);
                con.Open();
                //cmd.Parameters.AddWithValue("@id", ID);
                cmd.Parameters.AddWithValue("@regn", regn);
                cmd.Parameters.AddWithValue("@data_pol", txt_DPol.Value);
                cmd.Parameters.AddWithValue("@data_inv", txt_DInv.Value);
                cmd.Parameters.AddWithValue("@shifr", txt_Shifr.Text);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Информация обновлена.");
                con.Close();
                show_cntbase();
                clear_data();
            }
            else
            {
                MessageBox.Show("Выберите запись для корректировки");
            }
        }

        private void delbtn_Click(object sender, EventArgs e)
        {
            if (txt_Shifr.Text != "")
            {
                cmd = new SQLiteCommand("delete from cntbase where shifr=@shifr", con);
                con.Open();
                cmd.Parameters.AddWithValue("@shifr", txt_Shifr.Text);
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Книга удалена.");
                show_cntbase();
                clear_data();
            }
            else
            {
                MessageBox.Show("Выберите запись для возврата");
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
