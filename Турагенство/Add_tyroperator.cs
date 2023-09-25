using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Турагенство
{
    public partial class Add_tyroperator : Form
    {
        public Add_tyroperator()
        {
            InitializeComponent();
        }
        //метод позволяет удалять активную сессию и все её активные связи прилождения
        private void Add_tyroperator_FormClosed(object sender, FormClosedEventArgs e)
        {
            System.Diagnostics.Process.GetCurrentProcess().Kill();
            Application.Exit();
        }
        //переход на другую форму
        private void button1_Click(object sender, EventArgs e)
        {
            Tyroperators tyroperators = new Tyroperators();
            tyroperators.Show();
            this.Hide();
        }
        //метод позволяющий добавлять данные в базу данных , метод содержит сторку подключения к базе SQL,запрос,модальное окно,переход на другую форму, есть проверка на уникальность логина
        private void button2_Click(object sender, EventArgs e)
        {
            TextInfo ti = CultureInfo.CurrentCulture.TextInfo;
            SqlConnection str = new SqlConnection(@"Data Source=PC-306-4\SQLEXPRESS;Initial Catalog=kyrs;Integrated Security=True");

            str.Open();
            SqlCommand command = new SqlCommand($"insert into  Туроператоры (Туроператор,Адрес) values('"+textBox1.Text+"', '"+textBox2.Text+"');", str);
            command.ExecuteNonQuery();
            MessageBox.Show("Туроператор успешно добавлен!");
            str.Close();
            Tyroperators tyroperators = new Tyroperators();
            tyroperators.Show();
            this.Hide();

        }
    }
}
