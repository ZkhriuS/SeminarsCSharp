Console.WriteLine("Enter 2 values: ");
if (double.TryParse(Console.ReadLine(), out double first) && double.TryParse(Console.ReadLine(), out double second)){
if (first>second) Console.WriteLine($"max = {first}, min ={second}");
else Console.WriteLine($"max = {second}, min ={first}");
}else{
    Console.WriteLine("Incorrect input");
}