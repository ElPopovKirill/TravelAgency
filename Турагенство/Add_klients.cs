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
    public partial class Add_klients : Form
    {
        public Add_klients()
        {
            InitializeComponent();
        }
        //метод позволяет удалять активную сессию и все её активные связи прилождения
        private void Add_klients_FormClosed(object sender, FormClosedEventArgs e)
        {
            System.Diagnostics.Process.GetCurrentProcess().Kill();
            Application.Exit();
        }
        //переход на другую форму
        private void button1_Click(object sender, EventArgs e)
        {
            Klients_manager klients_Manager = new Klients_manager();
            klients_Manager.Show();
            this.Hide();
        }
        //метод позволяющий добавлять данные в базу данных , метод содержит сторку подключения к базе SQL,запрос,модальное окно,переход на другую форму
        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection str = new SqlConnection(@"Data Source=PC-306-4\SQLEXPRESS;Initial Catalog=kyrs;Integrated Security=True");
            str.Open();
            SqlCommand command = new SqlCommand($"insert into  Клиенты(ФИО,серия_номер_паспорта,Дата_рождения,Телефон) values('" + textBox1.Text + "', '" +  textBox2.Text + "', '" + dateTimePicker1.Value + "', '" + textBox3.Text +  "');", str);
            command.ExecuteNonQuery();
            MessageBox.Show("Клиент успешно добавлен!");
            str.Close();
            Klients_manager klients_Manager = new Klients_manager();
            klients_Manager.Show();
            this.Hide();
          
        }

        private void Add_klients_Load(object sender, EventArgs e)
        {

        }
    }
}
