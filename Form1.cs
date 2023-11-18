using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace formulario
{
    public partial class Form1 : Form
    {
        int id = 1;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label3.Visible = false;
            label4.Visible = false;
            label5.Visible = false;
            label6.Visible = false;
            textBox3.Visible = false;
            dateTimePicker1.Visible = false;

            textBox1.Enabled = false;
            textBox1.Text = Convert.ToString(id);
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            //pessoa fisica 
            label4.Visible = true;
            label5.Visible = true;
            label3.Visible = false;
            label6.Visible = false;

            textBox3.Visible = true;
            dateTimePicker1.Visible = true;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            label3.Visible= true;
            label6.Visible= true;
            label4.Visible = false;
            label5.Visible = false;

            textBox3.Visible = true;
            dateTimePicker1.Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (textBox2.Text != string.Empty && textBox3.Text != string.Empty && comboBox1.Text != string.Empty)
            {
                textBox5.AppendText(textBox1.Text + " - " + textBox2.Text + " - " + textBox3.Text + " - " + dateTimePicker1.Value.Date.ToString("dd/MM/yyyy") + " - " + comboBox1.SelectedItem + "\r\n");
                id++;

                textBox1.Text = Convert.ToString(id);

                textBox2.Text = string.Empty;
                textBox3.Text = string.Empty;
                comboBox1.Text = string.Empty;

            }
            else { 
                MessageBox.Show("ERRO: Preencha os campos vazios"); 
            }


            
        }
    }
}
