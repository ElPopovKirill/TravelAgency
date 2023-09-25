using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Турагенство
{
    public partial class Sotrudniki : Form
    {
        public Sotrudniki()
        {
            InitializeComponent();
        }
        //метод позволяет удалять активную сессию и все её активные связи прилождения
        private void Sotrudniki_FormClosed(object sender, FormClosedEventArgs e)
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

        private void Sotrudniki_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "kyrsDataSet9.Должности". При необходимости она может быть перемещена или удалена.
            this.должностиTableAdapter.Fill(this.kyrsDataSet9.Должности);

            SqlConnection str = new SqlConnection(@"Data Source=PC-306-4\SQLEXPRESS;Initial Catalog=kyrs;Integrated Security=True");
            String query = "select ID_Сотрудника, Должности.Должность,ФИО,Дата_рождения,Телефон,Логин,Пароль,Шифрованный_пароль from Сотрудники join Должности on Должности.ID_Должности = Сотрудники.ID_Должности";
            str.Open();
            SqlDataAdapter a = new SqlDataAdapter(query, str);
            DataSet ds = new DataSet();
            a.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            str.Close();
        }
        // метод позволяющий сделать добавление информации в БД
        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                panel1.Visible = false;
                int id = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
                SqlConnection str = new SqlConnection(@"Data Source=PC-306-4\SQLEXPRESS;Initial Catalog=kyrs;Integrated Security=True");
                str.Open();
                SqlCommand command = new SqlCommand($"DELETE Сотрудники WHERE ID_Сотрудника = @id", str);
                command.Parameters.AddWithValue("id", Convert.ToString(id));
                command.ExecuteNonQuery();
                MessageBox.Show("Сотрудник успешно уволен!");
                str.Close();
                Sotrudniki_Load(sender, e);
            }
            catch (Exception)
            {

                MessageBox.Show("Сотрудник имеет активный договор с клиентом!");
            }
          
        }
        // переход на другую форму
        private void button3_Click(object sender, EventArgs e)
        {
            Add_sotrudniki add_Sotrudniki = new Add_sotrudniki();
            add_Sotrudniki.Show();
            this.Hide();
        }

        string Dolznost = "";
        string FIO = "";
        string Date_birthday = "";
        string Number = "";
        string Login = "";
        string Parol = "";
        // метод позволяющий сделать запрос в БД и после присвоить эти значения в переменные для дальнейшего использования
        private void button4_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
            



            int id = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
            SqlConnection str = new SqlConnection(@"Data Source=PC-306-4\SQLEXPRESS;Initial Catalog=kyrs;Integrated Security=True");
            str.Open();
            SqlCommand command = new SqlCommand("select ID_Сотрудника, Должности.Должность,ФИО,Дата_рождения,Телефон,Логин,Пароль,Шифрованный_пароль from Сотрудники join Должности on Должности.ID_Должности = Сотрудники.ID_Должности WHERE ID_Сотрудника = @id", str);
            command.Parameters.AddWithValue("id", id);
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                Dolznost = reader[1].ToString();
                FIO = reader[2].ToString();
                Date_birthday = reader[3].ToString();
                Number = reader[4].ToString();
                Login = reader[5].ToString();
                Parol = reader[6].ToString();

            }
            reader.Close();
            str.Close();
            comboBox1.Text = Dolznost;
            textBox1.Text = FIO;
            dateTimePicker1.Text = Date_birthday;
            textBox2.Text = Number;
            textBox3.Text = Login;       
            textBox4.Text = Parol;
            


        }
        // метод позволяющий сделать и зменение данных в БД
        private void button5_Click(object sender, EventArgs e)
        {
            string shifrparol = textBox4.Text;
            shifrparol = GetHashedPassword(shifrparol);
            int id = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
            SqlConnection str = new SqlConnection(@"Data Source=PC-306-4\SQLEXPRESS;Initial Catalog=kyrs;Integrated Security=True");
            str.Open();
            SqlCommand command = new SqlCommand($"update Сотрудники set ID_Должности='"+comboBox1.SelectedValue+"' , ФИО = '" + textBox1.Text + "',Дата_рождения='"+ dateTimePicker1.Value + "',Телефон='"+ textBox2.Text + "',Логин='"+ textBox3.Text + "',Пароль='" + textBox4.Text + "',Шифрованный_пароль='" + shifrparol + "' WHERE ID_Сотрудника = @id", str);
            command.Parameters.AddWithValue("id", Convert.ToString(id));
            command.ExecuteNonQuery();
            MessageBox.Show("Информация успешно изменена!");
            str.Close();
            Sotrudniki_Load(sender, e);
            panel1.Visible = false;
        }
        // метод позволяющий зашифровать пароль 
        private string GetHashedPassword(string password)
        {
            byte[] data = Encoding.UTF8.GetBytes(password);
            SHA256 sha256 = SHA256.Create();
            byte[] hashedData = sha256.ComputeHash(data);
            return Convert.ToBase64String(hashedData);
        }
    }
}
