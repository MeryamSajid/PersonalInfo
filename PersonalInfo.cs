using System;

class Program {
  public static void Main (string[] args) { 
    
    Console.Write ("Enter name: ");
    string name = Console.ReadLine();
    Console.WriteLine(name);

    Console.Write ("Enter birthdate: ");
    string dateInput = Console.ReadLine();
    Console.WriteLine(dateInput);

    Console.Write ("Enter work phone number: ");
    string workNum = Console.ReadLine();
    Console.WriteLine("work " + workNum);

    Console.Write ("Enter cell phone number: ");
    string cellNum = Console.ReadLine();
    Console.WriteLine("cell " + cellNum);
}

}