using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoBDDM.models
{
    class ActividadEstudiante
    {
        private int ActividadEstudiantes;
        private DateTime fechaCreacion;
        private string notaActvidad;
        private string comentarioP;

        public ActividadEstudiante()
        {
        }

        public ActividadEstudiante(int actividadEstudiantes, string notaActvidad, string comentarioP)
        {
            ActividadEstudiantes = actividadEstudiantes;
            this.notaActvidad = notaActvidad;
            this.comentarioP = comentarioP;
        }
    }

        

     
}
