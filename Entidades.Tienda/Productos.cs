﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Tienda
{
    public class Productos
    {
        private int _Id;
        private string _Nombre;
        private string _Descripcion;
        private double _Precio;

        public int Id { get => _Id; set => _Id = value; }
        public string Nombre { get => _Nombre; set => _Nombre = value; }
        public string Descripcion { get => _Descripcion; set => _Descripcion = value; }
        public double Precio { get => _Precio; set => _Precio = value; }
    }
}