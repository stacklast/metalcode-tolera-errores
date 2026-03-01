try
{
    Console.WriteLine("Escribe un número:");
    int a = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Escribe otro número:");
    int b = Convert.ToInt32(Console.ReadLine());

    int result = a / b;

    Console.WriteLine("El resultado de la división es: " + result);
}
catch (Exception ex)
{
    Console.WriteLine($"An error occurred: {ex.Message}");
}
finally
{
    Console.WriteLine("Execution completed.");
}