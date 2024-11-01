using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoBDDM.models
{
    internal class Entrega_actividades
    {
    

    private int idEA;
    private string fechaEntrega;
    private string descripcionEntrega; 
    private string archivoEntrega;
    private double calificacionEntrega;
    private string fechaCalificacion;
    private string comentarioEntrega;
    
    

        public Entrega_actividades(int idEA, string fechaEntrega, string descripcionEntrega, string archivoEntrega, double calificacionEntrega, string fechaCalificacion, string comentarioEntrega)
        {
            this.idEA = idEA;
            this.fechaEntrega = fechaEntrega;
            this.descripcionEntrega = descripcionEntrega;
            this.archivoEntrega = archivoEntrega;
            this.calificacionEntrega = calificacionEntrega;
            this.fechaCalificacion = fechaCalificacion;
            this.comentarioEntrega = comentarioEntrega;

        }
    }


}
