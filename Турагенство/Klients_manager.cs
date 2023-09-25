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
    public partial class Klients_manager : Form
    {
        public Klients_manager()
        {
            InitializeComponent();
        }
        //метод позволяет удалять активную сессию и все её активные связи прилождения
        private void Klients_manager_FormClosed(object sender, FormClosedEventArgs e)
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
        // метод позволяет вывести информацию из БД
        private void Klients_manager_Load(object sender, EventArgs e)
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
        //метод позволяющий удалять данные из базы данных , метод содержит сторку подключения к базе SQL,запрос,модальное окно,переход на другую форму
        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                panel1.Visible = false;
                int id = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
                SqlConnection str = new SqlConnection(@"Data Source=PC-306-4\SQLEXPRESS;Initial Catalog=kyrs;Integrated Security=True");
                str.Open();
                SqlCommand command = new SqlCommand($"DELETE Клиенты WHERE ID_Клиента = @id", str);
                command.Parameters.AddWithValue("id", Convert.ToString(id));
                command.ExecuteNonQuery();
                MessageBox.Show("Клиент успешно уволен!");
                str.Close();
                Klients_manager_Load(sender, e);
            }
            catch (Exception)
            {

                MessageBox.Show("У клиента активный договор!");
            }
           
        }



        string FIO = "";
        string Ser_num_pass = "";
        string Date_birthday = "";
        string Number = "";


        //метод позволяющий присвоить данные в переменные из базы данных , метод содержит сторку подключения к базе SQL,запрос,переход на другую форму
        private void button2_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;



            int id = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
            SqlConnection str = new SqlConnection(@"Data Source=PC-306-4\SQLEXPRESS;Initial Catalog=kyrs;Integrated Security=True");
            str.Open();
            SqlCommand command = new SqlCommand("select ID_клиента,ФИО,серия_номер_паспорта , Дата_рождения,Телефон  from Клиенты WHERE ID_Клиента = @id", str);
            command.Parameters.AddWithValue("id", id);
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {

                FIO = reader[1].ToString();
                Ser_num_pass = reader[2].ToString();
                Date_birthday = reader[3].ToString();
                Number = reader[4].ToString();



            }
            reader.Close();
            str.Close();

            textBox2.Text = FIO;
            textBox3.Text = Ser_num_pass;
            textBox4.Text = Number;
            dateTimePicker1.Text = Date_birthday;
        }
        //метод позволяющий добавлять,изменять данные в базу данных , метод содержит сторку подключения к базе SQL,запрос,модальное окно,переход на другую форму
        private void button5_Click(object sender, EventArgs e)
        {
          
           
            int id = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
            SqlConnection str = new SqlConnection(@"Data Source=PC-306-4\SQLEXPRESS;Initial Catalog=kyrs;Integrated Security=True");
            str.Open();
            SqlCommand command = new SqlCommand($"update Клиенты set  ФИО = '" + textBox2.Text + "',Дата_рождения='" + dateTimePicker1.Value + "',Телефон='" + textBox4.Text + "',серия_номер_паспорта='" + textBox3.Text +  "' WHERE ID_Клиента = @id", str);
            command.Parameters.AddWithValue("id", Convert.ToString(id));
            command.ExecuteNonQuery();
            MessageBox.Show("Информация успешно изменена!");
            str.Close();
            Klients_manager_Load(sender, e);
            panel1.Visible = false;
        }
        //переход на другую форму
        private void button4_Click(object sender, EventArgs e)
        {
            Add_klients add_Klients = new Add_klients();
            add_Klients.Show();
            this.Hide();
        }
    }
}
