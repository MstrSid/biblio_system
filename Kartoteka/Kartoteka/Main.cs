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
    public partial class Main : Form
    {
        static string path = @"Base\bibl.db"; //Путь к файлу БД
        SQLiteConnection con = new SQLiteConnection("Data Source=" + path + ";Version=3;new=False;foreign keys=true;datetimeformat=CurrentCulture");
        SQLiteCommand cmd;
        SQLiteDataAdapter adapt;
        public int regn = 0;
        public Main()
        {
            InitializeComponent();
        }

        public void show_readers()
        {
            con.Open();
            DataTable dt = new DataTable();
            SQLiteDataAdapter adapt = new SQLiteDataAdapter("select regn, filname from filial", con);
            adapt.Fill(dt);
            DataGrid.DataSource = dt;
            con.Close();
            DataGrid.Columns[0].HeaderText = "Рег. номер";
            DataGrid.Columns[1].HeaderText = "Филиал";
            DataGrid.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            DataGrid.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        private void count_readers()
        {

            con.Open();
            SQLiteCommand thisCommand = con.CreateCommand();
            thisCommand.CommandText = @"select count (regn) as vsego from filial";
            SQLiteDataReader thisReader = thisCommand.ExecuteReader();
            while (thisReader.Read())
            {
                label5.Text = thisReader["vsego"].ToString();
            }
            thisReader.Close();
            con.Close();

        }

        private void count_books()
        {
            con.Open();
            SQLiteCommand thisCommand = con.CreateCommand();
            thisCommand.CommandText = @"select count (shifr) as vsego from books";
            SQLiteDataReader thisReader = thisCommand.ExecuteReader();
            while (thisReader.Read())
            {
                label6.Text = thisReader["vsego"].ToString();
            }
            thisReader.Close();
            con.Close();
        }

        public void show_formular()
        {
            con.Open();
            DataTable dt = new DataTable();
            SQLiteDataAdapter adapt = new SQLiteDataAdapter("select cntbase.shifr,books.avtor, books.nazv, cntbase.data_pol,cntbase.data_inv from books,cntbase where cntbase.regn='" + regn + "' and cntbase.shifr=books.shifr",con);
            adapt.Fill(dt);
            cntbase.DataSource = dt;
            con.Close();
            cntbase.Columns[0].HeaderText = "Шифр";
            cntbase.Columns[1].HeaderText = "Автор";
            cntbase.Columns[2].HeaderText = "Название";
            cntbase.Columns[3].HeaderText = "Дата получения";
            cntbase.Columns[4].HeaderText = "Дата инвентаризации";
            cntbase.Columns[3].DefaultCellStyle.Format = "dd.MM.yyyy";
            cntbase.Columns[4].DefaultCellStyle.Format = "dd.MM.yyyy";
            cntbase.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            cntbase.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            cntbase.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            cntbase.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            cntbase.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            

        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            show_readers();
            count_readers();
            count_books();
           
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void DataGrid_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            
            regn = Int32.Parse(DataGrid.Rows[e.RowIndex].Cells[0].Value.ToString());
            show_formular();            
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
          
            }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            
                {
                regn = Int32.Parse(textBox1.Text);
                show_formular();
            }
    }

        private void button1_Click_2(object sender, EventArgs e)
        {
            if (regn >0)
            {
                Givebook givebook = new Givebook();
                givebook.Owner = this;
                givebook.Show();
            }
            else
            {
                MessageBox.Show("Не выбран филиал.");
            }
        }



        public void button1_Click_3(object sender, EventArgs e)
        {
            show_readers();
            count_books();
            count_readers();
        }


        private void Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }


        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Filial filial = new Filial();
            filial.Owner = this;
            filial.Show();
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            Books books = new Books();
            books.Owner = this;
            books.Show();

        }
    }
}
