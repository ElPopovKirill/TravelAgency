using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Xceed.Document.NET;
using Xceed.Words.NET;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Турагенство
{
    public partial class Print_dogovor : Form
    {
        
        public Print_dogovor()
        {
            InitializeComponent();
        }
        //метод позволяет удалять активную сессию и все её активные связи прилождения
        private void Print_dogovor_FormClosed(object sender, FormClosedEventArgs e)
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

        string name_putevka = "";
        string name_klient = "";
        string sposob_oplati = "";
        string sotrudnik = "";
        int count_children = 0;
        int count_putevki = 0;
        int price = 0;
        string date_build = "";
        string status_oplati = "";
        // метод позволяет вывести информацию из БД ,а также присвоить данные полученные после запроса в переменные
        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length > 0)
            {


                int id = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
                SqlConnection str = new SqlConnection(@"Data Source=PC-306-4\SQLEXPRESS;Initial Catalog=kyrs;Integrated Security=True");
                str.Open();
                SqlCommand command = new SqlCommand("select ID_Договора,Путевки.Название_путевки,Клиенты.ФИО as ФИО_Клиента ,Способы_оплаты.Способ_оплаты,Сотрудники.ФИО  as ФИО_Сотрудника,Количество_детей,Количество_путевок,Договора.Цена ,Дата_заключения, Статусы_оплаты.Статус_оплаты from Договора join Путевки on Путевки.ID_Путевки = Договора.ID_Путевки join Клиенты on Клиенты.ID_клиента = Договора.ID_Клиента join Способы_оплаты on Способы_оплаты.ID_Способа_оплаты = Договора.ID_Способа_оплаты join Сотрудники on Сотрудники.ID_Сотрудника = Договора.ID_Сотрудника join Статусы_оплаты on Статусы_оплаты.ID_Статуса_оплаты = Договора.ID_Статус_оплаты WHERE ID_Договора = @id", str);
                command.Parameters.AddWithValue("id", id);
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {

                    name_putevka = reader[1].ToString();
                    name_klient = reader[2].ToString();
                    sposob_oplati = reader[3].ToString();
                    sotrudnik = reader[4].ToString();
                    count_children = Convert.ToInt32(reader[5]);
                    count_putevki = Convert.ToInt32(reader[6]);
                    price = Convert.ToInt32(reader[7]);
                    date_build = reader[8].ToString();
                    status_oplati = reader[9].ToString();
                }
                reader.Close();
                str.Close();

                // дата , без времени 
                date_build = date_build.Substring(0, date_build.Length - 7);
                // Создаём шаблон документа WORD
                string name_doc = textBox1.Text + ".docx";
                string fileName = @"../Debug/" + name_doc + "";
                var doc = DocX.Create(fileName);
                doc.InsertParagraph("\t\t\t\t\tДоговор оказания услуг\n\n\n");
                //Create Table with 2 rows and 4 columns.  
                Table t = doc.AddTable(6, 2);
                t.Rows[0].Cells[0].Paragraphs.First().Append("Путёвка");
                t.Rows[1].Cells[0].Paragraphs.First().Append("Клиент");
                t.Rows[2].Cells[0].Paragraphs.First().Append("Способ оплаты");
                t.Rows[3].Cells[0].Paragraphs.First().Append("Сотрудник");
                t.Rows[4].Cells[0].Paragraphs.First().Append("Количество детей");
                t.Rows[5].Cells[0].Paragraphs.First().Append("Количество путёвок");
                t.Rows[0].Cells[1].Paragraphs.First().Append(name_putevka);
                t.Rows[1].Cells[1].Paragraphs.First().Append(name_klient);
                t.Rows[2].Cells[1].Paragraphs.First().Append(sposob_oplati);
                t.Rows[3].Cells[1].Paragraphs.First().Append(sotrudnik);
                t.Rows[4].Cells[1].Paragraphs.First().Append(count_children.ToString());
                t.Rows[5].Cells[1].Paragraphs.First().Append(count_putevki.ToString());
                doc.InsertTable(t);
                doc.InsertParagraph($"\n\n\nЦена: {price}\t\tДата заключения:\t {date_build}\t\tСтатус оплаты: {status_oplati}");
                doc.InsertParagraph($"\n\n\nКлиент__________|_________\t\t\t\t\tМенеджер__________|_________");
                doc.Save();
                Process.Start("WINWORD.EXE", fileName);
            }
            else
            {
                MessageBox.Show("Введите название документа");
            }


        }
        // метод позволяет вывести информацию из БД

        private void Print_dogovor_Load(object sender, EventArgs e)
        {
            SqlConnection str = new SqlConnection(@"Data Source=WIN-LK1QRPRQTC6\SQLEXPRESS;Initial Catalog=kyrs;Integrated Security=True");
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
    }
}
