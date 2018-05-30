using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PigDice {
	class Program {

		Random rnd = new Random();

		int RollDie() {
			return rnd.Next(1, 7);
		}

		void PlayPigDice() {
			int score = 0;
			int rolls = 1;
			int die = RollDie();
			
			while (die != 1) {
				RollDie();
				score += die;
				die = RollDie();
				rolls++;
			}
			Console.WriteLine("Score: {0}", score);
			Console.WriteLine("Rolls: {0}", rolls);
		}
		
		void Run() {
			bool quit = false;
			while (!quit) {
				PlayPigDice();

				Console.Write("Do you want to quit? ");
				string answer = Console.ReadLine();
				answer = answer.ToUpper(); //converts the answer to upper case
				quit = answer.StartsWith("Y"); //start with function which determines if answer variable starts with a Y				
			}
		}


		static void Main(string[] args) {

			(new Program()).Run();


			/* my code is below here for the game -- greg's code is above
			Random dice = new Random();
			int score = 0;
			int nbr = 5;
			int rolls = 0;
			int gamesplayed = 1;

			while (nbr > 1) {
				nbr = dice.Next(1, 7);
				score += nbr;
				rolls++;
				}
			Console.WriteLine("Score: " + score);
			Console.WriteLine("Rolls: {0}", rolls);
			Console.WriteLine("Games: " + gamesplayed);
			*/
		}
	}
}
