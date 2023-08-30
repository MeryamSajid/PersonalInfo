using System;

class Program {
  public static void Main (string[] args) { 

    // Declaring the variables
    string name;
    string birthdate;
    string workNum;
    string cellNum;

    // Asking for user input
    Console.Write ("Enter name: ");
    string name = Console.ReadLine();

    Console.Write ("Enter birthdate (mm/dd/yyyy): ");
    string dateInput = Console.ReadLine();

    Console.Write ("Enter work phone number: ");
    string workNum = Console.ReadLine();
    
    Console.Write ("Enter cell phone number: ");
    string cellNum = Console.ReadLine(); 

    //Info input display on separate lines
    Console.WriteLine (name);
    Console.WriteLine(birthdate);
    Console.WriteLine("cell " + cellNum);
    Console.WriteLine("work " + workNum);
    
}

}