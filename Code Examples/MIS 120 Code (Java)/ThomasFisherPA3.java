import javax.swing.JOptionPane;
import java.io.*;
import java.util.Random;
import java.util.Scanner;
/*EXTRAS:
 * Everything is done with buttons, except entering risked gil
 * Try Catch blocks for number format exceptions when entering risked gil
 * Can't risk more gil than you have
 * The roulette
 * Java Docs
 * Option to play the game multiple times
 */

public class ThomasFisherPA3 {

	/**
	 * The main method introduces the premise of the game, and asks the user if
	 * they want to load a previous game or start a new game
	 * 
	 * @param args
	 * @throws FileNotFoundException in case the file isn't found
	 */

	public static void main(String[] args) throws FileNotFoundException {
		load();
		JOptionPane.showMessageDialog(null,
				"Welcome to Jolly JackPot Land! \nYou start each new game with 500 gil, \nTo pay you rent, you need 1000. \nYou can aquire more gil by playing Slots, Dice, or Roulette.");
		// Mathew Young showed me how the OptionDialog box works in java
		Object[] items = { "New Game", "Continue" };
		int fileChoice = JOptionPane.showOptionDialog(null,
				"Do you want to play a new game, or continue your previous one? \n(If you previously won, your gil amount has been reset to 500)",
				"Start Menu", JOptionPane.YES_NO_OPTION, JOptionPane.QUESTION_MESSAGE, null, items, items[0]);
		if (fileChoice == JOptionPane.YES_OPTION) {
			newGame();
		} else if (fileChoice == JOptionPane.NO_OPTION) {
			JOptionPane.showMessageDialog(null, "You are now starting with " + load() + " gil");
			Continue();
		} else {
			System.exit(0);
		}
	}

	/**
	 * The newGame method sets the gil amount to 500, then asks the player which
	 * game they want to play, and runs each respective method
	 * 
	 * @throws FileNotFoundException This is thrown in case the gilAmount.txt file doesn't exist
	 */

	public static void newGame() throws FileNotFoundException {
		save(500);
		Object[] items = { "Slots", "Dice", "Roulette" };
		int gameChoice = JOptionPane.showOptionDialog(null, "Do you want to play Slots, Dice, or Roulette?", " ",
				JOptionPane.YES_NO_OPTION, JOptionPane.QUESTION_MESSAGE, null, items, items[0]);
		if (gameChoice == JOptionPane.YES_OPTION) {
			gameOne(load());
		} else if (gameChoice == JOptionPane.NO_OPTION) {
			gameTwo(load());
		} else {
			gameThree(load());
		}

	}

	/**
	 * The Continue method does the exact same thing as the newGame method,
	 * except it does not set the gil amount to 500 before selecting a game
	 * 
	 * @throws FileNotFoundException This is thrown in case the gilAmount.txt file doesn't exist
	 */

	public static void Continue() throws FileNotFoundException {
		Object[] items = { "Slots", "Dice", "Roulette" };
		int gameChoice = JOptionPane.showOptionDialog(null, "Do you want to play Slots, Dice, or Roulette?", " ",
				JOptionPane.YES_NO_OPTION, JOptionPane.QUESTION_MESSAGE, null, items, items[0]);
		if (gameChoice == JOptionPane.YES_OPTION) {
			gameOne(load());
		} else if (gameChoice == JOptionPane.NO_OPTION) {
			gameTwo(load());
		} else {
			gameThree(load());
		}
	}

	/**
	 * The winLoss method is only run at the end of a game if the player has 0
	 * gil, or greater than 1000 gil, and it is run before the dialog box to
	 * play again is shown. The method itself sets the gil amount to a new
	 * variable called newGilAmount, then determines the value of that variable
	 * and displays the appropriate message. winLoss runs the main method once
	 * the winning or losing message has been displayed.
	 * 
	 * @throws FileNotFoundException This is thrown in case the gilAmount.txt file doesn't exist
	 */

	public static void winLoss() throws FileNotFoundException {
		double newGilAmount = load();
		if (newGilAmount >= 1000) {
			JOptionPane.showMessageDialog(null, "You can pay your rent!");
			save(500);
			main(null);
		} else if (newGilAmount <= 0) {
			JOptionPane.showMessageDialog(null, "You're homeless now...");
			save(500);
			main(null);
		} else {
			Continue();
		}
	}

	/**
	 * This contains the code to run Slots
	 * It creates an array with the slot options, then outputs 3 random words. If 2 match, it doubles the risked gil. If all 3 match, it triples the risked gil
	 * @param gil gil is passed in so that the winLoss can edit it
	 * @throws FileNotFoundException This is thrown in case the gilAmount.txt file doesn't exist
	 */

