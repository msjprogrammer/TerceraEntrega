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
