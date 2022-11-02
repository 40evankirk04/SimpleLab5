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

        public static void Main()
        {
            Task1Solving();
        }
    }
}