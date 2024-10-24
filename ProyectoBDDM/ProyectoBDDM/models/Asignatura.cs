using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoBDDM.models
{
    class Asignatura
    {
        private int idAsignatura;
        private string nombre;
        private string descripcion;
        private string numCreditos;
        private long contenidoCurso;

        public Asignatura()
        {
        }

        public Asignatura(int idAsignatura, string nombre, string descripcion, string numCreditos, long contenidoCurso)
        {
            IdAsignatura = idAsignatura;
            Nombre = nombre;
            Descripcion = descripcion;
            NumCreditos = numCreditos;
            ContenidoCurso = contenidoCurso;
        }

        public int IdAsignatura { get => idAsignatura; set => idAsignatura = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Descripcion { get => descripcion; set => descripcion = value; }
        public string NumCreditos { get => numCreditos; set => numCreditos = value; }
        public long ContenidoCurso { get => contenidoCurso; set => contenidoCurso = value; }
    }
}