	public static void gameOne(double gil) throws FileNotFoundException {
		try {
			JOptionPane.showMessageDialog(null,
					"Start off by risking a portion of your gil. \nIf two of the returned words match, the risked amount of gil is doubled. \nIf all three words match, the risked amount of gil is tripled \nHowever, if no words match, you will lose the risked amount of gil");
			int playAgain;
			do {
				JOptionPane.showMessageDialog(null, "Your total amount of gil is " + gil);
				String riskedGilString = JOptionPane
						.showInputDialog("Please enter the number value of the gil you wish to risk");
				double riskedGil = Double.parseDouble(riskedGilString);
				double remainingGil = gil - riskedGil;
				if (remainingGil >= 0) {
					JOptionPane.showMessageDialog(null, "You are now playing slots, \nyou have risked " + riskedGil
							+ "\nand you have " + remainingGil + " left");
					String[] game1 = { "Elephant", "Computer", "Football", "Resume", "Capstone", "Crimson" };
					Random r = new Random();
					String slot1 = game1[r.nextInt(6)];
					String slot2 = game1[r.nextInt(6)];
					String slot3 = game1[r.nextInt(6)];

					String slots = (slot1 + " - " + slot2 + " - " + slot3);
					if (slot1 == slot2) {
						gil = gil + riskedGil * 2;
						JOptionPane.showMessageDialog(null, slots + "\nYou Won!" + "\nYou now have " + gil + " gil");
					} else if (slot1 == slot3) {
						gil = gil + riskedGil * 2;
						JOptionPane.showMessageDialog(null, slots + "\nYou Won!" + "\nYou now have " + gil + " gil");
					} else if (slot2 == slot3) {
						gil = gil + riskedGil * 2;
						JOptionPane.showMessageDialog(null, slots + "\nYou Won!" + "\nYou now have " + gil + " gil");
					} else if (slot1 == slot2 && slot1 == slot3) {
						gil = gil + riskedGil * 3;
						JOptionPane.showMessageDialog(null, slots + "\nYou Won!" + "\nYou now have " + gil + " gil");
					} else {
						gil = gil - riskedGil;
						JOptionPane.showMessageDialog(null,
								slots + "\nSorry, you lost" + "\nYou now have " + gil + " gil");
					}
					save(gil);

				} else {
					JOptionPane.showMessageDialog(null, "You cannont risk more gil than you have");
				}
				if (gil >= 1000 || gil == 0) {
					winLoss();
					break;
				}
				Object[] items = { "Play Again", "Main Menu" };
				playAgain = JOptionPane.showOptionDialog(null, "Please Select either Play Again, or Main Menu", " ",
						JOptionPane.YES_NO_OPTION, JOptionPane.QUESTION_MESSAGE, null, items, items[0]);
			} while (playAgain == JOptionPane.YES_OPTION);
			main(null);
		} catch (NumberFormatException e) {
			/*
			 * This block tells java what to do once the error has been "caught"
			 * it is important to not that this will only catch the
			 * NumberFormatException error not really sure how to make it run
			 * the try code again
			 */
			JOptionPane.showMessageDialog(null, "Next time, enter a number...");
			gameOne(gil);
		}
	}

	/**
	 * This contains the code to run dice
	 * It creates an array with the numbers 2-12, then prompts the user for range or exact amount
	 * If the user selects range, it asks them for high or low, and then determines if they win or lose and does the corresponding math
	 * If the user selects amount, it asks them to pick a number between 2 and 12 and if they picked the correct one it does the corresponding math
	 * @param gil gil is passed in so that the winLoss can edit it
	 * @throws FileNotFoundException This is thrown in case the gilAmount.txt file doesn't exist
	 */

