using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace r24CASA
{
    public class CuentaJoven : Cuenta
    {

        // CONSTANTES

        private const byte EDAD_MAX = 26;
        private const byte EDAD_MIN = 18;

        private const double RETIRAR_MAX = 500;


        // MIEMBROS

        // PROPIEDADES

        // CONSTRUCTORES

        public CuentaJoven(string titular) 
        { 
            Titular = titular;
        }

        public CuentaJoven(string titular, double cantidad) :this(titular)
        {
            Ingresar(cantidad);
        }


        // MÉTODOS

        public override void Retirar(double ingreso)
        {

            // VALIDACIÓN
            ValidarCantidad(ingreso);

            _cantidad -= ingreso; 
            // PROCEOS
      
        }

        public override void ValidarFecha(DateTime fecha)
        {
            base.ValidarFecha(fecha);

            // Menor a la fecha mínima
            if (fecha > DateTime.Today.AddYears(-EDAD_MIN)) throw new FechaIncorrectaException("Menor a la fecha mínima");
            // Mayor a la fecha máxima
            if (fecha < DateTime.Today.AddYears(-EDAD_MAX)) throw new FechaIncorrectaException("Mayor a la fecha máxima");
        }

        public override void ValidarCantidad(double dato)
        {
            // Validar que no supere el máximo permitido
            if (dato <= 0) throw new Exception("Cantidad Incorrecta");
            if (dato > RETIRAR_MAX) throw new OverflowException("Cantidad Incorrecta");
        }

      
    }
}
