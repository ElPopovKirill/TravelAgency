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
    public partial class Tours_manager : Form
    {
        public Tours_manager()
        {
            InitializeComponent();
        }
        //метод позволяет удалять активную сессию и все её активные связи прилождения
        private void Tours_manager_FormClosed(object sender, FormClosedEventArgs e)
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
        // метод позволяющий сделать вывод информации из БД 
        private void Tours_manager_Load(object sender, EventArgs e)
        {
            SqlConnection str = new SqlConnection(@"Data Source=PC-306-4\SQLEXPRESS;Initial Catalog=kyrs;Integrated Security=True");
            String query = "select ID_Тура,Название_тура,Страны.Название as Страны,Отели.Название as Отели,Трансферы.Трансфер,Туроператоры.Туроператор,Начало_тура,Конец_тура,Цена" +
                " from Туры join Страны on Страны.ID_Страны = Туры.ID_Страны" +
                " join Отели on Отели.ID_Отеля = Туры.ID_Отеля" +
                " join Трансферы on Трансферы.ID_Трансфера = Туры.ID_трансфера" +
                " join Туроператоры on Туроператоры.ID_Туроператора = Туры.ID_Туроператора";
            str.Open();
            SqlDataAdapter a = new SqlDataAdapter(query, str);
            DataSet ds = new DataSet();
            a.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            str.Close();
        }
    }
}
