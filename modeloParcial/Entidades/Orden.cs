using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modeloParcial.Entidades
{
    public class Orden
    {
        public int NroOrden { get; set; }

        public DateTime FechaOrden { get; set; }

        public string Responsable { get; set; }

        public List<DetalleOrden> Detalles { get; set; }

        public Orden()
        {
            Detalles = new List<DetalleOrden>();
        }

        public void AgregarDetalle(DetalleOrden detalle) { 
            Detalles.Add(detalle);
        }

        public void QuitarDetalle(int posicion) { 
            Detalles.RemoveAt(posicion);
        }
    }
}
