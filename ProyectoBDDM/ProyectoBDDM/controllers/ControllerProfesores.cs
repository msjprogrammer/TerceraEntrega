using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProyectoBDDM.models;

namespace ProyectoBDDM.controllers
{
    class ControllerProfesores
    {
        internal bool SeleccionarUsuario( string usuario, string passwordP)
        {
            bool result = false;
            string sql = "select profesor_id,passwordP from profesor;";
            Profesor objs = new Profesor();

            result = objs.SeleccionarUsuario(sql, passwordP);


                return result;
        }
    }
}
