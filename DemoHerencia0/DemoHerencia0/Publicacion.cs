using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoHerencia0
{

    using System;
    using System.Reflection.Emit;

    // Clase base Empleado
    
    public class Empleado
    {
        public string Nombre { get; set; }
        public int Edad { get; set; }
        public double Salario { get; set; }

        public Empleado(string nombre, int edad, double salario)
        {
            Nombre = nombre;
            Edad = edad;
            Salario = salario;
        }

        public void MostrarInformacion()
        {
            Console.WriteLine($"Nombre: {Nombre}");
            Console.WriteLine($"Edad: {Edad}");
            Console.WriteLine($"Salario: {Salario}");
        }
    }

    // Subclase Ingeniero, hereda de Empleado
    public class Ingeniero : Empleado
    {
        public Ingeniero(string nombre, int edad, double salario, string especialidad) : base(nombre, edad, salario)
        {
            Especialidad= especialidad;
        }



        // Propiedad específica para Ingeniero
        public string Especialidad { get; set; }

        // Método específico para Ingeniero
        public void MostrarEspecialidad()
        {
            Console.WriteLine($"Especialidad: {Especialidad}");
        }

        public int CalcularImpuesto()
        {
            return 0;
        }
    }

    // Subclase Disenador, hereda de Empleado
    public class Disenador : Empleado
    {
        public Disenador(string nombre, int edad, double salario, string tipoDiseno) : base(nombre, edad, salario)
        {
            TipoDeDiseno = tipoDiseno;
        }


        // Propiedad específica para Disenador
        public string TipoDeDiseno { get; set; }

        // Método específico para Disenador
        public void MostrarTipoDeDiseño()
        {
            Console.WriteLine($"Tipo de Diseño: {TipoDeDiseno}");
        }

        public int CalcularImpuesto()
        {
            return 0;
        }
    }

    public interface Fiscalizable
    {
        int CalcularImpuesto();
    }

    
}
