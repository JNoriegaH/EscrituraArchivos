using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace EscrituraArchivos
{
    class Cinema
    {
        public string pelicula;
        public int tickets, ninos, adultos;
        public float costoNino = 24;
        public float costoAdulto = 36;

        public Cinema(string pelicula, int tickets, int ninos, int adultos)
        {
            this.pelicula = pelicula;
            this.tickets = tickets;
            this.ninos = ninos;
            this.adultos = adultos;
        }

        public float Total()
        {
            return (costoAdulto * adultos) + (costoNino * ninos);
        }

        public void Imprimir(float total)
        {
            Console.WriteLine("\n\tRECIBO");
            Console.WriteLine("Pelicula:    {0}", pelicula);
            Console.WriteLine("Tickets:     {0}", tickets);
            Console.WriteLine("Adultos:     {0}" + " \t{1:C} ", adultos, (costoAdulto * adultos));
            Console.WriteLine("Niños:       {0}" + " \t{1:C}", ninos, (costoNino * ninos));
            Console.WriteLine("Total:         {0:C}", total);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            string pelicula;
            int tickets, ninos, adultos;
            float total;

            StreamWriter sw = new StreamWriter("ejemplo.txt");

            Console.Write("Que pelicula desea ver: ");
            pelicula = Console.ReadLine();
            Console.Write("Cuantos tickets desea: ");
            tickets = int.Parse(Console.ReadLine());
            Console.Write("Cuantos adultos son: ");
            adultos = int.Parse(Console.ReadLine());
            Console.Write("Cuantos niños son: ");
            ninos = int.Parse(Console.ReadLine());

            Cinema cn = new Cinema(pelicula, tickets, ninos, adultos);
            total = cn.Total();
            cn.Imprimir(total);

            //Escribiendo en el archivo
            sw.WriteLine("\tRECIBO");
            sw.WriteLine("Pelicula:    {0}", pelicula);
            sw.WriteLine("Tickets:     {0}", tickets);
            sw.WriteLine("Adultos:     {0}", adultos);
            sw.WriteLine("Niños:       {0}", ninos);
            sw.WriteLine("Total:       {0:C}", total);

            sw.Close();
            Console.WriteLine("\nEscribiendo en el archivo...");
            Console.ReadLine();
        }
    }
}