/*
 * Created by SharpDevelop.
 * User: JustFaith
 * Date: 8/10/2016
 * Time: 3:41 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace MathGame
{
	/// <summary>
	/// Description of QuestionGenerator.
	/// Generates questions and answers
	/// </summary>
	public class QuestionGenerator
	{		
		private string answer;
		private string question;
		private Random roller = new Random();
		
		/// <summary>
		/// Generates and returns a new question
		/// </summary>
		/// <returns>Returns a string containing the current generated question</returns>
		public string GetNextQuestion()
		{
			int a, b, c;
			a = (int)(roller.NextDouble() * 10) + 1;
			b = (int)(roller.NextDouble() * 10) + 1;
			c = a + b;
			//save the answer and question
			this.answer = c.ToString();			
			this.question = string.Format("What is {0} + {1}?", a,b);
			//return the question
			return GetQuestion();
		}
		
		/// <summary>
		/// Gets the current question in the class
		/// </summary>
		/// <returns>Returns a string containing the current question</returns>
		public string GetQuestion()
		{
			return this.question;
		}
		
		/// <summary>
		/// Gets the current answer for the class
		/// </summary>
		/// <returns>Returns a string containing the current answer</returns>
		public string GetAnswer()
		{
			return this.answer;
		}
	}
}
