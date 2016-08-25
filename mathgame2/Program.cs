/*
 * Created by SharpDevelop.
 * User: JustFaith
 * Date: 8/9/2016
 * Time: 1:17 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace MathGame
{
	/// <summary>
	/// Math Game
	/// </summary>
	class Program
	{
		public static void Main(string[] args)
		{
			Console.WriteLine("MATHS GAME!");
			Console.WriteLine("Enter \"quit\" to quit anytime");
			
			//declare variables
			int score = 0, total = 0;
			
			//create new question generator
			QuestionGenerator qg = new QuestionGenerator();

			string guess = "";
			//while user has not entered quit as answer, continue generating questions			
			while (guess != "quit")
			{
				//generate and write question to screen
				Console.WriteLine(qg.GetNextQuestion());
		
				//get user input
				guess = Console.ReadLine().Trim();
				
				//if user input is equal to answer, increase score and write correct
				if (guess == qg.GetAnswer())
				{
					score++;
					Console.WriteLine("Correct!");
				}//end of if statement
				else
				{
					//tell user they are wrong
					Console.WriteLine("Wrong!");
				}//end of else statement
				total++;
				//loop again
				
			}//while loop ends
			
			//write user score results/summary
			Console.WriteLine("Congratulations! You got {0} out of {1}.", score, total);
			
			Console.Write("\nPress any key to continue . . . ");
			Console.ReadKey(true);
		}//end of main
	}//end of class
}//end of namespace