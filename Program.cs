// See https://aka.ms/new-console-template for more information
Boolean disp = false;
while (!disp) {
    Console.WriteLine("How many people are we making PB and J sandwiches for?");
    int people = int.Parse(Console.ReadLine());
    decimal NumOfBread  = people * 2;
    decimal NumOfPeanut = people * 2;
    decimal NumOfJelly  = people * 4;
    decimal totalLoavesNeeded = NumOfBread / 28;    
    totalLoavesNeeded = Math.Ceiling(totalLoavesNeeded);
    decimal totalPeaNutButterNeeded = NumOfPeanut / 32;
    totalPeaNutButterNeeded = Math.Ceiling(totalPeaNutButterNeeded);
    decimal totalJellyNeeded = NumOfJelly / 48;
    totalJellyNeeded = Math.Ceiling(totalJellyNeeded);
    Console.WriteLine("You Need:");
    Console.WriteLine("   " + NumOfBread  + "  slices of Bread");
    Console.WriteLine("   " + NumOfPeanut + "  tablespoons of peanut butter");
    Console.WriteLine("   " + NumOfJelly  + "  teaspoons of jelly" + "\n");
    Console.WriteLine("Which is...  " + "\n");
    Console.WriteLine(totalLoavesNeeded + "  loaves of bread " );
    Console.WriteLine( totalPeaNutButterNeeded + "  jars of peanut butter " );
    Console.WriteLine( totalJellyNeeded + "  jars of jelly" );
    Console.WriteLine("Would you like to restart? Enter yes or y to continue, or enter any other key to exit.");
    String UserResponse = Console.ReadLine();
    if (UserResponse != "yes" && UserResponse != "y") 
      {
        Console.WriteLine("Goodbye!");
        disp = true;
        return;
      }
    else 
        disp = false;
       
}