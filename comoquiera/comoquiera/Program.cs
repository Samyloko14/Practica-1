using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace comoquiera
{
    class Program
    {
        static void Main(string[] args)
        {
            Alumno _alumno = new Alumno();
            Profesor _profesor = new Profesor();
            _alumno.Edad = 17;
            _alumno.Nombre = "Samy";
            _alumno.NoControl = 14;

            _profesor.Edad = 23;
            _profesor.Nombre = "Erick";
            _profesor.sueldo = 1;

            Console.WriteLine("La edad del alumno es: {1} y NoControl: {2}", _alumno.Edad,_alumno.Nombre,_alumno.NoControl);
            Console.WriteLine("La edad del Prefesor es: {1} y sueldo: {2}", _profesor.Edad, _profesor.Nombre, _profesor.sueldo);
   
            Console.ReadKey();
        }
    }
}
