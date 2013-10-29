using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThenByDescending
{
    class Program
    {
        static void Main(string[] args)
        {
            Jugadores jugador1 = new Jugadores();
            Jugadores jugador2 = new Jugadores();
            Jugadores jugador3 = new Jugadores();
            Jugadores jugador4 = new Jugadores();

            jugador1.Nombre = "Oscar";
            jugador1.Posicion = 1;
            jugador1.Estatura = 1.68;

            jugador2.Nombre = "Ivan";
            jugador2.Posicion = 4;
            jugador2.Estatura = 1.80;

            jugador3.Nombre = "Manny";
            jugador3.Posicion = 3;
            jugador3.Estatura = 1.75;

            jugador4.Nombre = "Jorge";
            jugador4.Posicion = 2;
            jugador4.Estatura = 1.50;
            List<Jugadores> jugador = new List<Jugadores>();
            jugador.Add(jugador1);
            jugador.Add(jugador2);
            jugador.Add(jugador3);
            jugador.Add(jugador4);

            var ordenarJugadores =
                from j in jugador
                orderby j.Posicion, j.Nombre, j.Estatura descending
                select j;

            foreach (var item in ordenarJugadores)
            {
                Console.WriteLine(item.Nombre);
                Console.WriteLine(item.Posicion);
                Console.WriteLine(item.Estatura);
            }
            
            Console.ReadLine();
        }

    }
}
