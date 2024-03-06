using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace r24CASA
{
    public class CuentaOro : Cuenta
    {



        // CONSTANTES

        private const byte EDAD_MAX = 26;

        private const double RETIRAR_MAX = 1000;


        // MIEMBROS

        // PROPIEDADES

        // CONSTRUCTORES

        public CuentaOro(string titular)
        {
            Titular = titular;
        }

        public CuentaOro(string titular, double cantidad) : this(titular)
        {
            Ingresar(cantidad);
        }


        // MÉTODOS









        public override void Retirar(double ingreso)
        {
            throw new NotImplementedException();
        }

        public override void ValidarCantidad(double dato)
        {
            throw new NotImplementedException();
        }
    }
}
