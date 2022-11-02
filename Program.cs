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
            string variable = Console.ReadLine();

            int result = 0;

            bool isVariableCorrect = true;

            int j = 0;

            if ((variable[0] == '-'))

                j = 1;

            else

                j = 0;
        }
        public static void Main()
        {
            Task1Solving();
        }
    }
}