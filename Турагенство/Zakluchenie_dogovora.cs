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
    public partial class Zakluchenie_dogovora : Form
    {
        public Zakluchenie_dogovora()
        {
            InitializeComponent();
        }
        //метод позволяет удалять активную сессию и все её активные связи прилождения
        private void Zakluchenie_dogovora_FormClosed(object sender, FormClosedEventArgs e)
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
        // метод позволяющий сделать вывод данных из БД
        private void Zakluchenie_dogovora_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "kyrsDataSet10.Статусы_оплаты". При необходимости она может быть перемещена или удалена.
            this.статусы_оплатыTableAdapter.Fill(this.kyrsDataSet10.Статусы_оплаты);

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
        }
        // метод позволяющий сделать удаление данных из БД
        private void button4_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
            SqlConnection str = new SqlConnection(@"Data Source=PC-306-4\SQLEXPRESS;Initial Catalog=kyrs;Integrated Security=True");
            str.Open();
            SqlCommand command = new SqlCommand($"DELETE Договора WHERE ID_Договора = @id", str);
            command.Parameters.AddWithValue("id", Convert.ToString(id));
            command.ExecuteNonQuery();
            MessageBox.Show("Договор успешно удалён!");
            str.Close();
            Zakluchenie_dogovora_Load(sender, e);
        }


        string status_oplati = "";
        // метод позволяющий сделать вывод информации из БД
        private void button3_Click(object sender, EventArgs e)
        {
                panel1.Visible = true;

                int id = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
                SqlConnection str = new SqlConnection(@"Data Source=PC-306-4\SQLEXPRESS;Initial Catalog=kyrs;Integrated Security=True");
                str.Open();
                SqlCommand command = new SqlCommand(" select ID_Договора,Путевки.Название_путевки,Клиенты.ФИО as ФИО_Клиента ,Способы_оплаты.Способ_оплаты,Сотрудники.ФИО  as ФИО_Сотрудника,Количество_детей,Количество_путевок,Договора.Цена ,Дата_заключения, Статусы_оплаты.Статус_оплаты  from Договора join Путевки on Путевки.ID_Путевки = Договора.ID_Путевки join Клиенты on Клиенты.ID_клиента = Договора.ID_Клиента join Способы_оплаты on Способы_оплаты.ID_Способа_оплаты = Договора.ID_Способа_оплаты join Сотрудники on Сотрудники.ID_Сотрудника = Договора.ID_Сотрудника join Статусы_оплаты on Статусы_оплаты.ID_Статуса_оплаты = Договора.ID_Статус_оплаты WHERE ID_Договора = @id", str);
                command.Parameters.AddWithValue("id", id);
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                status_oplati = reader[9].ToString();           
                }
                reader.Close();
                str.Close();
                comboBox1.Text = status_oplati;            
        }
        // метод позволяющий сделать изменение информации в БД
        private void button5_Click(object sender, EventArgs e)
        {
           
            int id = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
            SqlConnection str = new SqlConnection(@"Data Source=PC-306-4\SQLEXPRESS;Initial Catalog=kyrs;Integrated Security=True");
            str.Open();
            SqlCommand command = new SqlCommand($"update Договора set ID_Статус_оплаты='" + comboBox1.SelectedValue + "' WHERE ID_Договора = @id", str);
            command.Parameters.AddWithValue("id", Convert.ToString(id));
            command.ExecuteNonQuery();
            MessageBox.Show("Информация успешно изменена!");
            str.Close();
            Zakluchenie_dogovora_Load(sender, e);
            panel1.Visible = false;
        }
        //переход на другую форму
        private void button2_Click(object sender, EventArgs e)
        {
            Add_dogovor add_Dogovor = new Add_dogovor();
            add_Dogovor.Show();
            this.Hide();
        }
    }
}
