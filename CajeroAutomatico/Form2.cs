using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CajeroAutomatico
{
    public partial class Form2 : Form
    {

        double capital = 700000;

        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            txtsaldo.Text = capital.ToString(); //carga el saldo de forma inicial

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string deposito = txtdeposito.Text;
            double depo;
            if (double.TryParse(deposito, out depo)) //chequea que el deposito sea un numero
            {
          
                capital = capital + depo;
                MessageBox.Show("DEPOSITO REALIZADO CON EXITO", "GRACIAS", MessageBoxButtons.OK);
                txtsaldo.Text = capital.ToString();

            }
            else
            {
                MessageBox.Show("POR FAVOR DIGITE UNA CANTIDAD DE DINERO", "ERROR", MessageBoxButtons.OK);
            }
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txtsaldo_TextChanged(object sender, EventArgs e)
        {
           
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string retiro = txtdeposito.Text;
            double reti;
            if (double.TryParse(retiro, out reti))
            {
                if (reti <= capital)         //se asegura de tener la cantidad de dinero necesaria
                {

                    capital = capital - reti;
                    MessageBox.Show("RETIRO REALIZADO CON EXITO", "GRACIAS", MessageBoxButtons.OK);
                    txtsaldo.Text = capital.ToString();
                }
                else
                {
                    MessageBox.Show("SALDO INSUFICIENTE", "ERROR", MessageBoxButtons.OK);
                }

            }

        }
        
        private void button3_Click(object sender, EventArgs e)
        {
            Form2 cajero2 = new Form2();            //Cierra sesion y vuelve a la pantalla principal
            cajero2.Visible = true;
            cajero2.Close();    
            //this.Dispose(false);
            Form1 cajero3 = new Form1();
            cajero3.Visible = true;
            cajero3.Show();
            this.Dispose(false);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
