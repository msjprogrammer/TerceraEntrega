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
using MySql.Data.MySqlClient;
using System.Linq.Expressions;
using System.Reflection;


namespace ProyectoBDDM.vista
{
    public partial class InterfazProfesor : Form
    {
        ConnectionBD objConnection= new ConnectionBD();
        public InterfazProfesor()
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
            string usuario = textBox1.Text;
            string password = textBox2.Text;

            ControllerProfesores objCP = new ControllerProfesores();
            bool result = objCP.SeleccionarUsuario(usuario, password);
            if (result)
            {
               // MessageBox.Show("Usuario encontrado");
               if(usuario.Equals(""))
                {
                    
                }
               else if (usuario.Equals(""))
                        {
                    InterfazInicioSesion
                    }
                }

            }
            else
            {
                MessageBox.Show("Usuario no encontrado");
            }
        }
        internal bool SeleccionarUsuario(string sql, string passwordP)
        {
            bool result = false;
            try
            {
                MySqlCommand cmd = new MySqlCommand(sql, objConnection.DataSource());
                objConnection.ConnectOpened();
                MySqlDataReader reader = cmd.ExecuteReader();
                if(reader.HasRows)
                {
                    while (reader.Read())
                    {
                        int profesor_id = reader.GetInt32(0);
                        string password = reader.GetString(1);

                        if(password.Equals(passwordP))
                        {
                            result = true;
                        }
                        
                    }
                }
            }
            catch (Exception w)
            {
                Console.WriteLine("ERRROOOOOOOOOOOOR " + w.Message);
                objConnection.ConnectClosed();
            }
            finally
            {
                objConnection.ConnectClosed();
            }
            return result;
        }
    }
   }
