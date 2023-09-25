using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Турагенство
{
    public partial class Manager : Form
    {
        public Manager()
        {
            InitializeComponent();
        }
        //метод позволяет удалять активную сессию и все её активные связи прилождения
        private void Manager_FormClosed(object sender, FormClosedEventArgs e)
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
        //переход на другую форму
        private void button2_Click(object sender, EventArgs e)
        {
            Klients_manager klients_Manager = new Klients_manager();
            klients_Manager.Show();
            this.Hide();
        }
        //переход на другую форму
        private void button3_Click(object sender, EventArgs e)
        {
            Print_dogovor print_Dogovor = new Print_dogovor();
            print_Dogovor.Show();
            this.Hide();


        }
        //переход на другую форму
        private void button4_Click(object sender, EventArgs e)
        {

            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }
        //переход на другую форму
        private void button5_Click(object sender, EventArgs e)
        {
            Putevki putevki = new Putevki();
            putevki.Show();
            this.Hide();
        }
        //переход на другую форму
        private void button6_Click(object sender, EventArgs e)
        {
            Mistaces mistaces = new Mistaces();
            mistaces.Show();
            this.Hide();
        }
    }
}
