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
    public partial class Mistakes_director : Form
    {
        public Mistakes_director()
        {
            InitializeComponent();
        }
        //метод позволяет удалять активную сессию и все её активные связи прилождения
        private void Mistakes_director_FormClosed(object sender, FormClosedEventArgs e)
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
        // метод позволяет вывести информацию из БД
        private void Mistakes_director_Load(object sender, EventArgs e)
        {
            SqlConnection str = new SqlConnection(@"Data Source=PC-306-4\SQLEXPRESS;Initial Catalog=kyrs;Integrated Security=True");
            String query = "select ID_Жалобы,Жалобы.ID_Сотрудника, Жалоба , Сотрудники.ФИО,Дата_Жалобы,Статус from Жалобы join Сотрудники on Сотрудники.ID_Сотрудника = Жалобы.ID_Сотрудника";
            str.Open();
            SqlDataAdapter a = new SqlDataAdapter(query, str);
            DataSet ds = new DataSet();
            a.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            str.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            comboBox1.Visible = true;

        }
        // метод позволяющий изменить статус заявки и изменить данные в БД
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox1.Visible = false;
            
            int id = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
            SqlConnection str = new SqlConnection(@"Data Source=PC-306-4\SQLEXPRESS;Initial Catalog=kyrs;Integrated Security=True");
            str.Open();
            SqlCommand command = new SqlCommand($"update Жалобы set Статус = '"+ comboBox1 .Text+ "' where(ID_Жалобы = @id)", str);
            command.Parameters.AddWithValue("id", Convert.ToString(id));
            command.ExecuteNonQuery();
            MessageBox.Show("Информация успешно изменена!");
            str.Close();
            Mistakes_director_Load(sender, e);

        }
        // метод позволяющий удалить данные из БД
        private void button2_Click(object sender, EventArgs e)
        {
           
            int id = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
            SqlConnection str = new SqlConnection(@"Data Source=PC-306-4\SQLEXPRESS;Initial Catalog=kyrs;Integrated Security=True");
            str.Open();
            SqlCommand command = new SqlCommand($"DELETE Жалобы WHERE ID_Жалобы = @id", str);
            command.Parameters.AddWithValue("id", Convert.ToString(id));
            command.ExecuteNonQuery();
            MessageBox.Show("Жалоба успешно удалена!");
            str.Close();
            Mistakes_director_Load(sender, e);
        }
    }
}
