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
    public partial class Add_putevki : Form
    {
        public Add_putevki()
        {
            InitializeComponent();
        }
        //метод позволяет удалять активную сессию и все её активные связи прилождения
        private void Add_putevki_FormClosed(object sender, FormClosedEventArgs e)
        {
            System.Diagnostics.Process.GetCurrentProcess().Kill();
            Application.Exit();
        }
        //переход на другую форму
        private void button1_Click(object sender, EventArgs e)
        {
            Putevki putevki = new Putevki();
            putevki.Show();
            this.Hide();
        }
        // combobox использует данные взщятые из БД, ниже прописаны строки подключения
        private void Add_putevki_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "kyrsDataSet6.Туры". При необходимости она может быть перемещена или удалена.
            this.турыTableAdapter.Fill(this.kyrsDataSet6.Туры);

        }
        //метод позволяющий добавлять данные в базу данных , метод содержит сторку подключения к базе SQL,запрос,модальное окно,переход на другую форму,есть проверка на тех. ошибки
        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection str = new SqlConnection(@"Data Source=PC-306-4\SQLEXPRESS;Initial Catalog=kyrs;Integrated Security=True");
                str.Open();
                SqlCommand command = new SqlCommand($"insert into Путевки(Название_путевки,ID_Тура) values('" + textBox1.Text + "', '" + comboBox1.SelectedValue + "');", str);
                command.ExecuteNonQuery();
                MessageBox.Show("Путёвка успешно добавлена!");
                str.Close();
                Putevki putevki = new Putevki();
                putevki.Show();
                this.Hide();
            }
            catch (Exception)
            {
                MessageBox.Show("Путёвка существует!");
             
            }
           
        }
    }
}
