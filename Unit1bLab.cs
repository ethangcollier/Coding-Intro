using System;
					
public class Program
{
	public void Main()
	{
		Console.WriteLine("What's the temperature outside in Celsius? (Give a whole number)"); // user prompt question
		int temp = Convert.ToInt32(Console.ReadLine()); // establishing user input as temperature integer
		if (temp > 30)
		{
			Console.WriteLine("Hey be sure to stay Hydrated and stay out of the sun."); // Response if temp. is above 30 degrees C.
		}
		else
		{
			Console.WriteLine("Ah sounds pleasant. Have a good day then."); // Response if temp. is below 30 degrees C. We like the cold.
		}
		Console.WriteLine("Also what is your grade percentage?"); //Prompt to ask user about grades.
		int grade = Convert.ToInt32(Console.ReadLine()); // Converting user input into Grade integer.
		if (grade > 89)
		{
			Console.WriteLine("You have an A. Keep up the good work champ."); //Various responses and letter grades according to user input.
		}
		else if (79 < grade & grade < 90)
		{
			Console.WriteLine("You have a B");
		}
		else if (69 < grade & grade <80)
		{
			Console.WriteLine("You have a C");
		}
		else if (59 < grade & grade < 70)
		{
			Console.WriteLine("You have a D");
		}
		else 
		{
			Console.WriteLine("You have an F. Keep your chin up and get your grades up.");
		}

			
	}
}
