using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora
{
    public partial class Form1 : Form
    {
        double N1, N2, N3;
        string operacion;
        public Form1()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button15_Click(object sender, EventArgs e)
        {
            Display.Text = Display.Text + "7";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Display.Text = Display.Text + "1";

        }

        private void txtpantalla(object sender, EventArgs e)
        {

        }

        private void buttoncero_Click(object sender, EventArgs e)
        {
            Display.Text = Display.Text + "0";
        }

        private void buttondos_Click(object sender, EventArgs e)
        {
            Display.Text = Display.Text + "2";

        }

        private void buttontres_Click(object sender, EventArgs e)
        {
            Display.Text = Display.Text + "3";

        }

        private void buttoncuatro_Click(object sender, EventArgs e)
        {
            Display.Text = Display.Text + "4";
        }

        private void buttoncinco_Click(object sender, EventArgs e)
        {
            Display.Text = Display.Text + "5";
        }

        private void buttonseis_Click(object sender, EventArgs e)
        {
            Display.Text = Display.Text + "6";
        }

        private void buttonocho_Click(object sender, EventArgs e)
        {
            Display.Text = Display.Text + "8";
        }

        private void buttonnueve_Click(object sender, EventArgs e)
        {
            Display.Text = Display.Text + "9";
        }

        private void buttonmultiplicar_Click(object sender, EventArgs e)
        {
            operacion = "*";
            N1 = double.Parse(Display.Text);
            Display.Clear();
        }

        private void buttonrestar_Click(object sender, EventArgs e)
        {
            operacion = "-";
            N1 = double.Parse(Display.Text);
            Display.Clear();
        }

        private void buttonsumar_Click(object sender, EventArgs e)
        {
            operacion = "+";
            N1 = double.Parse(Display.Text);
            Display.Clear();
        }

        private void buttonigual_Click(object sender, EventArgs e)
        {
            N2 = double.Parse(Display.Text);

            switch (operacion)
            {
                case "+":
                    N3 = N1 + N2;
                    Display.Text = N3.ToString();
                    break;
                case "-":
                    N3 = N1 - N2;
                    Display.Text = N3.ToString();
                    break;
                case "*":
                    N3 = N1 * N2;
                    Display.Text = N3.ToString();
                    break;
                case "/":
                    N3 = N1 / N2;
                    Display.Text = N3.ToString();
                    break;
            }
        }

        private void buttonCE_Click(object sender, EventArgs e)
        {
            Display.Clear();
        }

        private void buttondelete_Click(object sender, EventArgs e)
        {
            if (Display.Text.Length == 1)
                Display.Text = "";
            else
                Display.Text = Display.Text.Substring(0, Display.Text.Length - 1);
        }

        private void buttondividir_Click(object sender, EventArgs e)
        {
            operacion = "/";
            N1 = double.Parse(Display.Text);
            Display.Clear();
        }

        private void buttonpunto_Click(object sender, EventArgs e)
        {
            Display.Text = Display.Text + ".";

        }
    }
}
