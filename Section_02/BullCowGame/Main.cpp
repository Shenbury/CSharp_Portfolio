#include <iostream>
#include <string>

using namespace std;

string GetGuessAndPrintBack();
void PrintIntro();

// Entry Point for our application
int main()
{
	PrintIntro();

	//Loop for the number of turns
	
	constexpr int NUMBER_OF_TURNS = 5;
	for (int count = 1; count <= NUMBER_OF_TURNS; count++)
	{
		GetGuessAndPrintBack();
		cout << endl;
	}
	
	
	cout << endl;
	return 0;
}


	//Introduce the game
	void PrintIntro() {
		constexpr int WORD_LENGTH = 9;
		cout << "Welcome to Bulls and Cows, a fun word game.\n";
		cout << "Can you guess the " << WORD_LENGTH;
		cout << " Letter isogram I'm thinking of?\n";
		cout << endl;
		return;
	}
	
	// get a guess from the player, Print the guess back to them
	string GetGuessAndPrintBack() {
		cout << "Enter your guess: ";
		string Guess = "";
		getline(cin, Guess);
		cout << "Your guess was: " << Guess << endl;
		return Guess;
	}
