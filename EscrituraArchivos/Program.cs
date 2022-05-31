using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace EscrituraArchivos
{
    class Program
    {
        static void Main(string[] args)
        {
            string name;
            StreamWriter sw = new StreamWriter("ejemplo.txt",true);
            //si el archivo no existe lo creará
            //si ya existe, escribirá en él
            //true es para agregar y no sobreescribir

            Console.Write("Ingrese un nombre: ");
            name = Console.ReadLine();

            sw.WriteLine(name);//escribe en el archivo

            sw.Close();//se debe cerrar el archivo

            Console.WriteLine("Escribiendo en el archivo...");
            Console.ReadLine();
        }
    }
}