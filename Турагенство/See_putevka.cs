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
    public partial class See_putevka : Form
    {
        public See_putevka()
        {
            InitializeComponent();
        }
        //метод позволяет удалять активную сессию и все её активные связи прилождения
        private void See_putevka_FormClosed(object sender, FormClosedEventArgs e)
        {
            System.Diagnostics.Process.GetCurrentProcess().Kill();
            Application.Exit();
        }
        //переход на другую форму
        private void button1_Click(object sender, EventArgs e)
        {
            Add_dogovor add_Dogovor = new Add_dogovor();
            add_Dogovor.Show();
            this.Hide();
        }
        // метод позволяющий сделать вывод информации из БД
        private void See_putevka_Load(object sender, EventArgs e)
        {
            SqlConnection str = new SqlConnection(@"Data Source=PC-306-4\SQLEXPRESS;Initial Catalog=kyrs;Integrated Security=True");
            String query = "select ID_Путевки,Название_путевки,Туры.Название_тура ,Цена_с_учетом_накрутки as Цена  from Путевки join Туры on Туры.ID_Тура = Путевки.ID_Тура";
            str.Open();
            SqlDataAdapter a = new SqlDataAdapter(query, str);
            DataSet ds = new DataSet();
            a.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            str.Close();



            SqlConnection str2 = new SqlConnection(@"Data Source=PC-306-4\SQLEXPRESS;Initial Catalog=kyrs;Integrated Security=True");
            String query2 = "select ID_Тура,Название_тура,Страны.Название as Страны,Отели.Название as Отели,Трансферы.Трансфер,Туроператоры.Туроператор,Начало_тура,Конец_тура,Цена" +
                " from Туры join Страны on Страны.ID_Страны = Туры.ID_Страны" +
                " join Отели on Отели.ID_Отеля = Туры.ID_Отеля" +
                " join Трансферы on Трансферы.ID_Трансфера = Туры.ID_трансфера" +
                " join Туроператоры on Туроператоры.ID_Туроператора = Туры.ID_Туроператора";
            str2.Open();
            SqlDataAdapter a2 = new SqlDataAdapter(query2, str2);
            DataSet ds2 = new DataSet();
            a2.Fill(ds2);
            dataGridView2.DataSource = ds2.Tables[0];
            str2.Close();
        }
        // метод позволяющий сделать поиск данных по введённым символам
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
            string selectchar = textBox1.Text;
            SqlConnection str = new SqlConnection(@"Data Source=PC-306-4\SQLEXPRESS;Initial Catalog=kyrs;Integrated Security=True");
            String query = "select ID_Путевки,Название_путевки,Туры.Название_тура ,Цена_с_учетом_накрутки as Цена from Путевки  join Туры on Туры.ID_Тура = Путевки.ID_Тура where Название_путевки like '%" + selectchar + "%'";
            str.Open();
            SqlDataAdapter a = new SqlDataAdapter(query, str);
            DataSet ds = new DataSet();
            a.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            str.Close();
        }
        // метод позволяющий сделать поиск данных по введённым символам
        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            string selectchar = textBox2.Text;
            SqlConnection str = new SqlConnection(@"Data Source=PC-306-4\SQLEXPRESS;Initial Catalog=kyrs;Integrated Security=True");
            String query = "select ID_Тура,Название_тура,Страны.Название as Страны,Отели.Название as Отели,Трансферы.Трансфер,Туроператоры.Туроператор,Начало_тура,Конец_тура,Цена from Туры join Страны on Страны.ID_Страны = Туры.ID_Страны join Отели on Отели.ID_Отеля = Туры.ID_Отеля join Трансферы on Трансферы.ID_Трансфера = Туры.ID_трансфера join Туроператоры on Туроператоры.ID_Туроператора = Туры.ID_Туроператора where Название_тура like '%" + selectchar + "%'";
            str.Open();
            SqlDataAdapter a = new SqlDataAdapter(query, str);
            DataSet ds = new DataSet();
            a.Fill(ds);
            dataGridView2.DataSource = ds.Tables[0];
            str.Close();
        }
    }
}
