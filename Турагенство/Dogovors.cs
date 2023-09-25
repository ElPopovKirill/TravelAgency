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
    public partial class Dogovors : Form
    {
       

      
        public Dogovors()
        {
            InitializeComponent();
        }
        //метод позволяет удалять активную сессию и все её активные связи прилождения
        private void Dogovors_FormClosed(object sender, FormClosedEventArgs e)
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
        // метод позволяет вывести информацию из БД в datagreedview
        private void Dogovors_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "kyrsDataSet8.Статусы_оплаты". При необходимости она может быть перемещена или удалена.
            this.статусы_оплатыTableAdapter1.Fill(this.kyrsDataSet8.Статусы_оплаты);

            SqlConnection str = new SqlConnection(@"Data Source=PC-306-4\SQLEXPRESS;Initial Catalog=kyrs;Integrated Security=True");
            String query = "select ID_Договора,Путевки.Название_путевки,Клиенты.ФИО as ФИО_Клиента ,Способы_оплаты.Способ_оплаты,Сотрудники.ФИО  as ФИО_Сотрудника,Количество_детей,Количество_путевок,Договора.Цена ,Дата_заключения, Статусы_оплаты.Статус_оплаты" +
                " from Договора join Путевки on Путевки.ID_Путевки = Договора.ID_Путевки " +
                "join Клиенты on Клиенты.ID_клиента = Договора.ID_Клиента" +
                " join Способы_оплаты on Способы_оплаты.ID_Способа_оплаты = Договора.ID_Способа_оплаты" +
                " join Сотрудники on Сотрудники.ID_Сотрудника = Договора.ID_Сотрудника " +
                "join Статусы_оплаты on Статусы_оплаты.ID_Статуса_оплаты = Договора.ID_Статус_оплаты";
            str.Open();
            SqlDataAdapter a = new SqlDataAdapter(query, str);
            DataSet ds = new DataSet();
            a.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            str.Close();
            comboBox1.Text = "Сортировка";
        }
        // метод позволяет проверить статус поля сортировка и в соответствии с выбранной характеристикой выводиться информация
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           // вывод всех договоров со статусом оплачен
            if (comboBox1.Text == "Оплачен   ")
            {
                SqlConnection str = new SqlConnection(@"Data Source=PC-306-4\SQLEXPRESS;Initial Catalog=kyrs;Integrated Security=True");
                String query = "select ID_Договора,Путевки.Название_путевки,Клиенты.ФИО as ФИО_Клиента ,Способы_оплаты.Способ_оплаты,Сотрудники.ФИО  as ФИО_Сотрудника,Количество_детей,Количество_путевок,Договора.Цена ,Дата_заключения, Статусы_оплаты.Статус_оплаты from Договора join Путевки on Путевки.ID_Путевки = Договора.ID_Путевки join Клиенты on Клиенты.ID_клиента = Договора.ID_Клиента join Способы_оплаты on Способы_оплаты.ID_Способа_оплаты = Договора.ID_Способа_оплаты join Сотрудники on Сотрудники.ID_Сотрудника = Договора.ID_Сотрудника  join Статусы_оплаты on Статусы_оплаты.ID_Статуса_оплаты = Договора.ID_Статус_оплаты where(Статус_оплаты = 'Оплачен')";
                str.Open();
                SqlDataAdapter a = new SqlDataAdapter(query, str);
                DataSet ds = new DataSet();
                a.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0];
                str.Close();
                
            }
            else if (comboBox1.Text == "Не оплачен")      // вывод всех договоров со статусом оплачен
            {
                SqlConnection str = new SqlConnection(@"Data Source=PC-306-4\SQLEXPRESS;Initial Catalog=kyrs;Integrated Security=True");
                String query = "select ID_Договора,Путевки.Название_путевки,Клиенты.ФИО as ФИО_Клиента ,Способы_оплаты.Способ_оплаты,Сотрудники.ФИО  as ФИО_Сотрудника,Количество_детей,Количество_путевок,Договора.Цена ,Дата_заключения, Статусы_оплаты.Статус_оплаты from Договора join Путевки on Путевки.ID_Путевки = Договора.ID_Путевки join Клиенты on Клиенты.ID_клиента = Договора.ID_Клиента join Способы_оплаты on Способы_оплаты.ID_Способа_оплаты = Договора.ID_Способа_оплаты join Сотрудники on Сотрудники.ID_Сотрудника = Договора.ID_Сотрудника  join Статусы_оплаты on Статусы_оплаты.ID_Статуса_оплаты = Договора.ID_Статус_оплаты where(Статус_оплаты = 'Не оплачен')";
                str.Open();
                SqlDataAdapter a = new SqlDataAdapter(query, str);
                DataSet ds = new DataSet();
                a.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0];
                str.Close();
            }
        }

      
        // обновление формы
        private void button2_Click(object sender, EventArgs e)
        {
            Dogovors_Load(sender,e);
        }
    }
}
