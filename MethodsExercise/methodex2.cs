using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodsExercise
{
    internal class methodex2
    {
        public static int Add(params int[] numbers)
        {
            int add = 0;
            foreach (int num in numbers) { add += num; }
            return add;
        }
        public static int Subtract(int intitial, params int[] numbers)
        {
            int sub = intitial;
            foreach (int num in numbers) { sub -= num; }
            return sub;
        }
        public static int Multiply(int intitial, params int[] numbers)
        {
            int multip = intitial;
            foreach (int num in numbers) { multip *= num; }
            return multip;
        }
        public static int Divide(int intitial, params int[] numbers)
        {
            int div = intitial;
            foreach (int num in numbers) { div /= num; }
            return div;
        }
    }
}
