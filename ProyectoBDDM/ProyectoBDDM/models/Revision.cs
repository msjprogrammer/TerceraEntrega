using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoBDDM.models
{
    class Revision
    {
        private string idRevision;
        private DateTime fechaCreacion;
    public Revision()
        {
        }

        public Revision(string idRevision, DateTime fechaCreacion)
        {
            IdRevision = idRevision;
            FechaCreacion = fechaCreacion;
        }

    

        public string IdRevision { get => idRevision; set => idRevision = value; }
        public DateTime FechaCreacion { get => fechaCreacion; set => fechaCreacion = value; }
    }
}
