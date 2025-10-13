//Shy-Anna Lee, Dave Dick, Mark Fischer, Suganth Vijayavel
//Group 11
//Group Assignment 1
//Sept/29/2025
//C#

//Declare and assign three string variables for three different types of flooring each with a price per square foot (perhaps "Hardwood ($8.95/sq.ft.)" as an example - come up with something original, here).
//Declare a variable to capture the user's choice of flooring type.
//Declare two variables to represent the length and width of a room (using feet measured to one decimal point).
//Ask the user the length of the room they are looking to install the new flooring.
//Check to see that the user has inputted a number - if yes, then store this value in the length variable created in step 4, if no then output an appropriate error message to the console.
//Ask the user the width of the room they are looking to install the new flooring.
//Check to see that the user has inputted a number - if yes, then store this value in the length variable created in step 4, if no then output an appropriate error message to the console.
//Ask the user what type of flooring they would like, by building a sentence using the variables created in step 2 - to make it easy for the user, perhaps assign letters to each choice.
//Check to see that the user has inputted a letter (one of the three choices for flooring) - if yes, then store this value in the variable created in step 3, if no then output an appropriate error message to the console.
//Create a series of if() statements that correspond to each choice of flooring.
//Inside each of the if() statements, do some math: get the area of the floor to be covered, and multiply that by the price of the selected floor type.
//Output a sentence to the user indicating what floor type they picked, the area of the floor they are covering, and the final cost.
//Be sure to include helpful and appropriate comments throughout your program
//Have fun!

using System.ComponentModel.Design;

