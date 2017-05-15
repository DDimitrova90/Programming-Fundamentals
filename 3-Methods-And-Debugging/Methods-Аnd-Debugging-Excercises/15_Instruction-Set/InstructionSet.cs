using System;

class InstructionSet_broken
{
    static void Main()
    {
        string[] parameters = Console.ReadLine().Split(' ');
        string command = parameters[0];

        while (command != "END")
        {
            long result = 0;

            switch (command)
            {
                case "INC":
                    {
                        long operandOne = long.Parse(parameters[1]);
                        result = operandOne + 1;
                        break;
                    }
                case "DEC":
                    {
                        long operandOne = long.Parse(parameters[1]);
                        result = operandOne - 1;
                        break;
                    }
                case "ADD":
                    {
                        long operandOne = long.Parse(parameters[1]);
                        long operandTwo = long.Parse(parameters[2]);
                        result = operandOne + operandTwo;
                        break;
                    }
                case "MLA":
                    {
                        long operandOne = long.Parse(parameters[1]);
                        long operandTwo = long.Parse(parameters[2]);
                        result = operandOne * operandTwo;
                        break;
                    }
            }

            Console.WriteLine(result);
            parameters = Console.ReadLine().Split(' ');
            command = parameters[0];
        }
    }
}