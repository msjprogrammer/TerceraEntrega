using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoBDDM.models
{
    class Estudiante
    {
        private int estudiante_id;
        private string semestre_actual;
        private string nombre1E;
        private string nombre2E;
        private string apellido1E;
        private string apellido2E;
        private string telefonoE;
        private string correoE;

        public Estudiante()
        {
        }

        public Estudiante(int estudiante_id, string semestre_actual, string nombre1E, string nombre2E, string apellido1E, string apellido2E, string telefonoE, string correoE)
        {
            Estudiante_id = estudiante_id;
            Semestre_actual = semestre_actual;
            Nombre1E = nombre1E;
            Nombre2E = nombre2E;
            Apellido1E = apellido1E;
            Apellido2E = apellido2E;
            TelefonoE = telefonoE;
            CorreoE = correoE;
        }

        public int Estudiante_id { get => estudiante_id; set => estudiante_id = value; }
        public string Semestre_actual { get => semestre_actual; set => semestre_actual = value; }
        public string Nombre1E { get => nombre1E; set => nombre1E = value; }
        public string Nombre2E { get => nombre2E; set => nombre2E = value; }
        public string Apellido1E { get => apellido1E; set => apellido1E = value; }
        public string Apellido2E { get => apellido2E; set => apellido2E = value; }
        public string TelefonoE { get => telefonoE; set => telefonoE = value; }
        public string CorreoE { get => correoE; set => correoE = value; }
    }
}
