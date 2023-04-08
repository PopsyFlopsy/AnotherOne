class AbilityScoreCalculator
{
    public int RollResult = 14;
    public double DivideBy = 1.75;
    public int AddAmount = 2;
    public int Minimum = 3;
    public int Score;
    public void CalculateAbilityScore()
    {
        int result = (int)(RollResult / DivideBy) + AddAmount;
        if (result < Minimum)
        {
            Score = Minimum;
        }
        else
        {
            Score = result;
        }
    }
    static void Main(string[] args)
    {
        AbilityScoreCalculator calculator = new AbilityScoreCalculator();
        while (true)
        {
            calculator.RollResult = ReadInt(calculator.RollResult, "Starting 4d6 roll");
            calculator.DivideBy = ReadDouble(calculator.DivideBy, "Divide by");
            calculator.AddAmount = ReadInt(calculator.AddAmount, "Add amount");
            calculator.Minimum = ReadInt(calculator.Minimum, "Minimum");
            calculator.CalculateAbilityScore();
            Console.WriteLine("Calculated ability score: " + calculator.Score);
            Console.WriteLine("Press Q to quit, any other key to continue");
            char keyChar = Console.ReadKey(true).KeyChar;
            if ((keyChar == 'Q') || (keyChar == 'q')) return;
        }
        static int ReadInt(int lastUsedValue, string promt)
        {
            Console.Write(promt + " [" + lastUsedValue + "]: ");
            string line = Console.ReadLine();
            if (int.TryParse(line, out int value))
            {
                Console.WriteLine(" using value " + value);
                return value;
            }
            else
            {
                Console.WriteLine(" using default value " + lastUsedValue);
                return lastUsedValue;
            }
        }
        static double ReadDouble(double lastUsedValue, string promt)
        {
            Console.Write(promt + " [" + lastUsedValue + "]: ");
            string line = Console.ReadLine();
            if (double.TryParse(line, out double value))
            {
                Console.WriteLine(" using value " + value);
                return value;
            }
            else
            {
                Console.WriteLine(" using default value " + lastUsedValue);
                return lastUsedValue;
            }
        }
    }
}
