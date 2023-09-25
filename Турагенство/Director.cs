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
    public partial class Director : Form
    {
        public Director()
        {
            InitializeComponent();
        }
        //метод позволяет удалять активную сессию и все её активные связи прилождения
        private void Director_FormClosed(object sender, FormClosedEventArgs e)
        {
            System.Diagnostics.Process.GetCurrentProcess().Kill();
            Application.Exit();
        }
        //переход на другую форму
        private void button1_Click(object sender, EventArgs e)
        {
            Sotrudniki sotrudniki = new Sotrudniki();
            sotrudniki.Show();
            this.Hide();
        }
        //переход на другую форму
        private void button4_Click(object sender, EventArgs e)
        {
            Tyroperators tyroperators = new Tyroperators();
            tyroperators.Show();
            this.Hide();
        }
        //переход на другую форму
        private void button3_Click(object sender, EventArgs e)
        {
            Dogovors dogovors = new Dogovors();
            dogovors.Show();
            this.Hide();
        }
        //переход на другую форму
        private void button2_Click(object sender, EventArgs e)
        {
            Klients_director klients_director = new Klients_director();
            klients_director.Show();
            this.Hide();
        }
        //переход на другую форму
        private void button5_Click(object sender, EventArgs e)
        {
            Tours tours = new Tours();
            tours.Show();
            this.Hide();
        }
        //переход на другую форму
        private void button6_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }
        //переход на другую форму
        private void button7_Click(object sender, EventArgs e)
        {
            Mistakes_director director = new Mistakes_director();
            director.Show();
            this.Hide();
        }
    }
}
