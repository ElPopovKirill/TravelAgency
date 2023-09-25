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
    public partial class Putevki : Form
    {
        public Putevki()
        {
            InitializeComponent();
        }
        //метод позволяет удалять активную сессию и все её активные связи прилождения
        private void Putevki_FormClosed(object sender, FormClosedEventArgs e)
        {
            System.Diagnostics.Process.GetCurrentProcess().Kill();
            Application.Exit();
        }
        //переход на другую форму
        private void button2_Click(object sender, EventArgs e)
        {
            Add_putevki add_Putevki = new Add_putevki();
            add_Putevki.Show();
            this.Hide();
        }
        //переход на другую форму
        private void button1_Click(object sender, EventArgs e)
        {
            Manager manager = new Manager();
            manager.Show();
            this.Hide();
        }
        // метод позволяющий вывести информацию из БД
        private void Putevki_Load(object sender, EventArgs e)
        {
            SqlConnection str = new SqlConnection(@"Data Source=PC-306-4\SQLEXPRESS;Initial Catalog=kyrs;Integrated Security=True");
            String query = "select ID_Путевки,Название_путевки,Туры.Название_тура ,Цена_с_учетом_накрутки as Цена  from Путевки join Туры on Туры.ID_Тура = Путевки.ID_Тура";
            str.Open();
            SqlDataAdapter a = new SqlDataAdapter(query, str);
            DataSet ds = new DataSet();
            a.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            str.Close();
        }

        //переход на другую форму
        private void button5_Click(object sender, EventArgs e)
        {
            Tours_manager tours = new Tours_manager();
            tours.Show();
            this.Hide();
        }

        // метод позволяющий удалить информацию из БД
        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                int id = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
                SqlConnection str = new SqlConnection(@"Data Source=PC-306-4\SQLEXPRESS;Initial Catalog=kyrs;Integrated Security=True");
                str.Open();
                SqlCommand command = new SqlCommand($"DELETE Путевки WHERE ID_Путевки = @id", str);
                command.Parameters.AddWithValue("id", Convert.ToString(id));
                command.ExecuteNonQuery();
                MessageBox.Show("Путёвка успешно удалена!");
                str.Close();
                Putevki_Load(sender, e);
            }
            catch (Exception)
            {

                MessageBox.Show("Путёвку нельзя удалить так как есть активные договора!");
            }
          
        }



        string Name_tour = "";
        // метод позволяющий внести изменения в БД
        private void button4_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
            SqlConnection str = new SqlConnection(@"Data Source=PC-306-4\SQLEXPRESS;Initial Catalog=kyrs;Integrated Security=True");
            str.Open();
            SqlCommand command = new SqlCommand($"update Путевки set  Название_путевки = '" + textBox1.Text +  "' WHERE ID_Путевки = @id", str);
            command.Parameters.AddWithValue("id", Convert.ToString(id));
            command.ExecuteNonQuery();
            MessageBox.Show("Информация успешно изменена!");
            str.Close();
            Putevki_Load(sender, e);
            panel1.Visible = false;
            button4.Visible = false;

        }
        // метод позволяющий вывести название путёвки в поле 
        private void button6_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
            button4.Visible = true;
            int id = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
            SqlConnection str = new SqlConnection(@"Data Source=PC-306-4\SQLEXPRESS;Initial Catalog=kyrs;Integrated Security=True");
            str.Open();
            SqlCommand command = new SqlCommand("select Название_путевки  from Путевки WHERE ID_Путевки =  @id", str);
            command.Parameters.AddWithValue("id", id);
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {

                Name_tour = reader[0].ToString();




            }
            reader.Close();
            str.Close();

            textBox1.Text = Name_tour;
        }
    }
}