namespace Group11_1
{
    internal class Program
    {
        const double HardwoodCost = 9.35;
        const double FancyTileCost = 10.57;
        const double LinoleumCost = 5.95;
        static void Main(string[] args)
        {
//  Declare and assign three string variables for three different types of flooring each with a price per square foot (perhaps "Hardwood ($8.95/sq.ft.)" as an example - come up with something original, here). 
            string flooring1 = "A - Hardwood Plank ($9.35/sq.ft.)"; //variable 1
            string flooring2 = "B - Fancy Tile ($10.57/sq.ft.)"; //variable 2
            string flooring3 = "C - Linoleum Square($5.95/sq.ft.)"; //variable 3
            Console.WriteLine();

//  Declare a variable to capture the user's choice of flooring type.
            Console.WriteLine("Welcome to MegaByte Floors! Your preferred flooring solution for your server room!"); //Mark
            Console.WriteLine("Enter your preferred type of flooring with A, B, or C:"); //captures user flooring type
            Console.WriteLine(flooring1);
            Console.WriteLine(flooring2);
            Console.WriteLine(flooring3);
            string flooringType = Console.ReadLine();//captures user flooring type

             if (flooringType != "A" && flooringType != "B" && flooringType != "C") ;
             {
                 Console.WriteLine($"You have chosen floor type {flooringType}");
             } //Mark
            if (flooringType != "A" && flooringType != "B" && flooringType != "C");
            {
                Console.WriteLine("Invalid flooring Choice. Please try again.");
            }
// Declare two variables to represent the length and width of a room (using feet measured to one decimal point). (double)
            double roomLength = 0.0;//Length of room
            double roomWidth = 0.0;//Width of room

//  Ask the user the length of the room they are looking to install the new flooring.
           Console.WriteLine("Please enter the LENGTH of room in FEET.");//prompt to gain room length info
           string  lengthInput = Console.ReadLine();
            
//  Check to see that the user has inputted a number - if yes, then store this value in the length variable created in step 4, if no then output an appropriate error message to the console.
            if (double.TryParse(lengthInput, out roomLength))
            {
                Console.WriteLine($"Room length is {lengthInput} feet.");//responds to user input length
                    }
            else
            {
                Console.WriteLine("Uh-oh! That was not avalid number, please try again.");//invalid input message length
                
            }
//  Ask the user the width of the room they are looking to install the new flooring.
            Console.WriteLine("Please enter WIDTH of room in FEET.");//prompt to gain value of width of room
            string widthInput = Console.ReadLine();

//  Check to see that the user has inputted a number - if yes, then store this value in the length variable created in step 4, if no then output an appropriate error message to the console.
         if (double.TryParse(widthInput, out roomWidth))
            {
                Console.WriteLine($"Room width is {widthInput} feet.");//responds to user input width
            }
            else
            {
                Console.WriteLine("Uh-oh! That was not a valid number, please try again.");//invalid input message width
                
            }
//  Ask the user what type of flooring they would like, by building a sentence using the variables created in step 2 - to make it easy for the user, perhaps assign letters to each choice.
            //Mark
            double calculateNum = (roomLength * roomWidth);
                Console.WriteLine($"The area of the room is {calculateNum} square feet."); //Mark

        if (flooringType == "A")
            {
                Console.WriteLine($"You have chosen Floor Type {flooring1}");
                double calculateCost = (calculateNum * HardwoodCost);
                Console.WriteLine($"The total cost for {flooring1} is ${calculateCost}");
            }

        if (flooringType == "B")
            {
                Console.WriteLine($"You have chosen Floor Type {flooring2}");
                double calculateCost2 = (calculateNum * FancyTileCost);
                Console.WriteLine($"The total cost for {flooring2} is ${calculateCost2}");
            }

        if (flooringType == "C")
            {
                Console.WriteLine($"You have chosen Floor Type {flooring3}");
                double calculateCost3 = (calculateNum * LinoleumCost);
                Console.WriteLine($"The total cost for {flooring3} is ${calculateCost3}");
            }
            //Mark
            
            double pricePerSqFt = 0.0;//variables to convert input
            string selectedFlooringType = "";//" "

            if (flooringType == "A")// if user input A
            {
                selectedFlooringType = "Hardwood";//if hardwood
                double area = roomLength * roomWidth;//multiply room length by width
                double totalCost = area * 9.35;//multiply area by price per sq ft
            }
            else if (flooringType == "B")//if user inputs "B"
            {
                selectedFlooringType = "Fancy Tile";//if Fancy Tile
                double area = roomLength * roomWidth;// multiply room length by width
                double totalCost = area * 10.57;// area by price per sq ft
            }
            else if (flooringType == "C")//if user inputs "C"
            {
                selectedFlooringType = "Linoleum";// if linoleum
                double area = roomLength * roomWidth;//multiply room length by width
                double totalCost = area * 5.95;// multiply area by price per sq ft
            }
            else
            {
                Console.WriteLine("Not a valid flooring choice");//display invalid choice
            }

            //Check to see that the user has inputted a letter (one of the three choices for flooring) - if yes, then store this value in the variable created in step 3, if no then output an appropriate error message to the console.--Suganth
            string choiceNormalized = (flooringType ?? "").Trim().ToUpper();
            bool validChoice = choiceNormalized == "A" || choiceNormalized == "B" || choiceNormalized == "C";
            if(!validChoice)
            {
                Console.WriteLine("Invalid flooring choice. Please restart and enter A, B, or C.");
                return;
            }

            if (choiceNormalized == "A")
            {
                selectedFlooringType = "Hardwood Plank";
                pricePerSqFt = 9.35;
            }
            else if (choiceNormalized == "B")
            {
                selectedFlooringType = "Fancy Tile";
                pricePerSqFt = 10.57;
            }
            else
            {
                selectedFlooringType = "Linoleum Square";
                pricePerSqFt = 5.95;
            }

            //Output a sentence to the user indicating what floor type they picked, the area of the floor they are covering, and the final cost.--Suganth
            double finalArea = roomLength * roomWidth;
            double finalCost = finalArea * pricePerSqFt;

            Console.WriteLine("\n===== ESTIMATE SUMMARY =====");
            Console.WriteLine($"Flooring Type: {selectedFlooringType} (${pricePerSqFt:F2}/sq.ft.)");
            Console.WriteLine($"Room Area:     {finalArea:F1} sq.ft.");
            Console.WriteLine($"Final Cost:    ${finalCost:F2}");
            Console.WriteLine("============================");

        }
    }
}
