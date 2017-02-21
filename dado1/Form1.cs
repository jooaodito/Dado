using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dado1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int i = 1;

            Random rnd = new Random();

            int totalPlay2 = 0;

            if ( i == 1)
            {
                int valor1 = rnd.Next(1, 7);
                textBox2.Text = valor1.ToString();
                totalPlay2 += valor1;
                i++;
            }

            if (i == 2)
            {
                int valor2 = rnd.Next(1, 7);
                textBox3.Text = valor2.ToString();
                totalPlay2 += valor2;
                i++;
            }

            if (i == 3)
            {
                int valor3 = rnd.Next(1, 7);
                textBox5.Text = valor3.ToString();
                totalPlay2 += valor3;
                i++;
            }

            textBox7.Text = totalPlay2.ToString();

            int player1 = Int32.Parse(textBox7.Text);
            int player2 = Int32.Parse(textBox8.Text);

            if (player1 > player2)
            {
                MessageBox.Show("Player 2 - Vencedor!");
            }
            else
            if (player2 > player1)
            {
                MessageBox.Show("Player 1 - Vencedor!");
            }
            else
            {
                MessageBox.Show("Empate!");
            }

            button1.Enabled = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int i = 1;

            Random rnd = new Random();

            int totalPlay1 = 0;

            if (i == 1)
            {
                int valor4 = rnd.Next(1, 7);
                textBox1.Text = valor4.ToString();
                totalPlay1 += valor4;
                i++;
            }

            if (i == 2)
            {
                int valor5 = rnd.Next(1, 7);
                textBox4.Text = valor5.ToString();
                totalPlay1 += valor5;
                i++;
            }

            if (i == 3)
            {
                int valor6 = rnd.Next(1, 7);
                textBox6.Text = valor6.ToString();
                totalPlay1 += valor6;
                i++;
            }

            textBox8.Text = totalPlay1.ToString();

            button2.Enabled = false;
        }


 

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
