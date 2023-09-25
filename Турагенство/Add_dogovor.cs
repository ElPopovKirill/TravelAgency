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
    public partial class Add_dogovor : Form
    {
        public Add_dogovor()
        {
            InitializeComponent();
        }

        //метод позволяет удалять активную сессию и все её активные связи прилождения
        private void Add_dogovor_FormClosed(object sender, FormClosedEventArgs e)
        {
            System.Diagnostics.Process.GetCurrentProcess().Kill();
            Application.Exit();
        }

        //переход на другую форму
        private void button1_Click(object sender, EventArgs e)
        {
            Zakluchenie_dogovora zakluchenie_Dogovora = new Zakluchenie_dogovora();
            zakluchenie_Dogovora.Show();
            this.Hide();
        }

        private void Add_dogovor_Load(object sender, EventArgs e)
        {
          

        }


        //переход на другую форму
        private void button2_Click(object sender, EventArgs e)
        {
            See_sotrudnic see_Sotrudnic = new See_sotrudnic();
            see_Sotrudnic.Show();
            this.Hide();
        }
        //переход на другую форму
        private void button3_Click(object sender, EventArgs e)
        {
            See_klient see_Klient = new See_klient();
            see_Klient.Show();
            this.Hide();
        }
        //переход на другую форму
        private void button4_Click(object sender, EventArgs e)
        {
            See_putevka see_Putevka = new See_putevka();
            see_Putevka.Show();
            this.Hide();
        }

        string price = "";
        int count_putevki = 0;
        int count_children = 0;
        int Finaly_price = 0;
        string tour = "";
        int All_prise = 0;
        int Discount_prise = 0;

        //метод позволяющий добавлять данные в базу данных , метод содержит сторку подключения к базе SQL,запрос,модальное окно,переход на другую форму
        private void button5_Click(object sender, EventArgs e)
        {

            SqlConnection str2 = new SqlConnection(@"Data Source=PC-306-4\SQLEXPRESS;Initial Catalog=kyrs;Integrated Security=True");
            str2.Open();
            SqlCommand command2 = new SqlCommand($"insert into Договора(ID_Путевки,ID_Клиента,ID_Способа_оплаты,ID_Сотрудника,Количество_детей,Количество_путевок,Цена,ID_Статус_оплаты) values('" + comboBox1.SelectedValue + "', '" + comboBox2.SelectedValue + "', '" + comboBox3.SelectedValue + "', '" + comboBox4.SelectedValue + "', '" + textBox1.Text + "', '" + textBox2.Text + "', '" + Finaly_price + "', '" + comboBox5.SelectedValue + "');", str2);
            command2.ExecuteNonQuery();
            MessageBox.Show("Договор успешно добавлен!");
            str2.Close();
            Zakluchenie_dogovora zakluchenie_Dogovora = new Zakluchenie_dogovora();
            zakluchenie_Dogovora.Show();
            this.Hide();
        }
        /*метод позволяющий узнать примерную цену всех путёвок из базы данных ,
        //метод содержит сторку подключения к базе SQL,запрос, цикл в котором присваиваются значения
        из полей которые вывелись в результате запроса. В конце метода формула рассчёта цены*/
        private void button6_Click(object sender, EventArgs e)
        {
          
                count_putevki = Convert.ToInt32(textBox2.Text);
                count_children = Convert.ToInt32(textBox1.Text);
                tour = comboBox1.Text;

                SqlConnection str = new SqlConnection(@"Data Source=PC-306-4\SQLEXPRESS;Initial Catalog=kyrs;Integrated Security=True");
                str.Open();
                SqlCommand command = new SqlCommand("select Цена_с_учетом_накрутки from Путевки where(Название_путевки = '"+tour+"')", str);
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {

                    price = reader[0].ToString();
                
                }
                reader.Close();
                str.Close();
                All_prise = Convert.ToInt32(price);
                Discount_prise = Convert.ToInt32(price) / 2;
                Finaly_price = ((count_putevki - count_children) * All_prise) + (count_children * Discount_prise);
                textBox3.Text = Finaly_price.ToString();
            
          
           
        }

        // combobox использует данные взщятые из БД, ниже прописаны строки подключения
        private void Add_dogovor_Load_1(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "kyrsDataSet5.Способы_оплаты". При необходимости она может быть перемещена или удалена.
            this.способы_оплатыTableAdapter.Fill(this.kyrsDataSet5.Способы_оплаты);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "kyrsDataSet4.Статусы_оплаты". При необходимости она может быть перемещена или удалена.
            this.статусы_оплатыTableAdapter.Fill(this.kyrsDataSet4.Статусы_оплаты);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "kyrsDataSet3.Сотрудники". При необходимости она может быть перемещена или удалена.
            this.сотрудникиTableAdapter.Fill(this.kyrsDataSet3.Сотрудники);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "kyrsDataSet2.Клиенты". При необходимости она может быть перемещена или удалена.
            this.клиентыTableAdapter.Fill(this.kyrsDataSet2.Клиенты);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "kyrsDataSet.Путевки". При необходимости она может быть перемещена или удалена.
            this.путевкиTableAdapter.Fill(this.kyrsDataSet.Путевки);


        }

    }
}
