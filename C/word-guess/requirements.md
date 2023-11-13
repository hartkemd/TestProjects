# Requirements

This app will allow a user to guess what letters are in a word.

It must:
- Ask the user for their guess (5 characters).
- Compare their guess to a predefined correct answer.
- Display their guess, the correct answer, and the contents of the "grey", "yellow", and "green" arrays, described below.

If the letter guessed...
- is not in the correct answer word, add its index to a "grey" array.
- is in the correct answer word, but not in the correct position, add its index to a "yellow" array.
- is in the correct answer word, and is at the same position as the correct answer, add its index to a "green" array.

Furthermore,
- If the letter guessed is in the correct answer word, has already been guessed, and is in the correct position, it must be added to the "green" array.
- If the letter guessed is in the correct answer word, has already been guessed, and is not in the correct position, it must be added to the "grey" array.
