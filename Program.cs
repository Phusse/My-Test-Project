{
     int num1= 0; int num2= 0;

     Console.WriteLine("Console calculator built with C#");
     Console.WriteLine("--------------------------------");

     Console.WriteLine("Type a number, then press Enter");
    num1 = Convert.ToInt32(Console.ReadLine());

     Console.WriteLine("Input another number and click enter");
    num2 = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Choose an option from the List below");
    Console.WriteLine("\ta - Add");
    Console.WriteLine("\ts - Subtract");
    Console.WriteLine("\tm - Multiply");
    Console.WriteLine("\td - Divide");
    Console.WriteLine("Your Option?");
    
    switch(Console.ReadLine())

    {
      case "a":
      Console.WriteLine($"Your Result : {num1} + {num2} = " + (num1 + num2));
      break;
    
    case "s":
      Console.WriteLine($"YOur Result : {num1} - {num2} = " + (num1 - num2));
      break;
    
    case "m":
      Console.WriteLine($"YOur Result : {num1} * {num2} = " + (num1 * num2));
      break;
   
    case "d":
      Console.WriteLine($"YOur Result : {num1} / {num2} = " + (num1 / num2));
      break;
    }

    Console.WriteLine("Press any key to exit the calculator app");

    Console.ReadKey();
  
}
