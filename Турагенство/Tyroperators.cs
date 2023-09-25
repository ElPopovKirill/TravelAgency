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
    public partial class Tyroperators : Form
    {
        public Tyroperators()
        {
            InitializeComponent();
        }
        //метод позволяет удалять активную сессию и все её активные связи прилождения
        private void Tyroperators_FormClosed(object sender, FormClosedEventArgs e)
        {
            System.Diagnostics.Process.GetCurrentProcess().Kill();
            Application.Exit();
        }
        //переход на другую форму
        private void button1_Click(object sender, EventArgs e)
        {
            Director director = new Director();
            director.Show();
            this.Hide();
        }
        // метод позволяющий сделать вывод данных из БД
        private void Tyroperators_Load(object sender, EventArgs e)
        {
            SqlConnection str = new SqlConnection(@"Data Source=PC-306-4\SQLEXPRESS;Initial Catalog=kyrs;Integrated Security=True");
            String query = "SELECT * from Туроператоры";
            str.Open();
            SqlDataAdapter a = new SqlDataAdapter(query, str);
            DataSet ds = new DataSet();
            a.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            str.Close();
        }

       

        private void button2_Click_1(object sender, EventArgs e)
        {
          
        }
        //переход на другую форму
        private void button3_Click(object sender, EventArgs e)
        {
            Add_tyroperator add_Tyroperator = new Add_tyroperator();
            add_Tyroperator.Show();
            this.Hide();
        }
        // метод позволяющий сделать поиск данных по введённым символам
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
         
            string selectchar = textBox1.Text;
            SqlConnection str = new SqlConnection(@"Data Source=PC-306-4\SQLEXPRESS;Initial Catalog=kyrs;Integrated Security=True");
            String query = "select ID_Туроператора, Туроператор , Адрес  from Туроператоры where Туроператор like '%" + selectchar+"%'";
            str.Open();
            SqlDataAdapter a = new SqlDataAdapter(query, str);
            DataSet ds = new DataSet();
            a.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            str.Close();
        }
    }
}
