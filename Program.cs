Console.WriteLine("Enter a value: ");
if (int.TryParse(Console.ReadLine(), out int first)){
    if(first%2==0) Console.WriteLine("Yes!");
    else Console.WriteLine("No!");
}
else{
    Console.WriteLine("Incorrect input");
}
