    using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProyectoBDDM.controllers;
using ProyectoBDDM.models;


namespace ProyectoBDDM.vista
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string profesor_id = textBox1.Text;
            string passwordP = textBox1.Text;

            ControllerProfesores objCP = new ControllerProfesores();
            bool result = objCP.SeleccionarUsuario(profesor_id, passwordP);
            if (result)
            {

            }
            else
            {
                MessageBox.Show("Usuario no encontrado");
            }
        }
    }
}
