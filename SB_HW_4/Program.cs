using System;
using System.Collections.Generic;
using System.Drawing;

namespace SB_HW_4 {
    class Program {
        static void Main(string[] args) {
            Matrix.WorkWithMatrix();
            Console.ReadKey();
            Sequence.WorkWithSequence();
            Console.ReadKey();
            Game.PlayGame();
        }


        public static int IntegerInput() {
            bool correctInput = false;
            int num;
            do {
                string input = Console.ReadLine();
                correctInput = Int32.TryParse(input, out num);
                if (!correctInput) {
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine("Не удалось распознать число, повторите ввод.");
                    Console.ForegroundColor = ConsoleColor.White;
                }
            } while (!correctInput);

            return num;
        }

       

    }
}
