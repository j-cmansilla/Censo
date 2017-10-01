using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public static class Usuario
    {
        private const string USER_ADMIN = "admin";
        private const string USER = "user";
        private const string DEFAULT_PASS = "pass";
        public static bool usuarioBloqueado = false;
        public static bool isAdmin = false;
        
        public static bool usuarioCorrecto(string user, string pass)
        {
            int intentos = 3;
            if (user != USER_ADMIN && pass != DEFAULT_PASS)
            {
                if (!usuarioBloqueado)
                {
                    while (intentos > 0)
                    {
                        if (user != USER && pass != DEFAULT_PASS)
                        {
                            Console.Clear();
                            Console.WriteLine("USUARIO INCORRECTO!");
                            intentos--;
                            Console.WriteLine("Usuario: ");
                            user = Console.ReadLine();
                            Console.WriteLine("Pass: ");
                            pass = Console.ReadLine();
                            Console.WriteLine("Intentos restantes: " + intentos);
                        }
                        else
                        {
                            return true;
                        }
                    }
                    usuarioBloqueado = true;
                }
            }
            else
            {
                isAdmin = true;
                return true;
            }
            return false;
        }
    }
}
