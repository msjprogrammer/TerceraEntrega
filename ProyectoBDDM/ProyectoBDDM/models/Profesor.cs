using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoBDDM.models
{
    class Profesor
    {
        private int profesor_id;
        private string nombre1P;
        private string nombre2P;
        private string apellido1P;
        private string apellido2P;
        private string telefonoP;
        private string correoP;

        public int Profesor_id { get => profesor_id; set => profesor_id = value; }
        public string Nombre1P { get => nombre1P; set => nombre1P = value; }
        public string Nombre2P { get => nombre2P; set => nombre2P = value; }
        public string Apellido1P { get => apellido1P; set => apellido1P = value; }
        public string Apellido2P { get => apellido2P; set => apellido2P = value; }
        public string TelefonoP { get => telefonoP; set => telefonoP = value; }
        public string CorreoP { get => correoP; set => correoP = value; }
    }
}
