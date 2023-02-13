using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AplicacionEstudiantesDP
{
    internal class ClaseEstudiantes
    {

        static string[] nombre = new string[3];
        static float[] notas = new float[3];
        static byte indice = 0;
        static int[] edad = new int[3];


        private static void CrearEstudiantes()
        {
            string continuar = "s";
            Console.Clear();
                indice = 0;
                do
                {
                    Console.WriteLine("(Estudiante " + (indice + 1) + "). Informacion a modificar:");
                Console.WriteLine("Digite el nombre del estudiante");
                    nombre[indice] = Console.ReadLine();
                    Console.WriteLine("Digite la edad del estudiante", (indice + 1));
                    edad[indice] = int.Parse(Console.ReadLine());
                    indice++;
                if (indice < nombre.Length)
                {
                    Console.WriteLine("Desea continuar(s/n): ");
                    continuar = Console.ReadLine();
                }
                else { continuar = "n"; };
                } while (!continuar.Equals("n"));
          
        }

        private static void BuscarEstudiante()
        {//este metodo ahora tiene funciones adicionales añadidas por mi
            var aka = false;
            Console.Clear();
            Console.WriteLine("Digite el nombre:");
            string nombre = Console.ReadLine();

            for (int i = 0; i < ClaseEstudiantes.nombre.Length; i++)
            {
                if (nombre.Equals(ClaseEstudiantes.nombre[i]))
                {
                    aka = true;
                    Console.WriteLine("Estudiante Existe, tiene " + edad[i] + " y es el numero: " + (i + 1) + " en la lista.");
                    Console.WriteLine(" ");
                }
            }
            if (aka == false)
            {
                Console.WriteLine("El estudiante que busca no se encuentra en la lista.");
                Console.WriteLine(" ");
            }
        }

        
        private static void MostrarEstudiante()
        {//este metodo fue creado por mi en adicion al programa base

            Console.Clear();
            Console.WriteLine("Lista de estudiantes y sus notas:");
            for (int s = 0; s < ClaseEstudiantes.nombre.Length; s++)
            {
                Console.WriteLine("Estudiante "+ (s+1) + ": " + nombre[s] + ". Edad: " + edad[s] + ". Nota: " + notas[s]);
            }
            Console.WriteLine(" ");
            char erese = 'r';
            Console.WriteLine("Desea regresar al menu o terminar? (r/t)");
            erese = char.Parse(Console.ReadLine());
            if(erese == 't') { Environment.Exit(0); }
            
        }

        private static void AsignarNota()
        {//este metodo fue creado por mi en adicion al programa base

            Console.Clear();
            byte opcionnota = 0;
            Console.WriteLine("A cual estudiante desea asignarle una nota? (1/2/3...)");
            opcionnota = byte.Parse(Console.ReadLine());
            Console.Clear();
            Console.WriteLine("Estudiante: " + ClaseEstudiantes.nombre[(opcionnota-1)]);
            Console.WriteLine("Escriba la nueva nota en la siguiente linea:");
            ClaseEstudiantes.notas[(opcionnota-1)] = float.Parse(Console.ReadLine());


        }

        public static void menu()
        {//este metodo ha sido modificado parsialmente por mi
            byte opcion = 0;
            do
            {
                Console.WriteLine("1 - Manipular Informacion de Estudiantes");
                Console.WriteLine("2 - Comprobar Estudiante Por Nombre");
                Console.WriteLine("3 - Asignar O Cambiar Nota A Un Estudiante");
                Console.WriteLine("4 - Imprimir Estudiantes Con Sus Notas y Edades");
                Console.WriteLine("5 - Eliminar Informacion De Estudiante");
                Console.WriteLine("6 - salir");
                Console.Write("Digite una opcion: ");
                opcion = byte.Parse(Console.ReadLine());

                switch (opcion)
                {
                    case 1:
                        CrearEstudiantes();
                        Console.Clear();
                        break;
                    case 2:
                        BuscarEstudiante();
                        break;
                    case 3:
                        AsignarNota();
                        Console.Clear();
                        break;
                    case 4:
                        MostrarEstudiante();
                        Console.Clear();
                        break;
                   case 5:
                        indice = 0;
                        Console.WriteLine("Escriba el numero de lista del estudiante a eliminar");
                        indice = byte.Parse(Console.ReadLine());
                        indice -= 1;
                        nombre[indice] = "";
                        edad[indice] = 0;
                        notas[indice] = 0;
                        Console.Clear() ;
                        break;
                    default:
                        Console.Clear();
                        Console.WriteLine("Opcion no existente");
                        break;
                }

            } while (opcion != 6); 

        }
    }
}
