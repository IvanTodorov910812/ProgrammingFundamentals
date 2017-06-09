namespace _16.InstructionSet
{
    using System;

    public class InstructionSet
    {
        public static void Main()
        {
            string opCode = string.Empty;
            long result = 0;

            while (opCode != "END")
            {
                opCode = Console.ReadLine();
                string[] codeArgs = opCode.Split(' ');

                switch (codeArgs[0])
                {
                    case "INC":
                        {
                            long operandOne = long.Parse(codeArgs[1]);
                            result = ++operandOne;
                            break;
                        }
                    case "DEC":
                        {
                            long operandOne = long.Parse(codeArgs[1]);
                            result = --operandOne;
                            break;
                        }
                    case "ADD":
                        {
                            long operandOne = long.Parse(codeArgs[1]);
                            long operandTwo = long.Parse(codeArgs[2]);
                            result = operandOne + operandTwo;
                            break;
                        }
                    case "MLA":
                        {
                            long operandOne = long.Parse(codeArgs[1]);
                            long operandTwo = long.Parse(codeArgs[2]);
                            result = operandOne * operandTwo;
                            break;
                        }
                }

                if (opCode != "END")
                {
                    Console.WriteLine(result);
                }
            }
        }
    }
}