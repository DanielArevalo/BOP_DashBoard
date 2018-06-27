﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Milton.Models
{
    public class Activations
    {
        public string Nombre_Usuario { get; set; }
        public string CPF { get; set; }
        public string Correo { get; set; }
        public string Fecha_Nacimiento { get; set; }
        public string Celular { get; set; }
        public string Tarjeta { get; set; }
        public string Id_Usuario { get; set; }
        public string Pais { get; set; }
        public string Producto { get; set; }
        public string Codigo_App { get; set; }
        public string Codigo_Nombre { get; set; }
        public DateTime Fecha_Ini { get; set; }
        public DateTime Fecha_Fin { get; set; }
    }

    public class DateMonth
    {
        public string MonthName { get; set; }
        public int Month { get; set; }
        public int Year { get; set; }
    }

    public class ValMonth : DateMonth
    {
        public string Activation { get; set; }
        public string Cancellation { get; set; }
        public string Subscription { get; set; }
    }

    public class CpMetrics
    {
        public string Name { get; set; }
        public string Value { get; set; }
    }
}