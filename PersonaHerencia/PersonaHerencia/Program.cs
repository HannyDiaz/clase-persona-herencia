using persona_herencia;
using PersonaHerencia;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace persona_herencia
{
    class Persona // Clase padre
    {
        // Variables protegidas para los datos de la persona
        protected string nombre;
        protected int edad;
        protected string fechaNacimiento;

        // Constructor para inicializar los datos de la persona
        public Persona(string nombre, int edad, string fechaNacimiento)
        {
            this.nombre = nombre;
            this.edad = edad;
            this.fechaNacimiento = fechaNacimiento;
        }
    }

    class Alumno : Persona // Clase hija Alumno
    {
        // Atributos específicos para alumnos
        public string Matricula { get; set; }
        public string Carrera { get; set; }

        // Constructor para inicializar los datos del alumno
        public Alumno(string nombre, int edad, string fechaNacimiento, string matricula, string carrera)
            : base(nombre, edad, fechaNacimiento)
        {
            Matricula = matricula;
            Carrera = carrera;
        }

        // Otros métodos relacionados con los alumnos
        // Por ejemplo: CalcularPromedio, InscribirCurso, etc.
    }

    class Empleado : Persona // Clase hija Empleado
    {
        // Variables específicas del empleado
        protected string cargo;
        protected double salario;

        // Constructor para inicializar los datos del empleado
        public Empleado(string nombre, int edad, string fechaNacimiento, string cargo, double salario)
            : base(nombre, edad, fechaNacimiento)
        {
            this.cargo = cargo;
            this.salario = salario;
        }

        // Otros métodos relacionados con los empleados
        // Por ejemplo: CalcularBonificaciones, EvaluarDesempeño, etc.
    }

    class Docente : Persona // Clase hija Docente
    {
        // Variables específicas para docentes
        protected string especialidad;

        // Constructor para inicializar los datos del docente
        public Docente(string nombre, int edad, string fechaNacimiento, string especialidad)
            : base(nombre, edad, fechaNacimiento)
        {
            this.especialidad = especialidad;
        }

        // Otros métodos relacionados con los docentes
        // Por ejemplo: AsignarTareas, EvaluarEstudiantes, etc.
    }

    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}

