using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FractionGame
{
    public class Fraccion
    {
        public int Numerador { get; set; }
        public int Denominador
        {
            get;
            set
            {
                if (value == 0) throw new DivideByZeroException("El Denominador no puede ser 0.");
                Denominador = value;
            }
        }

        //Constructores
        public Fraccion()
        {
            this.Numerador = 1;
            this.Denominador = 1;               
        }
        public Fraccion(int numerador, int denominador)
        {
            // TODO: Complete member initialization
            this.Numerador = numerador;
            this.Denominador = denominador;
        }

        //Metodos
        public Fraccion sumar(Fraccion F1, Fraccion F2)
        {
            Fraccion Result = new Fraccion();
            Result.Numerador = F1.Numerador + F2.Numerador;
            Result.Denominador = F1.Denominador + F2.Denominador;
            return Result;
        }

    }
}
