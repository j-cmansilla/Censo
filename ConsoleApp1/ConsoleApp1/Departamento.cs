using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Departamento
    {
        public static List<Departamento> listaDepartamentos = new List<Departamento>();

        public static void listadoDeDepartamentos()
        {
            for (int i = 0; i < listaDepartamentos.Count; i++)
            {
                Console.WriteLine(listaDepartamentos.ElementAt(i).NumeroDepartamento + ") " + listaDepartamentos.ElementAt(i).Nombre);
            }
        }

       

        public static void reportesPorPais()
        {
            Console.WriteLine("# REPORTE POR PAIS");
            Console.WriteLine("# Total de habitantes: "+totalDeHabitantesPorPais());
            Console.WriteLine("# Total de habitantes femeninos: " + totalHabitantesPaisFemenino(-1));
            Console.WriteLine("# Total de habitantes masculinos: " + totalHabitantesPaisMasculino(-1));
            Console.WriteLine("# Total de habitantes entre 0 y 10 (sin importar sexo): " + TotalHabitantesEntre0y10(-1));
            Console.WriteLine("# Total de habitantes entre 11 y 20 (sin importar sexo): " + TotalHabitantesEntre11y20(-1));
            Console.WriteLine("# Total de habitantes entre 21 y 30 (sin importar sexo): " + TotalHabitantesEntre21y30(-1));
            Console.WriteLine("# Total de habitantes entre 31 y 40 (sin importar sexo): " + TotalHabitantesEntre31y40(-1));
            Console.WriteLine("# Total de habitantes entre 41 y 50 (sin importar sexo): " + TotalHabitantesEntre41y50(-1));
            Console.WriteLine("# Total de habitantes entre 51 y 60 (sin importar sexo): " + TotalHabitantesEntre51y60(-1));
            Console.WriteLine("# Total de habitantes entre 61 y 70 (sin importar sexo): " + TotalHabitantesEntre61y70(-1));
            Console.WriteLine("# Total de habitantes entre 71 o mas (sin importar sexo): " + TotalHabitantesEntre71oMas(-1));
        }


        public static void reportesPorDepartamento(int departamento)
        {
            Console.WriteLine("# REPORTE POR DEPARTAMENTO");
            Console.WriteLine("# Departamento: "+listaDepartamentos.ElementAt(departamento-1).Nombre);
            Console.WriteLine("# Total de habitantes: " + totalDeHabitantesPorDepartamento(departamento-1));
            Console.WriteLine("# Total de habitantes femeninos: " + totalHabitantesPaisFemenino(departamento-1));
            Console.WriteLine("# Total de habitantes masculinos: " + totalHabitantesPaisMasculino(departamento-1));
            Console.WriteLine("# Total de habitantes entre 0 y 10 (sin importar sexo): " + TotalHabitantesEntre0y10(departamento-1));
            Console.WriteLine("# Total de habitantes entre 11 y 20 (sin importar sexo): " + TotalHabitantesEntre11y20(departamento - 1));
            Console.WriteLine("# Total de habitantes entre 21 y 30 (sin importar sexo): " + TotalHabitantesEntre21y30(departamento - 1));
            Console.WriteLine("# Total de habitantes entre 31 y 40 (sin importar sexo): " + TotalHabitantesEntre31y40(departamento - 1));
            Console.WriteLine("# Total de habitantes entre 41 y 50 (sin importar sexo): " + TotalHabitantesEntre41y50(departamento - 1));
            Console.WriteLine("# Total de habitantes entre 51 y 60 (sin importar sexo): " + TotalHabitantesEntre51y60(departamento - 1));
            Console.WriteLine("# Total de habitantes entre 61 y 70 (sin importar sexo): " + TotalHabitantesEntre61y70(departamento - 1));
            Console.WriteLine("# Total de habitantes entre 71 o mas (sin importar sexo): " + TotalHabitantesEntre71oMas(departamento - 1));
        }

        

        private static int TotalHabitantesEntre71oMas(int departamento)
        {
            int total = 0;
            for (int i = 0; i < listaDepartamentos.Count; i++)
            {
                if (departamento == -1)
                {
                    total = total + listaDepartamentos.ElementAt(i).HabitantesMasculinosEntreSetentayunoOmas + listaDepartamentos.ElementAt(i).HabitantesFemeninosEntreSetentayunoOmas;
                }
                else
                {
                    if (departamento == i)
                    {
                        total = total + listaDepartamentos.ElementAt(i).HabitantesMasculinosEntreSetentayunoOmas + listaDepartamentos.ElementAt(i).HabitantesFemeninosEntreSetentayunoOmas;
                    }
                }
            }
            return total;
        }

        private static int TotalHabitantesEntre61y70(int departamento)
        {
            int total = 0;
            for (int i = 0; i < listaDepartamentos.Count; i++)
            {
                if (departamento == -1)
                {
                    total = total + listaDepartamentos.ElementAt(i).HabitantesFemeninosEntreSesentayunoYSetenta + listaDepartamentos.ElementAt(i).HabitantesMasculinosEntreSesentayunoYSetenta;
                }
                else
                {
                    if (i == departamento)
                    {
                        total = total + listaDepartamentos.ElementAt(i).HabitantesFemeninosEntreSesentayunoYSetenta + listaDepartamentos.ElementAt(i).HabitantesMasculinosEntreSesentayunoYSetenta;
                    }
                }
            }
            return total;
        }

        private static int TotalHabitantesEntre51y60(int departamento)
        {
            int total = 0;
            for (int i = 0; i < listaDepartamentos.Count; i++)
            {
                if (departamento == -1)
                {
                    total = total + listaDepartamentos.ElementAt(i).HabitantesMasculinosEntreCincuentayunoYSesenta + listaDepartamentos.ElementAt(i).HabitantesFemeninosEntreCincuentayunoYSesenta;
                }
                else
                {
                    if (departamento == i)
                    {
                        total = total + listaDepartamentos.ElementAt(i).HabitantesMasculinosEntreCincuentayunoYSesenta + listaDepartamentos.ElementAt(i).HabitantesFemeninosEntreCincuentayunoYSesenta;
                    }
                }
            }
            return total;
        }

        private static int TotalHabitantesEntre41y50(int departamento)
        {
            int total = 0;
            for (int i = 0; i < listaDepartamentos.Count; i++)
            {
                if (departamento == -1)
                {
                    total = total + listaDepartamentos.ElementAt(i).HabitantesFemeninosEntreCuarentayunoYCincuenta + listaDepartamentos.ElementAt(i).HabitantesMasculinosEntreCuarentayunoYCincuenta;
                }
                else
                {
                    if (i == departamento)
                    {
                        total = total + listaDepartamentos.ElementAt(i).HabitantesFemeninosEntreCuarentayunoYCincuenta + listaDepartamentos.ElementAt(i).HabitantesMasculinosEntreCuarentayunoYCincuenta;
                    }
                }
            }
            return total;
        }


        private static int TotalHabitantesEntre31y40(int departamento)
        {
            int total = 0;
            for (int i = 0; i < listaDepartamentos.Count; i++)
            {
                if (departamento == -1)
                {
                    total = total + listaDepartamentos.ElementAt(i).HabitantesMasculinosEntreTreitayunoYCuarenta + listaDepartamentos.ElementAt(i).HabitantesFemeninosEntreTreitayunoYCuarenta;
                }
                else
                {
                    if (i == departamento)
                    {
                        total = total + listaDepartamentos.ElementAt(i).HabitantesMasculinosEntreTreitayunoYCuarenta + listaDepartamentos.ElementAt(i).HabitantesFemeninosEntreTreitayunoYCuarenta;
                    }
                }
            }
            return total;
        }

        private static int TotalHabitantesEntre21y30(int departamento)
        {
            int total = 0;
            for (int i = 0; i < listaDepartamentos.Count; i++)
            {
                if (departamento == -1)
                {
                    total = total + listaDepartamentos.ElementAt(i).HabitantesFemeninosEntreVeintiunoYTreinta + listaDepartamentos.ElementAt(i).HabitantesMasculinosEntreVeintiunoYTreinta;
                }
                else
                {
                    if ( i == departamento)
                    {
                        total = total + listaDepartamentos.ElementAt(i).HabitantesFemeninosEntreVeintiunoYTreinta + listaDepartamentos.ElementAt(i).HabitantesMasculinosEntreVeintiunoYTreinta;
                    }
                }
            }
            return total;
        }

        private static int TotalHabitantesEntre11y20(int departamento)
        {
            int total = 0;
            for (int i = 0; i < listaDepartamentos.Count; i++)
            {
                if (departamento == -1)
                {
                    total = total + listaDepartamentos.ElementAt(i).HabitantesMasculinosEntreOnceYVeinte + listaDepartamentos.ElementAt(i).HabitantesFemeninosEntreOnceYVeinte;
                }
                else
                {
                    if (departamento == i)
                    {
                        total = total + listaDepartamentos.ElementAt(i).HabitantesMasculinosEntreOnceYVeinte + listaDepartamentos.ElementAt(i).HabitantesFemeninosEntreOnceYVeinte;
                    }
                }
            }
            return total;
        }

        private static int TotalHabitantesEntre0y10(int departamento)
        {
            int total = 0;
            for (int i = 0; i < listaDepartamentos.Count; i++)
            {
                if (departamento == -1)
                {
                    total = total + listaDepartamentos.ElementAt(i).HabitantesFemeninosEntreCeroYDiez + listaDepartamentos.ElementAt(i).HabitantesMasculinosEntreCeroYDiez;
                }
                else
                {
                    if (i == departamento)
                    {
                        total = total + listaDepartamentos.ElementAt(i).HabitantesFemeninosEntreCeroYDiez + listaDepartamentos.ElementAt(i).HabitantesMasculinosEntreCeroYDiez;
                    }
                }
            }
            return total;
        }

        private static int totalDeHabitantesPorDepartamento(int departamento)
        {
            return totalHabitantesPaisFemenino(departamento) + totalHabitantesPaisMasculino(departamento);
        }

        private static int totalDeHabitantesPorPais()
        {
            return totalHabitantesPaisFemenino(-1) + totalHabitantesPaisMasculino(-1);
        }

        private static int totalHabitantesPaisFemenino(int departamento)
        {
            int total = 0;
            for (int i = 0; i < listaDepartamentos.Count; i++)
            {
                if (departamento == -1)
                {
                    total = total + listaDepartamentos.ElementAt(i).HabitantesFemeninosEntreCeroYDiez + listaDepartamentos.ElementAt(i).HabitantesFemeninosEntreCincuentayunoYSesenta + listaDepartamentos.ElementAt(i).HabitantesFemeninosEntreCuarentayunoYCincuenta + listaDepartamentos.ElementAt(i).HabitantesFemeninosEntreOnceYVeinte + listaDepartamentos.ElementAt(i).HabitantesFemeninosEntreSesentayunoYSetenta + listaDepartamentos.ElementAt(i).HabitantesFemeninosEntreSetentayunoOmas + listaDepartamentos.ElementAt(i).HabitantesFemeninosEntreTreitayunoYCuarenta + listaDepartamentos.ElementAt(i).HabitantesFemeninosEntreVeintiunoYTreinta;
                }
                else
                {
                    if (departamento == i)
                    {
                        total = total + listaDepartamentos.ElementAt(i).HabitantesFemeninosEntreCeroYDiez + listaDepartamentos.ElementAt(i).HabitantesFemeninosEntreCincuentayunoYSesenta + listaDepartamentos.ElementAt(i).HabitantesFemeninosEntreCuarentayunoYCincuenta + listaDepartamentos.ElementAt(i).HabitantesFemeninosEntreOnceYVeinte + listaDepartamentos.ElementAt(i).HabitantesFemeninosEntreSesentayunoYSetenta + listaDepartamentos.ElementAt(i).HabitantesFemeninosEntreSetentayunoOmas + listaDepartamentos.ElementAt(i).HabitantesFemeninosEntreTreitayunoYCuarenta + listaDepartamentos.ElementAt(i).HabitantesFemeninosEntreVeintiunoYTreinta;
                    }
                }
                
            }
            return total;
        }

        private static int totalHabitantesPaisMasculino(int departamento)
        {
            int total = 0;
            for (int i = 0; i < listaDepartamentos.Count; i++)
            {
                if (departamento == -1)
                {
                    total = total + listaDepartamentos.ElementAt(i).HabitantesMasculinosEntreCeroYDiez + listaDepartamentos.ElementAt(i).HabitantesMasculinosEntreCincuentayunoYSesenta + listaDepartamentos.ElementAt(i).HabitantesMasculinosEntreCuarentayunoYCincuenta + listaDepartamentos.ElementAt(i).HabitantesMasculinosEntreOnceYVeinte + listaDepartamentos.ElementAt(i).HabitantesMasculinosEntreSesentayunoYSetenta + listaDepartamentos.ElementAt(i).HabitantesMasculinosEntreSetentayunoOmas + listaDepartamentos.ElementAt(i).HabitantesMasculinosEntreTreitayunoYCuarenta + listaDepartamentos.ElementAt(i).HabitantesMasculinosEntreVeintiunoYTreinta;
                }
                else
                {
                    if (departamento == i)
                    {
                        total = total + listaDepartamentos.ElementAt(i).HabitantesMasculinosEntreCeroYDiez + listaDepartamentos.ElementAt(i).HabitantesMasculinosEntreCincuentayunoYSesenta + listaDepartamentos.ElementAt(i).HabitantesMasculinosEntreCuarentayunoYCincuenta + listaDepartamentos.ElementAt(i).HabitantesMasculinosEntreOnceYVeinte + listaDepartamentos.ElementAt(i).HabitantesMasculinosEntreSesentayunoYSetenta + listaDepartamentos.ElementAt(i).HabitantesMasculinosEntreSetentayunoOmas + listaDepartamentos.ElementAt(i).HabitantesMasculinosEntreTreitayunoYCuarenta + listaDepartamentos.ElementAt(i).HabitantesMasculinosEntreVeintiunoYTreinta;
                    }
                }
            }
            return total;
        }

        public static void llenarListaVacia()
        {
            listaDepartamentos.Add(new Departamento(1,"Alta Verapaz",0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0));
            listaDepartamentos.Add(new Departamento(2, "Baja Verapaz", 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0));
            listaDepartamentos.Add(new Departamento(3, "Chimaltenango", 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0));
            listaDepartamentos.Add(new Departamento(4, "Chiquimula", 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0));
            listaDepartamentos.Add(new Departamento(5, "Peten", 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0));
            listaDepartamentos.Add(new Departamento(6, "El Progreso", 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0));
            listaDepartamentos.Add(new Departamento(7, "Quiche", 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0));
            listaDepartamentos.Add(new Departamento(8, "Escuintla", 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0));
            listaDepartamentos.Add(new Departamento(9, "Guatemala", 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0));
            listaDepartamentos.Add(new Departamento(10, "Huehuetenango", 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0));
            listaDepartamentos.Add(new Departamento(11, "Izabal", 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0));
            listaDepartamentos.Add(new Departamento(12, "Jalapa", 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0));
            listaDepartamentos.Add(new Departamento(13, "Jutiapa", 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0));
            listaDepartamentos.Add(new Departamento(14, "Quetzaltenango", 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0));
            listaDepartamentos.Add(new Departamento(15, "Retalhuleu", 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0));
            listaDepartamentos.Add(new Departamento(16, "Sacatepequez", 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0));
            listaDepartamentos.Add(new Departamento(17, "San Marcos", 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0));
            listaDepartamentos.Add(new Departamento(18, "Santa Rosa", 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0));
            listaDepartamentos.Add(new Departamento(19, "Solola", 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0));
            listaDepartamentos.Add(new Departamento(20, "Suchitepequez", 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0));
            listaDepartamentos.Add(new Departamento(21, "Totonicapan", 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0));
            listaDepartamentos.Add(new Departamento(22, "Zacapa", 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0));
        }
        
        public Departamento(int numeroDepartamento, string nombre, int habitantesFemeninosEntreCeroYDiez, int habitantesFemeninosEntreOnceYVeinte, int habitantesFemeninosEntreVeintiunoYTreinta, int habitantesFemeninosEntreTreitayunoYCuarenta, int habitantesFemeninosEntreCuarentayunoYCincuenta, int habitantesFemeninosEntreCincuentayunoYSesenta, int habitantesFemeninosEntreSesentayunoYSetenta, int habitantesFemeninosEntreSetentayunoOmas, int habitantesMasculinosEntreCeroYDiez, int habitantesMasculinosEntreOnceYVeinte, int habitantesMasculinosEntreVeintiunoYTreinta, int habitantesMasculinosEntreTreitayunoYCuarenta, int habitantesMasculinosEntreCuarentayunoYCincuenta, int habitantesMasculinosEntreCincuentayunoYSesenta, int habitantesMasculinosEntreSesentayunoYSetenta, int habitantesMasculinosEntreSetentayunoOmas)
        {
            NumeroDepartamento = numeroDepartamento;
            Nombre = nombre;
            HabitantesFemeninosEntreCeroYDiez = habitantesFemeninosEntreCeroYDiez;
            HabitantesFemeninosEntreOnceYVeinte = habitantesFemeninosEntreOnceYVeinte;
            HabitantesFemeninosEntreVeintiunoYTreinta = habitantesFemeninosEntreVeintiunoYTreinta;
            HabitantesFemeninosEntreTreitayunoYCuarenta = habitantesFemeninosEntreTreitayunoYCuarenta;
            HabitantesFemeninosEntreCuarentayunoYCincuenta = habitantesFemeninosEntreCuarentayunoYCincuenta;
            HabitantesFemeninosEntreCincuentayunoYSesenta = habitantesFemeninosEntreCincuentayunoYSesenta;
            HabitantesFemeninosEntreSesentayunoYSetenta = habitantesFemeninosEntreSesentayunoYSetenta;
            HabitantesFemeninosEntreSetentayunoOmas = habitantesFemeninosEntreSetentayunoOmas;
            HabitantesMasculinosEntreCeroYDiez = habitantesMasculinosEntreCeroYDiez;
            HabitantesMasculinosEntreOnceYVeinte = habitantesMasculinosEntreOnceYVeinte;
            HabitantesMasculinosEntreVeintiunoYTreinta = habitantesMasculinosEntreVeintiunoYTreinta;
            HabitantesMasculinosEntreTreitayunoYCuarenta = habitantesMasculinosEntreTreitayunoYCuarenta;
            HabitantesMasculinosEntreCuarentayunoYCincuenta = habitantesMasculinosEntreCuarentayunoYCincuenta;
            HabitantesMasculinosEntreCincuentayunoYSesenta = habitantesMasculinosEntreCincuentayunoYSesenta;
            HabitantesMasculinosEntreSesentayunoYSetenta = habitantesMasculinosEntreSesentayunoYSetenta;
            HabitantesMasculinosEntreSetentayunoOmas = habitantesMasculinosEntreSetentayunoOmas;
        }

        public int NumeroDepartamento { get; set; }
        public string Nombre { get; set; }
        public int HabitantesFemeninosEntreCeroYDiez { get; set; }
        public int HabitantesFemeninosEntreOnceYVeinte { get; set; }
        public int HabitantesFemeninosEntreVeintiunoYTreinta { get; set; }
        public int HabitantesFemeninosEntreTreitayunoYCuarenta { get; set; }
        public int HabitantesFemeninosEntreCuarentayunoYCincuenta { get; set; }
        public int HabitantesFemeninosEntreCincuentayunoYSesenta { get; set; }
        public int HabitantesFemeninosEntreSesentayunoYSetenta { get; set; }
        public int HabitantesFemeninosEntreSetentayunoOmas { get; set; }
        public int HabitantesMasculinosEntreCeroYDiez { get; set; }
        public int HabitantesMasculinosEntreOnceYVeinte { get; set; }
        public int HabitantesMasculinosEntreVeintiunoYTreinta { get; set; }
        public int HabitantesMasculinosEntreTreitayunoYCuarenta { get; set; }
        public int HabitantesMasculinosEntreCuarentayunoYCincuenta { get; set; }
        public int HabitantesMasculinosEntreCincuentayunoYSesenta { get; set; }
        public int HabitantesMasculinosEntreSesentayunoYSetenta { get; set; }
        public int HabitantesMasculinosEntreSetentayunoOmas { get; set; }

    }
}
