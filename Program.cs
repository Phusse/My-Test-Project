{
     int Digit1= 0; int Digit2= 0;

     Console.WriteLine("Console calculator built with C#");
     Console.WriteLine("--------------------------------");

     Console.WriteLine("Type a number, then press Enter");
     Digit1 = Convert.ToInt32(Console.ReadLine());

     Console.WriteLine("Input another number and click enter");
     Digit2 = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Choose an option from the List below");
    Console.WriteLine("\ta - Add");
    Console.WriteLine("\ts - Subtract");
    Console.WriteLine("\tm - Multiply");
    Console.WriteLine("\td - Divide");
    Console.WriteLine("Your Option?");
    
    switch(Console.ReadLine())
    //here we declare and tell the code what to do
    {
      case "a":
      Console.WriteLine($"Your Result : {Digit1} + {Digit2} = " + (Digit1 + Digit2));
      break;
    
    case "s":
      Console.WriteLine($"YOur Result : {Digit1} - {Digit2} = " + (Digit1 - Digit2));
      break;
    
    case "m":
      Console.WriteLine($"YOur Result : {Digit1} * {Digit2} = " + (Digit1 * Digit2));
      break;
   
    case "d":
      Console.WriteLine($"YOur Result : {Digit1} / {Digit2} = " + (Digit1 / Digit2));
      break;
    }

    Console.WriteLine("Press any key to close the calculator app");

    Console.ReadKey();
  
}