	public static void gameTwo(double gil) throws FileNotFoundException {

		try {
			JOptionPane.showMessageDialog(null,
					"Start off by risking a portion of your gil. \nPick either a high or low range, or an exact number \nSelecting the correct high range (9-12) or low range (2-5), will double your risked amount \nSelecting the correct exact amount will triple the risked amount of gil \nHowever, if you do not select either a correct range, or a correct exact amount, you will lose the amount of risked gil");
			int playAgain;
			do {
				JOptionPane.showMessageDialog(null, "Your total amount of gil is " + gil);

				String riskedGilString = JOptionPane
						.showInputDialog("Please enter the number value of the gil you wish to risk");

				double riskedGil = Double.parseDouble(riskedGilString);
				double remainingGil = gil - riskedGil;
				if (remainingGil >= 0) {
					JOptionPane.showMessageDialog(null, "You are now playing dice, \nand you have risked " + riskedGil
							+ "\nand you have " + remainingGil + " left");
					// this is the start of the game two code
					String[] game2 = { "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12" };
					Random r = new Random();
					String diceAmountString = game2[r.nextInt(11)];
					int diceAmount = Integer.parseInt(diceAmountString);
					Object[] items = { "Range", "Exact Amount" };
					int ModeSelection = JOptionPane.showOptionDialog(null, "Do you want to play Range, or Exact Amount",
							"Game Mode Selection", JOptionPane.YES_NO_OPTION, JOptionPane.QUESTION_MESSAGE, null, items,
							items[0]);
					if (ModeSelection == JOptionPane.YES_OPTION) {
						Object[] rangeItems = { "High", "Low" };
						int rangeChoice = JOptionPane.showOptionDialog(null, "Select a High or Low range",
								"Range Selection", JOptionPane.YES_NO_OPTION, JOptionPane.QUESTION_MESSAGE, null,
								rangeItems, rangeItems[0]);
						if (rangeChoice == JOptionPane.NO_OPTION) {
							if (diceAmount >= 2 && diceAmount <= 5) {
								gil = gil + riskedGil * 2;
								JOptionPane.showMessageDialog(null,
										diceAmount + "\nYou Won!" + "\nYou now have " + gil + " gil");
							} else {
								gil = gil - riskedGil;
								JOptionPane.showMessageDialog(null,
										diceAmount + "\nSorry, you lost" + "\nYou now have " + gil + " gil");
							}
						} else {
							if (diceAmount >= 9 && diceAmount <= 12) {
								gil = gil + riskedGil * 2;
								JOptionPane.showMessageDialog(null,
										diceAmount + "\nYou Won!" + "\nYou now have " + gil + " gil");
							} else {
								gil = gil - riskedGil;
								JOptionPane.showMessageDialog(null,
										diceAmount + "\nSorry, you lost" + "\nYou now have " + gil + " gil");
							}
						}
					} else {
						String inputString = JOptionPane.showInputDialog("Type the integer of your exact amount");
						int input = Integer.parseInt(inputString);
						if (diceAmount == input) {
							gil = gil + riskedGil * 2;
							JOptionPane.showMessageDialog(null,
									diceAmount + "\nYou Won!" + "\nYou now have " + gil + " gil");
						} else {
							gil = gil - riskedGil;
							JOptionPane.showMessageDialog(null,
									diceAmount + "\nSorry, you lost" + "\nYou now have " + gil + " gil");
						}
					}
				} else {
					JOptionPane.showMessageDialog(null, "You cannont risk more gil than you have");
				}
				save(gil);
				if (gil >= 1000 || gil == 0) {
					winLoss();
				}
				Object[] items = { "Play Again", "Main Menu" };
				playAgain = JOptionPane.showOptionDialog(null, "Please Select either Play Again, or Main Menu", " ",
						JOptionPane.YES_NO_OPTION, JOptionPane.QUESTION_MESSAGE, null, items, items[0]);
			} while (playAgain == JOptionPane.YES_OPTION);
			main(null);
		} catch (NumberFormatException e) {
			JOptionPane.showMessageDialog(null, "Next time, enter a number...");
			gameTwo(gil);
		}

	}

	/**
	 * This method contains the code to run the roulette game
	 * It asks the user to select either black or red pockets, then it draws a number from an array
	 * It then compares the array number to the corresponding color, and if they match, does the corresponding math
	 * @param gil gil is passed in so that the winLoss can edit it
	 * @throws FileNotFoundException This is thrown in case the gilAmount.txt file doesn't exist
	 */

