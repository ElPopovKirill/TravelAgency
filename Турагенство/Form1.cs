using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using Xceed.Document.NET;
using Xceed.Words.NET;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Турагенство
{
    public partial class Form1 : Form
    {
        public static int id_sotrydnika;
        public static int name_sotrydnika;
        // при запуске пароль становиться скрытым в точки
        public Form1()
        {
            InitializeComponent();
            textBox2.UseSystemPasswordChar = true;
        }
        // расхеширование пароля для дальнейшего сравнивания!
        string GetHashString(string password)
        {
            MD5 md5 = System.Security.Cryptography.MD5.Create();
            byte[] inputBytes = System.Text.Encoding.ASCII.GetBytes(password);
            byte[] hash = md5.ComputeHash(inputBytes);
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < hash.Length; i++)
            {
                sb.Append(hash[i].ToString("X2"));
            }
            return sb.ToString();
        }

        // метод позволяющий проверить пользователя по его логину и паролю , для дальнейшего входа в систему
        private void button1_Click(object sender, EventArgs e)
        {
            string login = textBox1.Text;
            string parol = textBox2.Text;


            SqlConnection str = new SqlConnection(@"Data Source=PC-306-4\SQLEXPRESS;Initial Catalog=kyrs;Integrated Security=True");
            str.Open();
            SqlCommand command = new SqlCommand("select Должности.Должность, ФИО , ID_Сотрудника from Сотрудники JOIN Должности on Должности.ID_Должности = Сотрудники.ID_Должности where(Логин='"+login+"' and Пароль='"+parol+"');", str);
            SqlDataReader reader = command.ExecuteReader();
            string fio = "";
            string dolznost = "";
            GetHashString(login);
            while (reader.Read())
            {
                fio = reader[1].ToString();
                dolznost = reader[0].ToString();
                id_sotrydnika = Convert.ToInt32(reader[2]);
            }
            reader.Close();
            str.Close();

          

            // проверка на соответствие должности и переход на нужную форму


            if (dolznost == "Директор  " )
            {
                Director director = new Director();
                director.Show();
                this.Hide();
            }
            else if (dolznost == "Менеджер  " )
            {
                Manager manager = new Manager();
                manager.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Нет такого пользователя ");
            }
          

        }
        //метод позволяет удалять активную сессию и все её активные связи прилождения
        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            System.Diagnostics.Process.GetCurrentProcess().Kill();
            Application.Exit();
        }
        string parol = "";
        // метод позволяющий прятать пароль
        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox2.UseSystemPasswordChar == false)
            {
                textBox2.UseSystemPasswordChar = true;
            }
            else
            {
                textBox2.UseSystemPasswordChar = false;
            }
            button3.Visible = false;
            button2.Visible = true;
        }
        // метод позволяющий показывать пароль
        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox2.UseSystemPasswordChar == false)
            {
                textBox2.UseSystemPasswordChar = true;
            }
            else
            {
                textBox2.UseSystemPasswordChar = false;
            }
            button2.Visible = false;
            button3.Visible = true;
           
        }

        private void button4_Click(object sender, EventArgs e)
        {
            pictureBox2.Visible = false;
            panel2.Visible = false;
        }
    }
}
