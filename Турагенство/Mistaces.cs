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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Турагенство
{
    public partial class Mistaces : Form
    {
        public Mistaces()
        {
            InitializeComponent();
        }
        //метод позволяет удалять активную сессию и все её активные связи прилождения
        private void Mistaces_FormClosed(object sender, FormClosedEventArgs e)
        {
            System.Diagnostics.Process.GetCurrentProcess().Kill();
            Application.Exit();
        }
        //переход на другую форму
        private void button1_Click(object sender, EventArgs e)
        {
            Manager manager = new Manager();
            manager.Show();
            this.Hide();
        }
        int ID_sotrydnika = Form1.id_sotrydnika;
        // метод позволяет вывести информацию из БД
        private void Mistaces_Load(object sender, EventArgs e)
        {
            SqlConnection str = new SqlConnection(@"Data Source=PC-306-4\SQLEXPRESS;Initial Catalog=kyrs;Integrated Security=True");
            String query = "select ID_Жалобы,Жалобы.ID_Сотрудника, Жалоба , Сотрудники.ФИО,Дата_Жалобы,Статус from Жалобы join Сотрудники on Сотрудники.ID_Сотрудника = Жалобы.ID_Сотрудника where Жалобы.ID_Сотрудника = " + ID_sotrydnika + "";
            str.Open();
            SqlDataAdapter a = new SqlDataAdapter(query, str);
            DataSet ds = new DataSet();
            a.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            str.Close();
        }
        // метод позволяет добавить данные в БД
        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection str = new SqlConnection(@"Data Source=PC-306-4\SQLEXPRESS;Initial Catalog=kyrs;Integrated Security=True");
            str.Open();
            SqlCommand command = new SqlCommand($"insert into  Жалобы(Жалобы.ID_Сотрудника, Жалоба,Статус ) values("+ID_sotrydnika+",'"+textBox1.Text+"','На рассмотрении') ", str);
            command.ExecuteNonQuery();
            MessageBox.Show("Жалоба успешно отправлена!");
            str.Close();
            Mistaces_Load(sender, e);
        }
    }
}
