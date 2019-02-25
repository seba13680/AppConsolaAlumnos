using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace alumnosNotas
{
    class Program
    {
        static void Main(string[] args)
        {

            int contadorUno = 0;
            int contadorDos = 0;
            int contadorTres = 0;
            int contadorCuatro = 0;
            int contadorCinco = 0;
            int contadorSeis = 0;
            int contadorSiete = 0;
            int contadorOcho = 0;
            int contadorNueve = 0;
            int contadorDiez = 0;

            List<listaAlumnos> lstalumnos = new List<listaAlumnos>();

            lstalumnos.Add(new listaAlumnos() { alumnoNombre = "Samantha ", alumnoNota = 10 });
            lstalumnos.Add(new listaAlumnos() { alumnoNombre = "Analia", alumnoNota = 7 });
            lstalumnos.Add(new listaAlumnos() { alumnoNombre = "Brenda", alumnoNota = 8 });
            lstalumnos.Add(new listaAlumnos() { alumnoNombre = "Carolina", alumnoNota = 9 });
            lstalumnos.Add(new listaAlumnos() { alumnoNombre = "Jimena", alumnoNota = 10 });
            lstalumnos.Add(new listaAlumnos() { alumnoNombre = "Cristina", alumnoNota = 9 });
            lstalumnos.Add(new listaAlumnos() { alumnoNombre = "Eva", alumnoNota = 9 });
            lstalumnos.Add(new listaAlumnos() { alumnoNombre = "Juliana", alumnoNota = 10 });
            lstalumnos.Add(new listaAlumnos() { alumnoNombre = "Emilia", alumnoNota = 7 });
            lstalumnos.Add(new listaAlumnos() { alumnoNombre = "Carla", alumnoNota = 8 });
            lstalumnos.Add(new listaAlumnos() { alumnoNombre = "Matias", alumnoNota = 4 });
            lstalumnos.Add(new listaAlumnos() { alumnoNombre = "Analia", alumnoNota = 8 });
            lstalumnos.Add(new listaAlumnos() { alumnoNombre = "Mariana", alumnoNota = 10 });
            lstalumnos.Add(new listaAlumnos() { alumnoNombre = "Carlos", alumnoNota = 9 });
            lstalumnos.Add(new listaAlumnos() { alumnoNombre = "Juan", alumnoNota = 5 });
            lstalumnos.Add(new listaAlumnos() { alumnoNombre = "José", alumnoNota = 6 });
            lstalumnos.Add(new listaAlumnos() { alumnoNombre = "Marcelo", alumnoNota = 6 });
            lstalumnos.Add(new listaAlumnos() { alumnoNombre = "Pedro", alumnoNota = 6 });
            lstalumnos.Add(new listaAlumnos() { alumnoNombre = "Facundo", alumnoNota = 7 });
            lstalumnos.Add(new listaAlumnos() { alumnoNombre = "Abril", alumnoNota = 8 });
            lstalumnos.Add(new listaAlumnos() { alumnoNombre = "Erica", alumnoNota = 8 });
            lstalumnos.Add(new listaAlumnos() { alumnoNombre = "Cristian", alumnoNota = 8 });
            lstalumnos.Add(new listaAlumnos() { alumnoNombre = "Ezequiel", alumnoNota = 7 });
            lstalumnos.Add(new listaAlumnos() { alumnoNombre = "Franco", alumnoNota = 8 });
            lstalumnos.Add(new listaAlumnos() { alumnoNombre = "Solange", alumnoNota = 9 });

            // Lista de alumnos aprobados y ordenados alfabeticamente
            Console.WriteLine("-- Lista alumnos aprobados ordenados por nombre --");

            foreach (var listaAlumnos in lstalumnos.OrderBy(x => x.alumnoNombre))
            {
                if (listaAlumnos.alumnoNota >= 6)
                {
                    Console.WriteLine("Nombre alumno : " + listaAlumnos.alumnoNombre + " Nota : " + listaAlumnos.alumnoNota);

                }

            }

            // Lista de alumnos desaprobados y ordenados alfabeticamente
            Console.WriteLine("-- Lista alumnos desaprobados ordenados por nombre --");

            foreach (var listaAlumnos in lstalumnos.OrderBy(x => x.alumnoNombre))
            {
                if (listaAlumnos.alumnoNota < 6)
                {
                    Console.WriteLine("Nombre alumno : " + listaAlumnos.alumnoNombre + " Nota : " + listaAlumnos.alumnoNota);

                }

            }

            // Ordenados por nota
            Console.WriteLine("-- Lista de examenes por nota --");
            foreach (var listaAlumnos in lstalumnos)
            {
                switch (listaAlumnos.alumnoNota)
                {
                    case 1:
                        contadorUno = contadorUno + 1;
                        break;
                    case 2:
                        contadorDos = contadorDos + 1;
                        break;
                    case 3:
                        contadorTres = contadorTres + 1;
                        break;
                    case 4:
                        contadorCuatro = contadorCuatro + 1;
                        break;
                    case 5:
                        contadorCinco = contadorCinco + 1;
                        break;
                    case 6:
                        contadorSeis = contadorSeis + 1;
                        break;
                    case 7:
                        contadorSiete = contadorSiete + 1;
                        break;
                    case 8:
                        contadorOcho = contadorOcho + 1;
                        break;
                    case 9:
                        contadorNueve = contadorNueve + 1;
                        break;
                    case 10:
                        contadorDiez = contadorDiez + 1;
                        break;
                }              

            }

            Console.WriteLine("Alumnos con la nota 1 : " + contadorUno);
            Console.WriteLine("Alumnos con la nota 2 : " + contadorDos);
            Console.WriteLine("Alumnos con la nota 3 : " + contadorTres);
            Console.WriteLine("Alumnos con la nota 4 : " + contadorCuatro);
            Console.WriteLine("Alumnos con la nota 5 : " + contadorCinco);
            Console.WriteLine("Alumnos con la nota 6 : " + contadorSeis);
            Console.WriteLine("Alumnos con la nota 7 : " + contadorSiete);
            Console.WriteLine("Alumnos con la nota 8 : " + contadorOcho);
            Console.WriteLine("Alumnos con la nota 9 : " + contadorNueve);
            Console.WriteLine("Alumnos con la nota 10 : " + contadorDiez);
            
            Console.WriteLine("Presione una tecla para salir...");
            Console.ReadKey();

        }
    }
}
