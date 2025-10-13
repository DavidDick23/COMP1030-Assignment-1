#region Script Info
/*  COMP1030F - Assignment #1
 *  Group 11: Shy-Anna Lee, Mark Fisher, Suganth Vijayavel and David Dick
 *  Final Draft: 10/13/2025
 *  
 *  Description:
 *  This program is a simple C# console application that helps a user to 
 *  determine the cost of installing newflooring inside their server room.
 *  (see what we did by changing it from a room in a house to a server room!)
 *  
 *  **IMPORTANT** 
 *  All steps were completed by Shy, Mark and Suganth and all revisions
 *  to the code and comments were completed by Dave.
 *  
 *  Revisions were minor tweaks for congruency and functionality.
 *  
 *  Steps have been clearly outlined and completion of steps have been
 *  identified using the #region tags.
 */
#endregion

using System;

namespace Assignment1
{
    #region Revisions and Comments by Dave
    internal class Program
    {
        //constants for flooring prices to be used in string variables
        //and for calculations
        #region Completed by Mark
        const double HardwoodCost = 9.35;
        const double FancyTileCost = 10.57;
        const double LinoleumCost = 5.95;

        #endregion

        static void Main()
        {
            // --- Step 2: Declare and assign three string variables for flooring selection ---
            #region Completed by Shy
            string flooring1 = $"A - Hardwood Plank (${HardwoodCost}/sq.ft.)";
            string flooring2 = $"B - Fancy Tile (${FancyTileCost}/sq.ft.)"; 
            string flooring3 = $"C - Linoleum Square (${LinoleumCost}/sq.ft.)";

            #endregion

            // --- Step 3: Create a variable to store flooring selection ---
            #region Completed by Shy
            string flooringChoice = string.Empty;

            #endregion

            // --- Step 4: Declare two variables to represent the length and width of a room ---
            #region Completed by Shy
            double roomLength = 0.0; 
            double roomWidth = 0.0;

            #endregion

            #region A nice touch to the application - Added By Mark
            Console.WriteLine("Welcome to MegaByte Floors! Your preferred flooring solution for your server room!\n");

            #endregion

            // --- Step 5: Ask for the room length ---
            #region Completed by Shy
            Console.Write("Please enter the LENGTH of the room in FEET: ");

            #endregion

            // --- Step 6: Try to validate room length ---
            #region Completed by Shy and Mark
            while (true) //run a loop until a valid input has been entered
            {
                string lengthInput = Console.ReadLine(); //read the user's input

                //try to read the input as a double and if it's valid store it in the variable in step 4
                if (double.TryParse(lengthInput, out roomLength) && roomLength > 0)
                {
                    Console.WriteLine($"Room length is {roomLength:F1} feet.");
                    break; // valid input, exit loop
                }
                else
                {
                    //invalid input, display error message and prompt the user again
                    Console.WriteLine("Uh-oh! That was not a valid positive number for length. Please try again.\n");
                    Console.Write("Please enter the LENGTH of the room in FEET: ");
                }
            }

            #endregion

            // --- Step 7: Ask for the room width ---
            #region Completed by Shy
            Console.Write("Please enter the WIDTH of the room in FEET: ");

            #endregion

            // --- Step 8: Try to validate room width ---
            #region Completed by Mark
            while (true) //run a loop until a valid input has been entered
            {
                string widthInput = Console.ReadLine(); //read the user's input

                //try to read the input as a double and if it's valid store it in the variable in step 4
                if (double.TryParse(widthInput, out roomWidth) && roomWidth > 0)
                {
                    Console.WriteLine($"Room width is {roomWidth:F1} feet.\n");
                    break; // valid input, exit loop
                }
                else
                {
                    //invalid input, display error message and prompt the user again
                    Console.WriteLine("Uh-oh! That was not a valid positive number for width. Please try again.\n");
                    Console.Write("Please enter the WIDTH of the room in FEET: ");
                }
            }

            #endregion

            // --- Step 9: Ask the user what type of flooring they would like ---
            #region Completed by Shy
            Console.WriteLine("Enter your preferred type of flooring by typing A, B, or C:");
            Console.WriteLine(flooring1);
            Console.WriteLine(flooring2);
            Console.WriteLine(flooring3);
            Console.WriteLine();

            #endregion

            // --- Step 10: Check to see that the user has inputted a letter ---
            #region Completed by Mark
            while (true) //run a loop until a valid input has been entered
            {
                //read the user input, trim and make input all capitals 
                string flooringInput = Console.ReadLine();
                flooringChoice = (flooringInput ?? "").Trim().ToUpper();

                //use a bool to see if the input is a valid selection
                bool validChoice = flooringChoice == "A" || flooringChoice == "B" || flooringChoice == "C";

                //if the selection is valid display the selection and exit the loop
                if (validChoice)
                {
                    Console.WriteLine($"You have selected: {flooringChoice}");
                    break;
                }
                else
                {
                    //invalid input, display error message and prompt the user again
                    Console.WriteLine("Uh-oh! That was not a valid selection. Please try again.\n");
                    Console.WriteLine("Enter your preferred type of flooring by typing A, B, or C:");
                    Console.WriteLine(flooring1);
                    Console.WriteLine(flooring2);
                    Console.WriteLine(flooring3);
                }
            }

            #endregion

            // --- Step 11 & 12: Calculate area and cost ---
            #region Completed by Mark and Suganth
            //variables for displaying the selection and for calculations
            double area = roomLength * roomWidth;
            string selectedFlooringType = "";
            double pricePerSqFt = 0.0;

            //if else statements based on the user's selection in step 10
            if (flooringChoice == "A")
            {
                selectedFlooringType = "Hardwood Plank";
                pricePerSqFt = HardwoodCost;
            }
            else if (flooringChoice == "B")
            {
                selectedFlooringType = "Fancy Tile";
                pricePerSqFt = FancyTileCost;
            }
            else if (flooringChoice == "C")
            {
                selectedFlooringType = "Linoleum Square";
                pricePerSqFt = LinoleumCost;
            }

            //the calculation for determining the cost
            double totalCost = area * pricePerSqFt;

            #endregion

            // --- Step 13: Output estimate summary ---
            #region Completed by Suganth
            Console.WriteLine("\n===== ESTIMATE SUMMARY =====");
            Console.WriteLine($"Flooring Type: {selectedFlooringType} (${pricePerSqFt:F2}/sq.ft.)");
            Console.WriteLine($"Room Area:     {area:F1} sq.ft.");
            Console.WriteLine($"Final Cost:    ${totalCost:F2}");
            Console.WriteLine("============================");
            Console.WriteLine("\nThank you for choosing MegaByte Floors!");

            #endregion
        }
    }

    #endregion
}
