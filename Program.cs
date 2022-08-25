Console.WriteLine("Enter 3 values: ");
if (double.TryParse(Console.ReadLine(), out double first) 
    && double.TryParse(Console.ReadLine(), out double second)
    && double.TryParse(Console.ReadLine(), out double third)){
        double max =first;
        if (second > max) max = second;
        if (third > max) max = third;
        Console.WriteLine($"max = {max}");
}
else{
    Console.WriteLine("Incorrect input");
}