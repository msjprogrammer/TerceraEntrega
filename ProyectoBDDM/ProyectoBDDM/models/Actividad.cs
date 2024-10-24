using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoBDDM.models
{
    class Actividad
    {
        private int actividad_id;
        private string nombreA;
        private string diaInicioA;
        private string descripcionA;
        private string diaFinA;

        public int Actividad_id { get => actividad_id; set => actividad_id = value; }
        public string NombreA { get => nombreA; set => nombreA = value; }
        public string DiaInicioA { get => diaInicioA; set => diaInicioA = value; }
        public string DescripcionA { get => descripcionA; set => descripcionA = value; }
        public string DiaFinA { get => diaFinA; set => diaFinA = value; }
    }
}
