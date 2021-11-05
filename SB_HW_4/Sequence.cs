using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SB_HW_4 {
    static class Sequence {
        public static void WorkWithSequence() {
            Console.Clear();
            Console.WriteLine("Введите длину последовательности");
            
            int length = Program.IntegerInput();
            int[] sequence = new int[length];

            Console.WriteLine("Введите числа через Enter");
            
            for (int i = 0; i < length; i++) {
                sequence[i] = Program.IntegerInput();
            }
            int min = int.MaxValue;
            
            // Сравниваем каждый элемент последовательности с загаданным числом.
            foreach (var i in sequence) {
                if (i < min) {
                    min = i;
                }
            }
            Console.WriteLine("Наименьшее число: " + min);
        }
    }
}
