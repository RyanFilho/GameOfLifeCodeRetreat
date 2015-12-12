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
           

            while(true)
            {                
                var mapa = mundo.getMapVetor();
                int count = 0;
                for (int j = 0; j < 10; j++)
                {
                    for (int k = 0; k < 10; k++)
                    {
                        if (mapa[count])
                            Console.Write("X");
                        else
                            Console.Write(" ");
                        count++;
                    }
                    Console.Write('\n');
                }
                System.Threading.Thread.Sleep(500);
                System.Console.Clear();
                mundo.Turn();
            }           


        }
    }
}
