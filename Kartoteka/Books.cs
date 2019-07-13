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
using System.IO;
using System.Reflection;
using System.Diagnostics;
using Microsoft.Office.Interop.Excel;


namespace Kartoteka
{
    public partial class Books : Form
    {
        static string path = @"Base\bibl.db"; //Путь к файлу БД
        SQLiteConnection con = new SQLiteConnection("Data Source=" + path + ";Version=3;new=False;foreign keys=true;datetimeformat=CurrentCulture");
        SQLiteCommand cmd;
        SQLiteDataAdapter adapt;

        public object DataGridClipboardCopyMode { get; private set; }

        public Books()
        {
            InitializeComponent();
        }

        public void show_books()
        {
            con.Open();
            System.Data.DataTable dt = new System.Data.DataTable();
            SQLiteDataAdapter adapt = new SQLiteDataAdapter("select shifr, avtor, nazv from books", con);
            adapt.Fill(dt);
            bookstbl.DataSource = dt;
            con.Close();
            bookstbl.Columns[0].HeaderText = "Инв. №";
            bookstbl.Columns[1].HeaderText = "Автор";
            bookstbl.Columns[2].HeaderText = "Название";
            bookstbl.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            bookstbl.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            bookstbl.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

  
        private void clear_data()
        {

            txt_Shifr.Text = "";
            txt_Avtor.Text = "";
            txt_Nazv.Text = "";
        }

      

        private void addbtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (txt_Shifr.Text != "" && txt_Nazv.Text != "")
                {
                    cmd = new SQLiteCommand("insert into books(shifr, avtor, nazv) values(@shifr, @avtor, @nazv)", con);
                    con.Open();
                    cmd.Parameters.AddWithValue("@shifr", txt_Shifr.Text);
                    cmd.Parameters.AddWithValue("@avtor", txt_Avtor.Text);
                    cmd.Parameters.AddWithValue("@nazv", txt_Nazv.Text);
                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Добавлено.");
                    show_books();
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

        private void Books_Shown(object sender, EventArgs e)
        {
            show_books();
        }

        private void delbtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (txt_Shifr.Text != "" && txt_Nazv.Text != "")
                {
                    cmd = new SQLiteCommand("delete from books where shifr=@shifr", con);
                    con.Open();
                    cmd.Parameters.AddWithValue("@shifr", txt_Shifr.Text);
                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Книга списана.");
                    show_books();
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

        private void bookstbl_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            txt_Shifr.Text = bookstbl.Rows[e.RowIndex].Cells[0].Value.ToString();
            txt_Avtor.Text = bookstbl.Rows[e.RowIndex].Cells[1].Value.ToString();
            txt_Nazv.Text = bookstbl.Rows[e.RowIndex].Cells[2].Value.ToString();
        }

        private void updbtn_Click(object sender, EventArgs e)
        {
            if (txt_Shifr.Text != "" && txt_Nazv.Text != "")
            {
                cmd = new SQLiteCommand("update books set shifr=@shifr, avtor=@avtor, nazv=@nazv where shifr=@shifr", con);
                con.Open();
                cmd.Parameters.AddWithValue("@shifr", txt_Shifr.Text);
                cmd.Parameters.AddWithValue("@avtor", txt_Avtor.Text);
                cmd.Parameters.AddWithValue("@nazv", txt_Nazv.Text);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Информация обновлена.");
                con.Close();
                show_books();
                clear_data();
            }
            else
            {
                MessageBox.Show("Выберите запись для корректировки");
            }
        }

        private void exportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Microsoft.Office.Interop.Excel.Application Exl = new Microsoft.Office.Interop.Excel.Application();
            Microsoft.Office.Interop.Excel.Workbook wb;

            XlReferenceStyle RefStyle = Exl.ReferenceStyle;
            Exl.Visible = true;

            String TemplatePath = System.Windows.Forms.Application.StartupPath + @"\Экспорт данных.xlt";
            try
            {
                wb = Exl.Workbooks.Add(TemplatePath); // !!! 
            }
            catch (System.Exception ex)
            {
                throw new Exception("Не удалось загрузить шаблон для экспорта " + TemplatePath + "\n" + ex.Message);
            }
            Worksheet ws = wb.Worksheets.get_Item(1) as Worksheet;
            for (int j = 0; j < bookstbl.Columns.Count; ++j)
            {
                (ws.Cells[1, j + 1] as Range).Value2 = bookstbl.Columns[j].HeaderText;
                for (int i = 0; i < bookstbl.Rows.Count; ++i)
                {
                    object Val = bookstbl.Rows[i].Cells[j].Value;
                    if (Val != null)
                        (ws.Cells[i + 2, j + 1] as Range).Value2 = Val.ToString();
                }
            }
            ws.Columns.EntireColumn.AutoFit();
            Exl.ReferenceStyle = RefStyle;
            ReleaseExcel(Exl as Object);


          
        }

        private void ReleaseExcel(object v)
        {
            try
            {
                throw new NotImplementedException();
            }
            catch { }
        }
    }
}
