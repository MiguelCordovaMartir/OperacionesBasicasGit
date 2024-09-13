﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace operacionesBasicas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            //Declaracion de variables
            double num1 = int.Parse(txtNumero1.Text);
            double num2 = int.Parse(txtNumero2.Text);



            //Proceso
            double suma = num1 + num2;
            double resta = num1 - num2;



            //Salida de datos 
            txtResultado.Text = $" La suma es: {suma} " +
               $"La resta es: {resta}";
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
