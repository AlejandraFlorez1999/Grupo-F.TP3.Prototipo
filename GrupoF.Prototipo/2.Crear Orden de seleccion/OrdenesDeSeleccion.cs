﻿using GrupoF.Prototipo._1.Crear_Orden_de_Preparacion;
using GrupoF.Prototipo._2.Crear_Orden_de_seleccion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrupoF.Prototipo._3.Procesar_Orden_de_Seleccion
{
    internal class OrdenesDeSeleccion
    {
        public int ID_OS { get; set; }
        public EstadoOSEnum Estado_OS { get; set; }
        public DateTime Emision_OrdenDeSeleccion { get; set; }
        public DateTime AcualizacionEstado_OrdenDeSeleccion { get; set; }
    }
}
