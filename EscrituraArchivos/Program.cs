using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace EscrituraArchivos
{
    class Cliente //Creacion de la clase Cliente
    {
        //Atributos
        string nombreCliente;
        int numeroCliente;
        string direccion;
        long telefono;

        //Constructor
        public Cliente(string nombreCliente, int numeroCliente, string direccion, long telefono)
        {
            //recibe los parámetros con mismos nombres y los asigna a los campos de la clase con this.
            this.nombreCliente = nombreCliente;
            this.numeroCliente = numeroCliente;
            this.direccion = direccion;
            this.telefono = telefono;
        }
        //Metodo funcion que calcula la venta
    }
    class Program
    {
        static void Main(string[] args)
        {
            //Declaracion de variables
            string nombreCliente, direccion;
            int numeroCliente;
            long telefono;

            StreamWriter sw = new StreamWriter("ejemplo.txt",true);
            //si el archivo no existe lo creará
            //si ya existe, escribirá en él
            //true es para agregar y no sobreescribir

            //Captura de datos
            Console.Write("Ingrese su nombre:");
            nombreCliente = Console.ReadLine();
            Console.Write("Ingrese numero de cliente:");
            numeroCliente = int.Parse(Console.ReadLine());
            Console.Write("Ingrese su direccion:");
            direccion = Console.ReadLine();
            Console.Write("Ingrese su telefono:");
            telefono = long.Parse(Console.ReadLine());

            //Se crea el objeto de la clase cliente enviándole los datos como parámetros al constructor.
            Cliente comprador = new Cliente(nombreCliente, numeroCliente, direccion, telefono);

            //Escribe en el archivo
            sw.WriteLine("Nombre del cliente:          {0}", nombreCliente);
            sw.WriteLine("Numero del cliente:          {0}", numeroCliente);
            sw.WriteLine("Direccion:                   {0}", direccion);
            sw.WriteLine("Telefono:                    {0}", telefono);



            sw.Close();//se debe cerrar el archivo

            Console.WriteLine("Escribiendo en el archivo...");
            Console.ReadLine();
        }
    }
}