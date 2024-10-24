using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoBDDM.models
{
    class Departamento
    {
        private int departamento_id;
        private string nombre_departamento;

        public int Departamento_id { get => departamento_id; set => departamento_id = value; }
        public string Nombre_departamento { get => nombre_departamento; set => nombre_departamento = value; }
    }
}
