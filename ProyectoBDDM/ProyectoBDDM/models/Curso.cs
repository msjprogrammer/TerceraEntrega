﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoBDDM.models
{
    class Curso
    {
        private int curso_id;
        private string descrpicionC;
        private string nombreC;
        private string cateogoriaC;

        public int Curso_id { get => curso_id; set => curso_id = value; }
        public string DescrpicionC { get => descrpicionC; set => descrpicionC = value; }
        public string NombreC { get => nombreC; set => nombreC = value; }
        public string CateogoriaC { get => cateogoriaC; set => cateogoriaC = value; }
    }
}