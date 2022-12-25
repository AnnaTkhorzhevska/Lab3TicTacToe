
using System;

public class Conditions
{
    public void CheckNumberOfCommand(int command)
    {
        if (command != 0 && command != 1 && command != 2 && command != 3 && command != 4)
        {
            throw new ArgumentOutOfRangeCondition(nameof(command), "No such number exists.");
        }
    }

    public void CheckPlayer(int index, int length)
    {
        if (index > length && index < 1)
        {
            throw new IndexOutOfRangeCondition($"Index does not fall within the range [1; {length}]");
        }
    }


} 