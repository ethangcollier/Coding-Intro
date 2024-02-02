using System;
					
public class Program
{
	public void Main() //Main function containing the other functions.
	{
		Weather4U();
		Subjects();
	}
	public void Weather4U() //function containing the Temperature questioning.
	{
		Console.WriteLine("What's the temperature outside in Celsius? (Give a whole number)"); // user prompt question
		int temp = Convert.ToInt32(Console.ReadLine()); // establishing user input as temperature integer
		if (temp > 40) // The following are responses for the selected temperature ranges, from higher to lower.
		{
			Console.WriteLine("Holy crap I didn't know we lived in a bonfire. Guess I'll move to Antarctica or something.");
		}
		else if (temp > 30 & temp < 40)
		{
			Console.WriteLine("Hey be sure to stay Hydrated and stay out of the sun."); 
		}
		else if ( temp > 12 & temp < 29)
		{
			Console.WriteLine("Ah sounds pleasant. Have a good day then."); 
		}
		else if (temp > 2 & temp < 11)
		{
			Console.WriteLine("Make sure to wear a jacket, it's a bit chilly out.");
		}
		else if (temp > -17 & temp < 1)
		{
			Console.WriteLine("Brrrr, it's cold out there! Make sure to bundle up!");
		}
		else //Any other temperature will be below -17 degrees, and so uses the else.
		{
			Console.WriteLine("Ummm...maybe you should just stay inside today....");
		}
	}
	public void GradePercent() //function assigning letter grade based on the percentage.
	{
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
	public void Subjects() //Function containing  switches, asking about the specific subjects.
	{
		Console.WriteLine("Next is your grades. What class do you want to know your grade for? Math, Science, English, Coding, or a different class?");
		var subject = Console.ReadLine();
		switch (subject)
		{
			case "Math":
				Console.WriteLine("Oh Math is math-y alright. numbers and stuff.");
				GradePercent();
				break;
			case "Science": 
				Console.WriteLine("Science is pretty cool.");
				GradePercent();
				break;
			case "English":
				Console.WriteLine("English is necessary for communication.");
				GradePercent();
				break;
			case "Coding":
				Console.WriteLine("Computer Science can be confusing sometimes, but keep at it ;).");
				GradePercent();
				break;
			default: //Any other subject is considered an elective, and gets the default response.
				Console.WriteLine("Yeah elective classes are usually pretty fun.");
				GradePercent();
				break;
		}
	}
}
