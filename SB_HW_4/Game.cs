using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SB_HW_4 {
    static class Game {
        
        public static void PlayGame() {
            Console.Clear();
            Console.WriteLine("Введите максимальное число:");
            int max = Program.IntegerInput();
            int num = new Random(DateTime.Now.Millisecond).Next(0, max);

            // Цикл игры:
            // Если введена пустая строка, выводит загаднное число и выходит из цикла
            // Иначе проверяет ввод и сравнивет его с загаданным числом.
            while (true) {
                Console.WriteLine("Попробуйте угадать число:");
                string input = Console.ReadLine();
                
                // 
                if (input == "") {
                    Console.WriteLine("Загаданное число: " + num);
                    break;
                }
                int userNum;
                
                if (!int.TryParse(input, out userNum)) {
                    Console.WriteLine("Число не распознано");
                    continue;
                } else if (userNum == num) {
                    Console.WriteLine("Поздравляю, вы угадали число");
                    break;
                } else if (userNum > num) {
                    Console.WriteLine("Введенное число больше загаданного");
                } else {
                    Console.WriteLine("Введенное число меньше загаданного");
                }
            }
        }
    }
}
