using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoBDDM.vista
{
    public partial class Actividad : Form
    {
        public Actividad()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // Actividad
            // 
            this.ClientSize = new System.Drawing.Size(1220, 625);
            this.Name = "Actividad";
            this.Load += new System.EventHandler(this.Actividad_Load);
            this.ResumeLayout(false);

        }

        private void Actividad_Load(object sender, EventArgs e)
        {

        }
    }
}
