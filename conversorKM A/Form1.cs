using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace conversorKM_A
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Criar objeto
            //setar sua propriedade (valor)

            Converte converte = new Converte();

            converte.setV(txt_valor.Text);




            if (radioButton1.Checked)
            {
                txt_conversao.Text = converte.converteMilhas();
            }
            else
            {
                txt_conversao.Text = converte.converteKM();
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            lb_siglaValor.Text = "KM";
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            lb_siglaValor.Text = "MILHAS";
        }
    }
}
