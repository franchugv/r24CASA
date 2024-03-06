using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace r24CASA
{
    public abstract class Cuenta
    {

        // CONSTANTES

        protected string _titular;
        protected double _cantidad;

        protected string _numCuenta;
        protected DateTime _fechaNac;

        // MIEMBROS



        // PROPIEDADES




        public virtual string Titular
        {
            get
            {
                return _titular;
            }
            set
            {
                ValidarCadena(value);
                _titular = value;
            }
        }

        public virtual double Cantidad
        {
            get
            {
                return _cantidad;
            }
            // SOLO LECTURA
        }

        public virtual DateTime FechaNac
        {
            get
            {
                return _fechaNac;
            }
            set
            {
                ValidarFecha(value);
                _fechaNac = value;
            }
        }


        // NO VIRTUAL
        public string NumCuenta
        {
            get
            {
                return _numCuenta;
            }
            set
            {
                ValidarNumCuenta(value);
                _numCuenta = value;
            }
        }

        // MÉTODOS

        public virtual void Ingresar(double ingreso)


        {
            // VALIDACIÓM
            ValidarIngreso(ingreso);

            // PROCESO
            _cantidad += ingreso;
        }


        // POR ESTABLECER
        public abstract void Retirar(double ingreso);

        public abstract void ValidarCantidad(double dato);

        public virtual string ToString()
        {
            // RECURSOS
            string cadena = "";

            // PROCESO DEL TOSTRING
            cadena = $"Usuario: {Titular}\n";
            cadena += $"Cantidad: {Cantidad}\n";
            cadena += $"Número de cuenta: {NumCuenta}\n";
            cadena += $"Fecha de nacimiento: {FechaNac}\n";


            return cadena;
        }


        public static void ValidarIngreso(double ingreso)
        {
            if (ingreso <= 0) throw new OverflowException("Sin existencias");
        }

        public virtual void ValidarCadena(string cadena)
        {
            // REMOVER ESPACIOS

            cadena = cadena.Trim();

            // Validar cadena vacía

            if (string.IsNullOrEmpty(cadena)) throw new ArgumentException("Cadena vacía");

            if (!cadena.All(char.IsLetter)) throw new ArgumentException("No es letra");
        }

        public virtual void ValidarFecha(DateTime fecha)
        {
             if (fecha >= DateTime.Now) throw new FechaIncorrectaException();
        }

        // MÉTODOS NO PERSONALIZABLES
        private static void ValidarNumCuenta(string cadena)
        {
            // RECURSOS
            const byte CADENA_MAX = 20;

            cadena = cadena.Trim();

            // VALIDACIÓN
            if (cadena.Length != 20) throw new OverflowException("Longitud incorrecta");

            if (!cadena.All(char.IsAsciiDigit)) throw new FormatException("Formato incorrecto");

        }
    }



    public class FechaIncorrectaException : Exception
    {
        public FechaIncorrectaException() : base("Fecha Incorrecta") { } 
        public FechaIncorrectaException(string mensaje) : base(mensaje) { }
    }
}
