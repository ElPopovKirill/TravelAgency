using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Турагенство
{
    public partial class See_klient : Form
    {
        public See_klient()
        {
            InitializeComponent();
        }
        //метод позволяет удалять активную сессию и все её активные связи прилождения
        private void See_klient_FormClosed(object sender, FormClosedEventArgs e)
        {
            System.Diagnostics.Process.GetCurrentProcess().Kill();
            Application.Exit();
        }
        // метод позволяющий вывести информацию из БД
        private void See_klient_Load(object sender, EventArgs e)
        {
            SqlConnection str = new SqlConnection(@"Data Source=PC-306-4\SQLEXPRESS;Initial Catalog=kyrs;Integrated Security=True");
            String query = "SELECT * from Клиенты";
            str.Open();
            SqlDataAdapter a = new SqlDataAdapter(query, str);
            DataSet ds = new DataSet();
            a.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            str.Close();
        }
        //переход на другую форму
        private void button1_Click(object sender, EventArgs e)
        {
            Add_dogovor add_Dogovor = new Add_dogovor();
            add_Dogovor.Show();
            this.Hide();
        }
        // метод позволяющий сделать поиск данных по введённым символам
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string selectchar = textBox1.Text;
            SqlConnection str = new SqlConnection(@"Data Source=PC-306-4\SQLEXPRESS;Initial Catalog=kyrs;Integrated Security=True");
            String query = "SELECT * from Клиенты where Серия_номер_паспорта like '%" + selectchar + "%'";
            str.Open();
            SqlDataAdapter a = new SqlDataAdapter(query, str);
            DataSet ds = new DataSet();
            a.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            str.Close();
        }
    }
}
