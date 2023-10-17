using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace CajeroAutomatico
{
    public partial class Form1 : Form
    {
        int user = 116280709;   //Crear variables por defecto para identificacion y contraseña
        string pass = "tv77";
        string texto = "Escribe aquí...";
        string contra = "PIN de usuario";
        bool bloqueo = false;
        int contador = 1;

        public Form1()
        {
            InitializeComponent();
         
        }

      
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
         

        }

     

        private void btningresar_Click(object sender, EventArgs e)
        {
            
            string identi = txtiden.Text;
            double iden;

            if (contador < 3) // Este if se encarga de permitir solo 3 intentos de ingreso
            {
                if (double.TryParse(identi, out iden)) //Corrobora que sean datos numericos
                {
                    if (iden == user && txtpin.Text == pass)   //Corrobora que los datos sean correctos
                    {
                        Form2 cajero = new Form2();            //Ingresa a la pantalla del usuario y su cuenta
                        cajero.Visible = true;
                        cajero.Show();
                        this.Dispose(false);

                    }
                    else
                    {
                        MessageBox.Show("USUARIO O PIN INCORRECTO", "ERROR", MessageBoxButtons.OK);
                        int conta = 3 - contador; // lleva la cantidad de turnos que le quedan al usuario
                        MessageBox.Show("TE RESTAN " +conta +" INTENTOS", "ERROR", MessageBoxButtons.OK);
                        contador = contador + 1; //cuenta los intentos de ingreso

                    }


                }
                else
                {
                    MessageBox.Show("CARACTERES NO RECONOCIDOS", "ERROR", MessageBoxButtons.OK);
                }
            }
            else
            {
                MessageBox.Show("USUARIO BLOQUEADO", "ERROR", MessageBoxButtons.OK);
                this.Close();   
            }
           
            

        }

        private void txtpin_TextChanged(object sender, EventArgs e)
        {
           // txtpin.Text = "";
        } 


        private void txtpin_Click(object sender, EventArgs e)
        {
            txtpin.Text = "";
        }

        private void txtiden_Click(object sender, EventArgs e)
        {
            txtiden.Text = "";
        }
    }
}
