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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;

namespace Турагенство
{
    public partial class Add_sotrudniki : Form
    {
        public Add_sotrudniki()
        {
            InitializeComponent();
        }
        //метод позволяет удалять активную сессию и все её активные связи прилождения
        private void Add_sotrudniki_FormClosed(object sender, FormClosedEventArgs e)
        {
            System.Diagnostics.Process.GetCurrentProcess().Kill();
            Application.Exit();
        }
        //переход на другую форму
        private void button1_Click(object sender, EventArgs e)
        {
            Sotrudniki sotrudniki = new Sotrudniki();
            sotrudniki.Show();
            this.Hide();
        }
        //метод позволяющий добавлять данные в базу данных , метод содержит сторку подключения к базе SQL,запрос,модальное окно,переход на другую форму, есть проверка на уникальность логина
        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                string password = textBox4.Text;
                string hashedPassword = GetHashedPassword(password);

                SqlConnection str = new SqlConnection(@"Data Source=PC-306-4\SQLEXPRESS;Initial Catalog=kyrs;Integrated Security=True");
                str.Open();
                SqlCommand command = new SqlCommand($"insert into  Сотрудники(ID_Должности,ФИО,Дата_рождения,Телефон,Логин,Пароль,Шифрованный_пароль) values('" + comboBox1.SelectedValue + "', '" + textBox1.Text + "', '" + dateTimePicker1.Value + "', '" + textBox2.Text + "', '" + textBox3.Text + "', '" + textBox4.Text + "', '" + hashedPassword + "');", str);
                command.ExecuteNonQuery();
                MessageBox.Show("Сотрудник успешно добавлен!");
                str.Close();
                Sotrudniki sotrudniki = new Sotrudniki();
                sotrudniki.Show();
                this.Hide();
            }
            catch (Exception)
            {

                MessageBox.Show("Логин занят!");
            }
           
         

        }
        // combobox использует данные взщятые из БД, ниже прописаны строки подключения
        private void Add_sotrudniki_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "kyrsDataSet7.Должности". При необходимости она может быть перемещена или удалена.
            this.должностиTableAdapter.Fill(this.kyrsDataSet7.Должности);


        }

        string pwd = "";
        private void button3_Click(object sender, EventArgs e)
        {
            textBox4.Text = "";        
            pwd = "";

            //создаем наборы символов, из которых будет формироваться капча
            String allowchar = " ";
            allowchar = "A,B,C,D,E,F,G,H,I,J,K,L,M,N,O,P,Q,R,S,T,U,V,W,X,Y,Z,a,b,c,d,e,f,g,h,i,j,k,l,m,n,o,p,q,r,s,t,u,v,w,y,z,1,2,3,4,5,6,7,8,9,0,";

            //записываем набор символов в массив
            String[] ar = allowchar.Split(',');

            String temp = " "; // переменная, в которой будет записываться рандомный символ из массива
            Random r = new Random();

            int kol = 4; // количество символов в капче

            for (int i = 0; i < kol; i++)
            {
                //генерируем рандомный символ из массива
                //мы берем элемент массива и задаем рандомный индекс элемента
                //обратите внимание, что диапазон рандома начинаетмя с 0 и заканчивается длиной массива символов
                temp = ar[r.Next(0, ar.Length)]; 
                pwd += temp;
            }
            //выводим сформированнфй текст в поле
            textBox4.Text = pwd;
          
        }
        // метод который позволяет шифровать входные данные алгоритмом SHA256
        private string GetHashedPassword(string password)
        {
            byte[] data = Encoding.UTF8.GetBytes(password);
            SHA256 sha256 = SHA256.Create();
            byte[] hashedData = sha256.ComputeHash(data);
            return Convert.ToBase64String(hashedData);
        }
    }
}
