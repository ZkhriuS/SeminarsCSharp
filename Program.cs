Console.WriteLine("Enter a value: ");
if (int.TryParse(Console.ReadLine(), out int first)){
        int start = 1, step = 2;
        if(first<start) {
            start--;
            step = -2;
        }
        else start++;
        while(first - start > 1 || first - start < -1){
           Console.Write(start+", ");
           start+=step; 
        }
        Console.Write(start+" ");
}
else{
    Console.WriteLine("Incorrect input");
}