	public static void gameThree(double gil) throws FileNotFoundException {
		try {
			int playAgain;
			JOptionPane.showMessageDialog(null,
					"Start off by entering a portion of your gil to risk. \nThen select a color. \nIf the color selected is the color the ball lands in, the amount of risked gil is doubled. \nThe Pocket Colors are as follows: \n1-10, and 19-28, the odd pockets are red and even black \n11-18, and 29-36 the odd numbered pockets are black and even red");
			;
			do {
				JOptionPane.showMessageDialog(null, "Your total amount of gil is " + gil);

				String riskedGilString = JOptionPane
						.showInputDialog("Please enter the number value of the gil you wish to risk");
				double riskedGil = Double.parseDouble(riskedGilString);
				double remainingGil = gil - riskedGil;
				if (remainingGil >= 0) {
					JOptionPane.showMessageDialog(null, "You are now playing Roulette, \nyou have risked " + riskedGil
							+ "\nand you have " + remainingGil + " left");
					String[] game3 = { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15",
							"16", "17", "18", "19", "20", "21", "22", "23", "24", "25", "26", "27", "28", "29", "30",
							"31", "32", "33", "34", "35", "36" };
					Random r = new Random();
					String pocketsString = game3[r.nextInt(36)];
					int pockets;
					pockets = Integer.parseInt(pocketsString);
					Object[] items = { "Red", "Black" };
					int pocketChoice;
					pocketChoice = JOptionPane.showOptionDialog(null, "Please select a pocket color", " ",
							JOptionPane.YES_NO_OPTION, JOptionPane.QUESTION_MESSAGE, null, items, items[0]);
					if (pocketChoice == JOptionPane.YES_OPTION) {
						if (pockets % 2 == 1 && ((pockets >= 1 && pockets <= 10) || (pockets >= 19 && pockets <= 28))) {
							gil = gil + riskedGil * 2;
							JOptionPane.showMessageDialog(null,
									pockets + "\nThe ball landed on a red pocket!" + "\nYou now have " + gil + " gil");
						} else if (pockets % 2 == 0
								&& ((pockets >= 11 && pockets <= 18) || (pockets >= 29 && pockets <= 36))) {
							gil = gil + riskedGil * 2;
							JOptionPane.showMessageDialog(null,
									pockets + "\nThe ball landed on a red pocket!" + "\nYou now have " + gil + " gil");
						} else {
							gil = gil - riskedGil;
							JOptionPane.showMessageDialog(null,
									pockets + "\nSorry, the ball landed on a black pocket" + "\nYou now have " + gil + " gil");
						}
					} else {
						if (pockets % 2 == 1
								&& ((pockets >= 11 && pockets <= 18) || (pockets >= 29 && pockets <= 36))) {
							gil = gil + riskedGil * 2;
							JOptionPane.showMessageDialog(null, pockets + "\nThe ball landed on a black pocket!"
									+ "\nYou now have " + gil + " gil");
						} else if (pockets % 2 == 0
								&& ((pockets >= 1 && pockets <= 10) || (pockets >= 19 && pockets <= 28))) {
							gil = gil + riskedGil * 2;
							JOptionPane.showMessageDialog(null, pockets + "\nThe ball landed on a black pocket!"
									+ "\nYou now have " + gil + " gil");
						} else {
							gil = gil - riskedGil;
							JOptionPane.showMessageDialog(null,
									pockets + "\nSorry, the ball landed on a red pocket" + "\nYou now have " + gil + " gil");
						}
					}
				} else {
					JOptionPane.showMessageDialog(null, "You cannot risk more gil than you have");
					gameThree(gil);
				}
				save(gil);
				if (gil >= 1000 || gil == 0) {
					winLoss();
				}
				Object[] items = { "Play Again", "Main Menu" };
				playAgain = JOptionPane.showOptionDialog(null, "Please Select either Play Again, or Main Menu", " ",
						JOptionPane.YES_NO_OPTION, JOptionPane.QUESTION_MESSAGE, null, items, items[0]);
			} while (playAgain == JOptionPane.YES_OPTION);
			main(null);
		} catch (NumberFormatException e) {
			JOptionPane.showMessageDialog(null, "Next time, enter a number...");
			gameThree(gil);
		}
	}

	/**
	 * The save method overwrites the file "gilAmount.txt" with the gil variable, 
	 * The gil variable is passed into all the games, and is updated win they win
	 * @param gil gil is passed in so that the winLoss can edit it
	 * @throws FileNotFoundException This is thrown in case the file "gilAmount.txt" is not there
	 */

	public static void save(double gil) throws FileNotFoundException {
		PrintWriter gilAmount = new PrintWriter("gilAmount.txt");
		gilAmount.print(gil);
		gilAmount.close();
	}

	/**
	 * The load method creates the file "gilAmount.txt" and then declares the double, gil. 
	 * Gil is then set to whatever is written in the text file
	 * @return It returns gil
	 * @throws FileNotFoundException This is thrown in case the gilAmount.txt file doesn't exist
	 */

	public static double load() throws FileNotFoundException {
		File newGilAmount = new File("gilAmount.txt");
		Scanner x = new Scanner(newGilAmount);
		double gil;
		gil = x.nextDouble();
		x.close();
		return gil;
	}
}
