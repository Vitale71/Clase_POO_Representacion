using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace juego_1_op
{
    /*
  class Escalera
  {
      public int pie;
      public int cabecera;

      public Escalera (int pie, int cabecera)
      {
          this.pie = pie;
          this.cabecera = cabecera;
      }
  }
  class Serpiente
      {
          public int cabeza;
          public int cola;

          public Serpiente (int cabeza, int cola)
          {
              this.cabeza = cabeza;
              this.cola = cola;
              Escalera esc1 = new Escalera(6, 80);
              Escalera esc2 = new Escalera(3, 7);
          }
      }
    */

    internal class Program
    {
        static Random azar = new Random();
        static void Main(string[] args)
        {
            int posicion1, posicion2, esc1, esc2;
            string jugador1, jugador2;
            int pie1, pie2, cabecera1, cabecera2;
            int cola, cabecera;
            int dado;
            bool finJuego = false;

            #region inicializar posiciones
            posicion1 = 0;
            posicion2 = 0;
            #endregion

            #region solicitar nombres jugadores
            Console.WriteLine("ingrese el nombre del jugador 1 y luego el jugador 2");
            jugador1 = Console.ReadLine();
            jugador2 = Console.ReadLine();
            #endregion

            #region inicializar escaleras
            pie1 = azar.Next(1, 100);
            cabecera1 = azar.Next(pie1, 100);
            pie2 = azar.Next(1, 100);
            cabecera2 = azar.Next(pie2, 100);
            #endregion

            #region inicializar serpiente
            cola = azar.Next(1, 100);
            cabecera = azar.Next(cola, 100);
            #endregion

            #region iterar jugadas
            do
            {
                #region jugador 1
                dado = azar.Next(1, 7);
                posicion1 += dado;
                if (cabecera == posicion1)
                {
                    posicion1 = cola;
                }
                if (pie1 == posicion1)
                {
                    posicion1 = cabecera1;
                }
                if (pie2 == posicion1)
                {
                    posicion1 = cabecera2;

                }
                #endregion

                Console.WriteLine("jugador 1 - posicion " + posicion1);

                #region jugador 2
                dado = azar.Next(1, 7);
                posicion2 += dado;
                if (cabecera == posicion2)
                {
                    posicion2 = cola;
                }
                if (pie1 == posicion2)
                {
                    posicion2 = cabecera1;
                }
                if (pie2 == posicion2)
                {
                    posicion2 = cabecera2;

                }
                #endregion

                Console.WriteLine("jugador 2 - posicion " + posicion2);

                finJuego = posicion1 >= 100 || posicion2 >= 100;
            } while (!finJuego);
            #endregion

            if (posicion1 >= 100 ^ posicion2 >= 100)
            {
                if (posicion1 >= 100)
                {
                    Console.WriteLine("el ganador es " + jugador1);
                }
                else
                {
                    Console.WriteLine("el ganador es " + jugador2);
                }
            }
            else
            {
                Console.WriteLine("no hay ganador");
            }

            Console.ReadKey();
        }
    }

}
