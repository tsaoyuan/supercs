static int GetMax(int num1, int num2, int num3)
{
    int result;
    if (num1 > num2 && num1 > num3)
    {
        result = num1;
    }
    else if (num1 < num2 && num2 > num3)
    {
        result = num2;
    }
    else 
    {
        result = num3;
    }
    
    return result;
}

Console.WriteLine(GetMax(6, 50, 12)); 