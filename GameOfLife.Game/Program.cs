using GameOfLife.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameOfLife.Game
{
    class Program
    {
        static void Main(string[] args)
        {
            World mundo = new World();
           

            for (int i = 0; 1 != 2 ; i++)
            {
                
                var mapa = mundo.getMapVetor();
                double count = 0;
                foreach (var v in mapa)
                {
                    if (v)
                        Console.Write("X");
                    else
                        Console.Write(" ");

                    if (count / 3.0 == 0)
                        Console.Write('\n');
                    
                }
                System.Threading.Thread.Sleep(3000);
                System.Console.Clear();
                mundo.Turn();
            }           


        }
    }
}
