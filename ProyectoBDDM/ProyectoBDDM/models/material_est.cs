using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoBDDM.models
{
   class material_est
    {
        private int idmaterial_est;
        private string nombreRecurso;
        private string descripcion;
        private DateTime fechaCreacion;

        public material_est()
        {
        }

        public material_est(int idmaterial_est, string nombreRecurso, string descripcion, DateTime fechaCreacion)
        {
            this.idmaterial_est = idmaterial_est;
            this.nombreRecurso = nombreRecurso;
            this.descripcion = descripcion;
            this.fechaCreacion = fechaCreacion;
        }

        public int Idmaterial_est { get => idmaterial_est; set => idmaterial_est = value; }
        public string NombreRecurso { get => nombreRecurso; set => nombreRecurso = value; }
        public string Descripcion { get => descripcion; set => descripcion = value; }
        public DateTime FechaCreacion { get => fechaCreacion; set => fechaCreacion = value; }
    }
}
