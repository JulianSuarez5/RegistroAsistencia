using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegistroAsistencia
{
    internal class clsRegistroAsistencia
    {
        public DateTime Fecha { get; set; } // Propiedad pública de tipo DateTime llamada Fecha.
        public string NombreEstudiante { get; set; } // Propiedad pública de tipo string llamada NombreEstudiante.
        public bool EstadoAsistencia { get; set; } // Propiedad pública de tipo bool llamada EstadoAsistencia.
        public int NumeroIdentificacion { get; set; } // Propiedad pública de tipo int llamada NumeroIdentificacion.

        public clsRegistroAsistencia(DateTime fecha, string nombreEstudiante, bool estadoAsistencia, int numeroIdentificacion) // Constructor de la clase clsRegistroAsistencia.
        {
            Fecha = fecha; // Asigna el valor de fecha a la propiedad Fecha.
            NombreEstudiante = nombreEstudiante; // Asigna el valor de nombreEstudiante a la propiedad NombreEstudiante.
            EstadoAsistencia = estadoAsistencia; // Asigna el valor de estadoAsistencia a la propiedad EstadoAsistencia.
            NumeroIdentificacion = numeroIdentificacion; // Asigna el valor de numeroIdentificacion a la propiedad NumeroIdentificacion.
        }

        // Método para marcar la asistencia.
        public void MarcarAsistencia(bool estadoAsistencia)
        {
            EstadoAsistencia = estadoAsistencia; // Asigna el valor de estadoAsistencia a la propiedad EstadoAsistencia.
        }

        // Método para generar reportes.
        public string GenerarReporte()
        {
            return $"Fecha: {Fecha}, Nombre del Estudiante: {NombreEstudiante}, Estado de Asistencia: {EstadoAsistencia}, Número de Identificación: {NumeroIdentificacion}"; // Devuelve una cadena formateada con los valores de las propiedades.
        }
    }
}

