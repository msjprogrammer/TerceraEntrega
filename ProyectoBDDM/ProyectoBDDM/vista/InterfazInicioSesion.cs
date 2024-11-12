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
using System.Linq.Expressions;
using System.Reflection;
using MySql.Data.MySqlClient;

namespace ProyectoBDDM.vista
{
    public partial class InterfazInicioSesion : Form
    {
        public InterfazInicioSesion()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            InterfazProfesor objIP = new InterfazProfesor();
            objIP = Show();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
