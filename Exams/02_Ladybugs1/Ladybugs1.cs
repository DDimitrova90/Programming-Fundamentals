using System;
using System.Linq;

namespace Ladybugs
{
    public class Ladybugs
    {
        public static void Main()
        {
            int arrLength = int.Parse(Console.ReadLine());
            int[] ladybugs = new int[arrLength];

            int[] indexes = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();
            string[] command = Console.ReadLine().Split();

            foreach (var index in indexes)
            {
                if (index >= 0 && index < arrLength)
                {
                    ladybugs[index] = 1;
                }
            }

            while (!command[0].Equals("end"))
            {
                long index = long.Parse(command[0]);
                long count = long.Parse(command[2]);

                if (index < 0 || index >= arrLength)
                {
                    command = Console.ReadLine().Split();
                    continue;
                }

                if (ladybugs[index] == 0)
                {
                    command = Console.ReadLine().Split();
                    continue;
                }

                if (command[1].Equals("right"))
                {
                    if (index + count >= arrLength || index + count < 0)
                    {
                        ladybugs[index] = 0;
                        command = Console.ReadLine().Split();
                        continue;
                    }
                    else
                    {
                        long flyDistance = index + count;
                        ladybugs[index] = 0;
                        while (index < arrLength && index >= 0 &&
                            flyDistance < arrLength && flyDistance >= 0)
                        {
                            if (ladybugs[flyDistance] == 0)
                            {
                                ladybugs[flyDistance] = 1;
                                break;
                            }
                            else
                            {
                                flyDistance += count;
                            }
                        }
                    }
                }
                else if (command[1].Equals("left"))
                {
                    if (index - count >= arrLength || index - count < 0)
                    {
                        ladybugs[index] = 0;
                        command = Console.ReadLine().Split();
                        continue;
                    }
                    else
                    {
                        ladybugs[index] = 0;
                        long flyDistance = index - count;

                        while (index < arrLength && index >= 0 &&
                            flyDistance < arrLength && flyDistance >= 0)
                        {
                            if (ladybugs[flyDistance] == 0)
                            {
                                ladybugs[flyDistance] = 1;
                                break;
                            }
                            else
                            {
                                flyDistance -= count;
                            }
                        }
                    }
                }

                command = Console.ReadLine().Split();
            }

            Console.WriteLine(string.Join(" ", ladybugs));
        }
    }
}