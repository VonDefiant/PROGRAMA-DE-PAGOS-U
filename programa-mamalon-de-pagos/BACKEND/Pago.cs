using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace programa_mamalon_de_pagos.BACKEND
{
    public class Pago
    {
        // Propiedades
        public int IDPago { get; set; }
        public Estudiante Estudiante { get; set; }
        public Curso? CursoPago { get; set; }
        public DateTime FechaPago { get; set; }
        public decimal Monto { get; set; }
        public string MetodoPago { get; set; }
        public DateTime FechaVencimiento { get; set; }
        public decimal CantidadPagada { get; set; }
        public decimal Total { get; set; }

        //Metodo para identificar si el pago tiene mora
        public bool TieneMora()
        {
            // Fecha límite para el pago (coloque 5 dias pero este intervalo se puede cambiar)
            DateTime fechaLimite = FechaPago.AddDays(5);

            // Obtener la fecha actual
            DateTime fechaActual = DateTime.Now;

            // Verifica si la fecha actual es mayor a la fecha limite
            if (fechaActual > fechaLimite)
            {
                //Calcula el monto de mora (Basados en la uni es el 3.968% aprox)
                decimal mora = Monto * 0.03968253968253968253968253968254m;
                // El pago si tiene mora
                return true;
            }

            // El pago no tiene mora (aún esta dentro del plazo)
            return false;
        }
        // Constructor
        public Pago(int idPago, Estudiante estudiante, Curso cursoPago, DateTime fechaPago, decimal montoPago, string metodoPago)
        {
            IDPago = idPago;
            Estudiante = estudiante;
            CursoPago = cursoPago;
            FechaPago = fechaPago;
            Monto = montoPago;
            MetodoPago = metodoPago;
        }

        // Método para registrar un nuevo pago
        public static Pago RegistrarPago(int idPago, Estudiante estudiante,Curso cursoPago, decimal cantidad, string metodoPago)
        {
            // Corrige los valores negativos en la cantidad a pagar
            if(cantidad<=0)
            {
                throw new Exception("Cantidad no valida, ingrese valores mayores a cero");
            }

            // Obtener la fecha y hora actual como fecha de pago
            DateTime fechaPago = DateTime.Now;

            // Crear una nueva instancia de Pago
            Pago nuevoPago = new Pago(idPago, estudiante,cursoPago, fechaPago, cantidad, metodoPago);

            //Se debe crear logica para guardar estos info en db

            return nuevoPago;
        }

        // Método para verificar el estado del pago
        //Siento que este método esta de más
        public string VerificarEstadoPago()
        {
            // Verificar si el pago está completo
            if (EstaCompleto())
            {
                return "Completo";
            }

            // Verificar si el pago está pendiente
            if (FechaVencimiento > DateTime.Now)
            {
                return "Pendiente";
            }

            // El pago está vencido
            return "Vencido";
        }

        private bool EstaCompleto()
        {
            // Lógica para verificar si el pago está completo
            if (CantidadPagada == Total)
            {
                return true;
            }
            // Si la cantidad pagada es igual o mayor que el total, el pago está completo.
            return CantidadPagada >= Total;
        }
    }
}
