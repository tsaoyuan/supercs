static int GetPow(int baseNum, int powNum)
{
    int result = 1;

    for(int i = 0; i < powNum; i++)
    {
        result = result * baseNum;
    }

    return result;
}

Console.WriteLine(GetPow(2,2));