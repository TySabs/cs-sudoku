# Sudoku Game

Goals:
1. Pull up an unsolved puzzle ✅
2. From a selection of varying difficulties... ✅
3. The ability for us to save our current progress, to be resumed later... ✅
4. With a mechanism to track our progress with solving puzzles within a single difficulty... ❌
5. A button to "cheat" or "help" with finding the solution... ❌
6. Another button to verify the correctness (or lack thereof) of our current solution... ❌
7. A "pause" button... ✅
8. And of course, as with most things, a reset button.  ✅

## Pulling up a new puzzle
We're going to have text files setup that will serve as our "database" of available puzzles,
with two layers of organization: first by difficulty, then by completed followed by uncompleted puzzles within those difficulties.

Once the user has indicated they would like to select a new puzzle of a specific difficulty, your task will be to fetch either the first saved puzzle they have or an unsolved puzzle. If you arrange your puzzles as [Completed], [Completed], [Saved], [Saved], [Unsolved], you only need to iterate from 0 to (n - 1) until you find either or. This should have the effect of taking the contents of the (either saved or unsolved puzzle) and populating them into our Form. At which time, our timer should either resume from the saved time or begin from 0:00.

Here is a zip file of [sample puzzles], including their solutions. You'll want to open the directory.txt file, which contains the names of the other files to be opened. Using `ReadLine`, you'll open each file, collect the input values, and if when the user action dictates it, save an in-progress puzzle, or record the time for that puzzle's solution.

## Varying Difficulties
I would like to insist on the one-step process for this project, whereby choosing one of the difficulties pulls up a new puzzle.

## Saving Our Progress
You will find yourself with three (3) versions of each puzzle to be stored: the initial state of the puzzle, an (optionally defined) saved state, and the solution.

## Tracking Our Success
For each difficulty, I want a memory of:
1. The fastest solve time
2. The average solve time of all puzzles within this difficulty

My recommendation would be to record each time for each difficulty, then re-confirm and re-calculate the fastest/average time after each puzzle's completion.

After the player solves any given puzzle, make sure to display:

* The completion time for this puzzle
* The fastest completion time for this difficulty of puzzles
* The average completion time for this difficulty of puzzles

You can do this simply enough with a dialog box.

## Getting Help
Functionally, this option should choose:
1. A random, un-filled cell and insert the correct number or (if the puzzle is completely filled but incorrect)
2. choose the first cell found in a sequential search (down each row, for each and every row) that isn't correct, and change it to the correct value

This should also have the effect of not storing the time of this puzzle's solution, as "cheating" invalidates that attempt.

## Progress Button
Sudoku lends itself well to being checked overtime to ensure whether we've make correct selections so far, since any given cell only has exactly one correct value. This function should examine the currently defined cells and compare them to the solution. If all of the currently defined cells match the solution, present some kind of, "You're doing well so far!" type of message. You might optionally inform the player of how many remaining cells need defining, which should be simple enough to figure out from a programmer's point of view.

If the player has made a mistake, though, you'll want to point out what exactly went wrong. The aforementioned WebSudoku website does this by darkening a row/column/box in red whenever two of the same numbers appear in any given row/column/box. Other Sudoku puzzle games I've played have drawn a circle around the offending cells, with a line connecting them, which I much preferred, as it made it more obvious where the mistake was. Either method is acceptable for this project.

Alternatively, it may be possible for the player to enter a value into a cell that doesn't break the "no duplicates" rule for rows/columns/boxes, but isn't the correct value to be placed there. For these types of mistakes, you'll want to simply highlight that cell by itself.

## Pause
Functionally, this should stop our Timer from ticking on, until a second button is pressed to resume solving the puzzle.
This pause functionality could be exploited to ignore the time spent deciding which next cell can be confirmed with any given number, so ideally, we should hide or otherwise mask the Sudoku puzzle grid while the pause functionality is active. You can achieve this anyway you like but if you're otherwise unsure, you can simply change the grid cells to all be equal to ? or X or just blank. Only to have their contents restored when the "Resume" button is pressed.

Oh, you'll want to make the "Pause" and "Resume" Buttons be the same component in your Form, too. You won't lose 50% of the available points for this assignment if you have two, fixed, buttons for each action, but you'll definitely lose some points. Instead, you should be able to change the text of the Button dynamically, depending on which state the game currently is in.

## Reset
This function will likely be the easiest to realize, as you'll simply re-load the initial state of the currently selected Sudoku puzzle, and reset the timer. If the "cheated" flag had previously been set to true, go ahead and reset that as well to false.

## Now Focus
Clearly, the most obvious Form component you might think of using to capture the user input would be 81 `TextBoxes`, of an appropriate size. And you wouldn't be wrong, not that you must use `TextBoxes` for your input fields. What's most important, though, is that selecting one of these `TextBoxes` doesn't cause the blinking I-cursor to persist. Ideally, I would select one of the fields, and wait for it to detect which number I enter from the keyboard, without seeing the I-cursor appear. Only because I'm not really going to enter text and certainly not anymore than a single character.

To help accomplish this, you'll want to re-direct Focus of your input fields, so that the default I-cursor doens't appear -- although, if you find an alternate way to prevent this from happening, more power to you. Of course, you'll want to make sure only numeric characters are entered from the keyboard, and that any given cell only contains exactly one (1) numeric character. You might also want to disallow zero from being entered, as that's simply not a valid choice. You can control these input values by installing an `EventHandler` for keyboard input, and filtering our the `KeyChar` or `KeyValue` Property of the `KeyPressEventArgs` object. From there, you can check if whether the selected input value already has a value entered and if not, whether the pressed key was a numeric character.

Once you've solved the I-cursor problem, I want the selected cell to be highlighted (since there won't be a cursor to otherwise indicate where Focus currently is). You can do this quite simply by changing the background color of that input field.

While on the subject of colors and appearances: make sure the values from the initial state of the puzzle:
1. Are highlighted (I recommend putting them in bold)
2. Unable to be changed by the player.

## Puzzle grid
|     |*A*|*B*|*C*|*D*|*E*|*F*|*G*|*H*|*J*|
|-----|---|---|---|---|---|---|---|---|---|
|**1**| 1A| 1B| 1C| 1D| 1E| 1F| 1G| 1H| 1J|
|**2**| 2A| 2B| 2C| 2D| 2E| 2F| 2G| 2H| 2J|
|**3**| 3A| 3B| 3C| 3D| 3E| 3F| 3G| 3H| 3J|
|**4**| 4A| 4B| 4C| 4D| 4E| 4F| 4G| 4H| 4J|
|**5**| 5A| 5B| 5C| 5D| 5E| 5F| 5G| 5H| 5J|
|**6**| 6A| 6B| 6C| 6D| 6E| 6F| 6G| 6H| 6J|
|**7**| 7A| 7B| 7C| 7D| 7E| 7F| 7G| 7H| 7J|
|**8**| 8A| 8B| 8C| 8D| 8E| 8F| 8G| 8H| 8J|
|**9**| 9A| 9B| 9C| 9D| 9E| 9F| 9G| 9H| 9J|



[sample puzzles]: https://github.com/joshruge89/Assign5/tree/master/Sudoku/Properties/Resources/puzzles
