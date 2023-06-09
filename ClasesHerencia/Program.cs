﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasesHerencia
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Estudiante estudiante = new Estudiante();
            estudiante.Cuenta = "jperez";
            estudiante.Password = "123456";
            estudiante.Nombre = "Juan";
            estudiante.Matricula = "56789A";

            estudiante.login("jperez", "123456");
            estudiante.login();

            //Listas en ves de Arrays en .Net C#
            List<Docente> listaDocentes = new List<Docente>();
            listaDocentes.Add(new Docente() {
                Cuenta= "smamani",
                Password = "12477",
                Nombre = "Saul",
                Sueldo = 1234
            });
            listaDocentes.Add(new Docente()
            {
                Cuenta = "sperez",
                Password = "12477",
                Nombre = "Ana",
                Sueldo = 123
            });
            listaDocentes.Add(new Docente()
            {
                Cuenta = "scarla",
                Password = "12477",
                Nombre = "Carla",
                Sueldo = 12
            });

            listaDocentes.Add(new Docente()
            {
                Cuenta = "lidia",
                Password = "12477",
                Nombre = "Lidia",
                Sueldo = 23
            });

            listaDocentes.Add(new Docente()
            {
                Cuenta = "jOSE",
                Password = "12477",
                Nombre = "Jose",
                Sueldo = 12
            });

             listaDocentes.Add(new Docente()
            {
                Cuenta = "Lisa",
                Password = "12477",
                Nombre = "lisa",
                Sueldo = 23
            });

             listaDocentes.Add(new Docente()
            {
                Cuenta = "Lidy",
                Password = "12477",
                Nombre = "lidi",
                Sueldo = 230
            });

            listaDocentes.Add(new Docente()
            {
                Cuenta = "Pepe",
                Password = "12477",
                Nombre = "pepe",
                Sueldo = 54
            });
            listaDocentes.Add(new Docente()
            {
                Cuenta = "robertot",
                Password = "897655",
                Nombre = "Roberto",
                Sueldo = 89
            });
            listaDocentes.Add(new Docente()
            {
                Cuenta = "pfernan",
                Password = "897051",
                Nombre = "Fernando",
                Sueldo = 150
            });

            MostrarLista(listaDocentes);

            Double promedio = getPromedio(listaDocentes);
            Console.WriteLine("\n--- Promedio: {0}", promedio.ToString("##.##"));

            double promedio2 = getPromedioDos(listaDocentes);
            Console.WriteLine("\n--- Promedio Dos: {0}", promedio2.ToString("##.##"));

            double promedio3 = getPromedioTres(listaDocentes);
            Console.WriteLine("\n--- Promedio Tres: {0}", promedio3.ToString("##.##"));

            double promedio4 = getPromedioCuatro(listaDocentes);
            Console.WriteLine("\n--- Promedio Cuatro Modificado: {0}", promedio4.ToString("##.##"));


            //Console.ReadKey(); 

            //lista de Estudiantes
            List<Estudiante> listaEstudiantes = new List<Estudiante>();
            listaEstudiantes.Add(new Estudiante()
            {
                Cuenta = "fjorge",
                Password = "45678",
                Nombre = "Jorge",
                Matricula = "78459F5R",
                Edad = 21
            });
            listaEstudiantes.Add(new Estudiante()
            {
                Cuenta = "lrenata",
                Password = "98765",
                Nombre = "Renata",
                Matricula = "78589H",
                Edad = 18
            });
            listaEstudiantes.Add(new Estudiante()
            {
                Cuenta = "jluis",
                Password = "45980",
                Nombre = "Jose",
                Matricula = "75112Y",
                Edad = 26
            });
            listaEstudiantes.Add(new Estudiante()
            {
                Cuenta = "jcarlos",
                Password = "89744",
                Nombre = "Carlos",
                Matricula = "7R8962",
                Edad = 27
            });
            listaEstudiantes.Add(new Estudiante()
            {
                Cuenta = "palfonso",
                Password = "8746",
                Nombre = "Alfonso",
                Matricula = "7895177E",
                Edad = 29
            });
            MostrarLista(listaEstudiantes);

            double promedioEs = getPromedioEs(listaEstudiantes);
            Console.WriteLine("\n--- PromedioEs:{0}", promedioEs.ToString("##.##"));

            double promedioEs2 = getPromedioEsDos(listaEstudiantes);
            Console.WriteLine("\n--- PromedioEs2:{0}", promedioEs2.ToString("##.##"));

            double promedioEs3 = getPromedioEsTres(listaEstudiantes);
            Console.WriteLine("\n--- PromedioEs3:{0}", promedioEs3.ToString("##.##"));

            double promedioEs4 = getPromedioEsCuatro(listaEstudiantes);
            Console.WriteLine("\n--- PromedioEs4:{0}", promedioEs4.ToString("##.##"));

            Console.ReadKey();
        }

        private static double getPromedioEsCuatro(List<Estudiante> listaEstudiantes)
        {
            //consultas LINQ
            double prom = (

                from item in listaEstudiantes
                where item.Edad < 27
                select item.Edad
                ).Average();
            return prom;
        }
        private static double getPromedioEsTres(List<Estudiante> listaEstudiantes)
        {
            //funciones Lambda
            double sum = listaEstudiantes.Sum(x => x.Edad);
            int total = listaEstudiantes.Count;
            return sum / total;
        }

        private static double getPromedioEsDos(List<Estudiante> listaEstudiantes)
        {
            double promedio = listaEstudiantes.Average(x => x.Edad);
            return promedio;
        }

        private static double getPromedioEs(List<Estudiante> listaEstudiantes)
        {
            double sum = 0;
            foreach (Estudiante item in listaEstudiantes)
            {
                sum += item.Edad;
            }
            return sum / listaEstudiantes.Count();
        }

        private static void MostrarLista(List<Estudiante> listaEstudiantes)
        {
            Console.WriteLine("\n----------- LISTA DE ESTUDIANTES -----------\n");
            foreach (Estudiante item in listaEstudiantes)
            {
                Console.WriteLine(item.ToString());
            }
        }


        private static double getPromedioCuatro(List<Docente> listaDocentes)
        {
            //consuntas LINQ
            decimal prom = (
                
                from item in listaDocentes
                where item.Sueldo < 200
                select item.Sueldo
                
                ).Average();
            return (double)prom;
        }

        private static double getPromedioTres(List<Docente> listaDocentes)
        {
            //funciones Lambda
            decimal sum = listaDocentes.Sum(x => x.Sueldo);
            int total = listaDocentes.Count;
            return (double)(sum / total);
        }

        private static double getPromedioDos(List<Docente> listaDocentes)
        {
            //Funcones lamda
            decimal promedio = listaDocentes.Average(x => x.Sueldo);
            return (double)promedio;
        }

        private static double getPromedio(List<Docente> listaDocentes)
        {
            Decimal sum = 0;
            foreach (Docente item in listaDocentes) {
                sum += item.Sueldo;
            }

            return (double)(sum / listaDocentes.Count()); //CAST
        }

        private static void MostrarLista(List<Docente> listaDocentes)
        {
            Console.WriteLine("\n------- LISTA DE DOCENTES y OTROSS --------\n");

            foreach (Docente item in listaDocentes)
            {
                Console.WriteLine(item.ToString());
            }
        }
    }
}
