using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoHerencia0
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string Nombre = "Juan";
            int Edad = 30;
            int Salario = 50000;
            string Especialidad = "Ingeniería Civil";
            // Crear un objeto Ingeniero
            Ingeniero ingeniero = new Ingeniero(Nombre, Edad, Salario, Especialidad);

            // Mostrar información del ingeniero
            Console.WriteLine("Información del Ingeniero:");
            ingeniero.MostrarInformacion();
            ingeniero.MostrarEspecialidad();

            Console.WriteLine();

            Nombre = "María";
            Edad = 28;
            Salario = 45000;
            string TipoDeDiseno = "Diseño Gráfico";
            // Crear un objeto Disenador
            Disenador disenador = new Disenador(Nombre, Edad, Salario, TipoDeDiseno);

            // Mostrar información del disenador
            Console.WriteLine("Información del Disenador:");
            disenador.MostrarInformacion();
            disenador.MostrarTipoDeDiseño();

            //fiscalizar(disenador);
            Console.ReadLine();
        }

        static void fiscalizar(Fiscalizable contribuyente)
        {
            Console.WriteLine("Cobrando " + contribuyente.CalcularImpuesto());
        }
    }
}
