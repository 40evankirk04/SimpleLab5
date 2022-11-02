namespace Labs
{
    public class Lab5
    {
        static void Task1Solving()
        {
            float floatNumberBefore = float.NaN;

            while (true)
            {
                string variable = Console.ReadLine();

                if (variable == "q") return;

                if (int.TryParse(variable, out int intNumber))
                {
                    Console.WriteLine((char)intNumber);
                    return;
                }

                if (float.TryParse(variable, out float floatNumber))
                {
                    if (floatNumberBefore == floatNumber)
                        return;
                    floatNumberBefore = floatNumber;
                }
            }
        }

        static void Task2Solving()
        {
            string a = Console.ReadLine();

            int result = 0;

            bool isVariableCorrect = true;

            int j = 0;

            if ((a[0] == '-'))

                j = 1;

            else

                j = 0;

            for (int i = j; i < a.Length; i++)
            {
                int indicatorCharIndex = a[i] - '0';

                if ((indicatorCharIndex >= 0) && (indicatorCharIndex < 10))
                {
                    result += indicatorCharIndex;
                }

                else
                {
                    isVariableCorrect = false;

                    break;
                }
            }

            Console.WriteLine(isVariableCorrect ? result : "Число не корректно");
        }

        static void Task4Solving()
        {
            double[] inputArray = { 8, -5, -12.067, 45.11934 };

            double[] returnArray = new double[inputArray.Length];

            for (int i = 0; i < inputArray.Length; i++)
            {
                double number = inputArray[i];

                if ((inputArray[i] > 0) && (inputArray[i]) == (int)inputArray[i]) number = Factorial(inputArray[i]);

                else if ((inputArray[i]) != (int)inputArray[i]) number = HighlightingHundredths(inputArray[i]);

                returnArray[i] = number;
            }

            ReturnOfArrays(inputArray, returnArray);

            static void ReturnOfArrays(double[] inputArray, double[] returnArray)
            {
                for (int i = 0; i < inputArray.Length; i++)
                {
                    Console.Write($"{inputArray[i]} ");
                }
                Console.WriteLine();
                for (int i = 0; i < returnArray.Length; i++)
                {
                    Console.Write($"{returnArray[i]} ");
                }
            }

            static double HighlightingHundredths(double variable1)
            {
                variable1 = Math.Round(variable1, 2);
                variable1 = (variable1 * 100) % 100;
                variable1 = Math.Abs(variable1);
                return variable1;
            }
        }
        public static void Main()
        {
            Task1Solving();

            Task2Solving();
        }
    }
}