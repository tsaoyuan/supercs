try
{
    Console.Write("Enter first number: ");
    int num1 = Convert.ToInt32(Console.ReadLine());
    Console.Write("Enter second number: ");
    int num2 = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine(num1 / num2);

}
catch(Exception e)
{
    Console.WriteLine($"Error {e.Message}");
}