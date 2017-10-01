using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {

        static bool continuar = false;
        static void Main(string[] args)
        {
            Departamento.llenarListaVacia();
            while (!login())
            {
                Console.Clear();
            }
            while (!continuar)
            {
                Menu();
            }
        }

        private static void Menu()
        {
            if (Usuario.isAdmin)
            {
                Console.Clear();
                Console.WriteLine("                 Bienvenido al censo 2017");
                Console.WriteLine("1) Ingreso de datos");
                Console.WriteLine("2) Reportes");
                Console.WriteLine("3) Accesos");
                Console.Write("> ");
                redirigirAdmin(Console.ReadLine());
            }
            else
            {
                Console.Clear();
                Console.WriteLine("                 Bienvenido al censo 2017");
                Console.WriteLine("1) Ingreso de datos");
                Console.WriteLine("2) Reportes");
                Console.Write("> ");
                redirigirAdmin(Console.ReadLine());
            }
        }

        private static void ingresoDeDatosPorDepartamento()
        {
            Console.Clear();
            Console.WriteLine("LISTADO DE DEPARTAMENTOS: ");
            Departamento.listadoDeDepartamentos();
            Console.Write("> ");
            try
            {
                int departamento = int.Parse(Console.ReadLine());
                if (departamento<1 || departamento>22)
                {
                    ingresoDeDatosPorDepartamento();
                }
                ingresoDeDatos(departamento);
            }
            catch (FormatException)
            {
                ingresoDeDatosPorDepartamento();
                throw;
            }
        }


        private static void ingresoDeDatos(int departamento)
        {
            Console.Clear();
            int hf010, hf1120, hf2130, hf3140, hf4150, hf5160, hf6170, hf71;
            int hm010, hm1120, hm2130, hm3140, hm4150, hm5160, hm6170, hm71;
            try
            {
                Console.Write("Ingrese el numero de habitantes femeninos entre 0 y 10 años: ");
                hf010 = int.Parse(Console.ReadLine());
                Console.Write("Ingrese el numero de habitantes femeninos entre 11 y 20 años: ");
                hf1120 = int.Parse(Console.ReadLine());
                Console.Write("Ingrese el numero de habitantes femeninos entre 21 y 30 años: ");
                hf2130 = int.Parse(Console.ReadLine());
                Console.Write("Ingrese el numero de habitantes femeninos entre 31 y 40 años: ");
                hf3140 = int.Parse(Console.ReadLine());
                Console.Write("Ingrese el numero de habitantes femeninos entre 41 y 50 años: ");
                hf4150 = int.Parse(Console.ReadLine());
                Console.Write("Ingrese el numero de habitantes femeninos entre 51 y 60 años: ");
                hf5160 = int.Parse(Console.ReadLine());
                Console.Write("Ingrese el numero de habitantes femeninos entre 61 y 70 años: ");
                hf6170 = int.Parse(Console.ReadLine());
                Console.Write("Ingrese el numero de habitantes femeninos entre 71 o más años: ");
                hf71 = int.Parse(Console.ReadLine());
                Console.Write("Ingrese el numero de habitantes masculinos entre 0 y 10 años: ");
                hm010 = int.Parse(Console.ReadLine());
                Console.Write("Ingrese el numero de habitantes masculinos entre 11 y 20 años: ");
                hm1120 = int.Parse(Console.ReadLine());
                Console.Write("Ingrese el numero de habitantes masculinos entre 21 y 30 años: ");
                hm2130 = int.Parse(Console.ReadLine());
                Console.Write("Ingrese el numero de habitantes masculinos entre 31 y 40 años: ");
                hm3140 = int.Parse(Console.ReadLine());
                Console.Write("Ingrese el numero de habitantes masculinos entre 41 y 50 años: ");
                hm4150 = int.Parse(Console.ReadLine());
                Console.Write("Ingrese el numero de habitantes masculinos entre 51 y 60 años: ");
                hm5160 = int.Parse(Console.ReadLine());
                Console.Write("Ingrese el numero de habitantes masculinos entre 61 y 70 años: ");
                hm6170 = int.Parse(Console.ReadLine());
                Console.Write("Ingrese el numero de habitantes masculinos entre 71 o más años: ");
                hm71 = int.Parse(Console.ReadLine());
                Departamento.listaDepartamentos.ElementAt(departamento - 1).HabitantesFemeninosEntreCeroYDiez = hf010;
                Departamento.listaDepartamentos.ElementAt(departamento - 1).HabitantesFemeninosEntreOnceYVeinte = hf1120;
                Departamento.listaDepartamentos.ElementAt(departamento - 1).HabitantesFemeninosEntreVeintiunoYTreinta = hf2130;
                Departamento.listaDepartamentos.ElementAt(departamento - 1).HabitantesFemeninosEntreTreitayunoYCuarenta = hf3140;
                Departamento.listaDepartamentos.ElementAt(departamento - 1).HabitantesFemeninosEntreCuarentayunoYCincuenta = hf4150;
                Departamento.listaDepartamentos.ElementAt(departamento - 1).HabitantesFemeninosEntreCincuentayunoYSesenta = hf5160;
                Departamento.listaDepartamentos.ElementAt(departamento - 1).HabitantesFemeninosEntreSesentayunoYSetenta = hf6170;
                Departamento.listaDepartamentos.ElementAt(departamento - 1).HabitantesFemeninosEntreSetentayunoOmas = hf71;
                Departamento.listaDepartamentos.ElementAt(departamento - 1).HabitantesMasculinosEntreCeroYDiez = hm010;
                Departamento.listaDepartamentos.ElementAt(departamento - 1).HabitantesMasculinosEntreOnceYVeinte = hm1120;
                Departamento.listaDepartamentos.ElementAt(departamento - 1).HabitantesMasculinosEntreVeintiunoYTreinta = hm2130;
                Departamento.listaDepartamentos.ElementAt(departamento - 1).HabitantesMasculinosEntreTreitayunoYCuarenta = hm3140;
                Departamento.listaDepartamentos.ElementAt(departamento - 1).HabitantesMasculinosEntreCuarentayunoYCincuenta = hm4150;
                Departamento.listaDepartamentos.ElementAt(departamento - 1).HabitantesMasculinosEntreCincuentayunoYSesenta = hm5160;
                Departamento.listaDepartamentos.ElementAt(departamento - 1).HabitantesMasculinosEntreSesentayunoYSetenta = hm6170;
                Departamento.listaDepartamentos.ElementAt(departamento - 1).HabitantesMasculinosEntreSetentayunoOmas = hm71;
                Console.WriteLine("Departamento actualizado!");
                Console.WriteLine("1) Volver al menu!");
                Console.WriteLine("2) Salir!");
                int respuesta = int.Parse(Console.ReadLine());
                if (respuesta == 1)
                {
                    Menu();
                }
                if (respuesta == 2)
                {
                    continuar = true;
                }
                if (respuesta != 1 && respuesta != 2)
                {
                    Menu();
                }
            }
            catch (FormatException)
            {
                ingresoDeDatos(departamento);
                throw;
            }   
        }


        private static void reportes()
        {
            bool siguiente = false;
            while (!siguiente)
            {
                Console.Write("Ingrese n para reporte nacional y d para departamental> ");
                string respuesta = Console.ReadLine();
                if (respuesta == "n" || respuesta == "N")
                {
                    Departamento.reportesPorPais();
                }
                if (respuesta == "d" || respuesta == "D")
                {
                    Console.WriteLine("LISTADO DE DEPARTAMENTOS: ");
                    Departamento.listadoDeDepartamentos();
                    Console.Write("> ");
                    try
                    {
                        int departamento = int.Parse(Console.ReadLine());
                        if (!(departamento < 1 || departamento > 22))
                        {
                            Departamento.reportesPorDepartamento(departamento);
                        }
                        else
                        {
                            reportes();
                        }

                    }
                    catch (FormatException)
                    {
                        reportes();
                        throw;
                    }
                }
                Console.WriteLine("1) Volver al menu!");
                Console.WriteLine("2) Salir!");
                int respuesta2 = int.Parse(Console.ReadLine());
                if (respuesta2 == 1)
                {
                    Menu();
                }
                if (respuesta2 == 2)
                {
                    continuar = true;
                }
                if (respuesta2!= 1 && respuesta2 != 2)
                {
                    Menu();
                }
            }
        }

        private static void redirigirUser(string respuesta)
        {
            switch (respuesta)
            {
                case "1":
                    ingresoDeDatosPorDepartamento();
                    break;
                case "2":
                    reportes();
                    break;
                default:
                    Menu();
                    break;
            }
        }

        private static void redirigirAdmin(string respuesta)
        {
            switch (respuesta)
            {
                case "1":
                    ingresoDeDatosPorDepartamento();
                    break;
                case "2":
                    reportes();
                    break;
                case "3":
                    break;
                default:
                    Menu();
                    break;
            }
        }

        private static bool login()
        {
            Console.WriteLine("LOGIN");
            string user, pass;
            if (Usuario.usuarioBloqueado)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("USUARIO BLOQUEADO!");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("Usuario: ");
                user = Console.ReadLine();
                Console.WriteLine("Pass: ");
                pass = Console.ReadLine();
                return Usuario.usuarioCorrecto(user, pass);
            }
            else
            {
                Console.WriteLine("Usuario: ");
                user = Console.ReadLine();
                Console.WriteLine("Pass: ");
                pass = Console.ReadLine();
                return Usuario.usuarioCorrecto(user, pass);
            }
        }
    }
}
