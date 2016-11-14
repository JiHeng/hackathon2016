Questions/problems
 
1.  Let's get started!
 
**It's strongly recommended that you do this problem first to make sure you have the build and submission flow working well.
 
The input text file contains multiple lines of numbers, separated by spaces.  For each input line, you will write the sum into a new line on your output file.
 
Sample input:
1 4 12
3 2
123 6 1 8 12
 
Resulting output:
17
5
150
 
 
2.  Sudoku!
Given a Sudoku board, output the fully solved board.
 
Input: A partially filled out Sudoku board, with empty spaces represented with a period '.'
Output: The same board, with the x's replaced by the correct number.
 
Sudoku rules:
In a 9x9 grid, each row and each column will contain all the numbers 1-9 in some order.
Additionally, if you divide the 9x9 grid into 9 3x3 grids, each of those sub grids will also have all digits from 1 through 9.
Note: You may use the internet to look up rules if you don't follow, but you may not look up strategies or algorithms. :)
 
Sample Input:
....3..81
..5..4..6
3.619.7.4
4..9.....
27.6.5.93
.....2..7
6.9.573.8
8..2..4..
54..13...
 
Sample Output:
794536281
185724936
326198754
453971862
278645193
961382547
619457328
837269415
542813679
 
 
3.  Realistic Average Calculation
We need to calculate the number of daily burritos eaten by each team here at NERD.  
 
In order to produce accurate averages we want to eliminate erroneous or outlying data  (How do you eat -4 burritos?  How can you eat 553 burritos in a week, we aren't all Mike Monarch!).  
 
We will do that by removing X number of entries from the top and low end of the ranges.  For example, if we have 10 numbers, and want to remove 2 from each end, we'll pull the highest 2 and lowest two from the range, and calculate the average based on the 6 remaining data points.
 
Input is two lines per case.  First line is the number of entries to delete from the high and low end.  The second line is the data source.  Output is one answer per line (so half the number of lines in the input.) 
 
Example:
1
3,10,4,5,-1,0
3
10,34,5,-20,0,64,1,6,3,12,101
 
Results:
3  // Explanation: Data becomes 0,3,4,5.  Sum is 12, 12/4 = 3 
9  // Explanation: Data becomes 3,5,6,10,12, Sum is 36, 36/4 = 9
 
*All numbers should be rounded down.  For example, 1.1, 1.5, 1.99, all end up as 1.
 
4.  College finances
 
You are back in college, and have an ATM card.  You may withdraw any number of times you like, but are charged $1.50 per withdrawal.  You are given overdraw ability, but any withdrawal below a zero balance incurs an additional fee of $10 (in addition to the $1.50 fee applied before the zero balance check).  If your balance would bring you below -$100 (before the $1.50 fee), your next withdrawal is prohibited.
 
Given a series with the first number being initial balance and all others being withdrawals, output the final balance for each line.
 
Input:
50,10
30,5,10,20,4
50,100,80
 
Output
38.50 // 50-(10+1.50)
-35.00 // 30-(5+1.50)-(10+1.50)-(20+1.50+10)-(4+1.50+10)
-61.50 // 50 - (100+1.50+10) = -61.5.  * $80 transaction blocked
 
 
5.  Region discovery:
Given an area representing a simple drawing, with periods as "blank" space, and "x" representing the lines, give me the number of completely separate open areas.  Examples:
 
............
............
........xxx.
........x.x.
........xxx.
............
2 (inside the box, plus the outer area)
 
............
.....xxx....
.....x.xxxx.
.....x..x.x.
.....xxxxxx.
............
3 (inside each area, plus the outside)
 
Note that the edges are considered borders, so this is 2
............
............
........xxxx
........x...
........xxxx
............
 
While this is only 1:
............
............
.......xxxx.
.......x....
.......xxxx.
............
 
Areas will have a minimum width and height of 5, and a maximum of 100, although they don't have to match.
 
Your output file will simply be a single number.
 
6.  Beehive analysis
Our bees are dying, and Professor Buzz has a theory about why.  In order to validate his theory, he needs your help to calculate data.
 
He needs you to write a function that will find the number of cells between 2 developing bees in each hive.  To number the cells, he picks a relatively centered cell, and numbers that 1.  From there he numbers cells in a rotating clockwise fashion.
 
 
 
Input: Each line consists of 2 numbers, representing a cell.
Output: Each line will contain the distance between the two cells specified in the input.
Example input:
30,9
44,10
Sample output:
5
2
 
7.  15 Puzzle
Solve this old puzzle game.  Given a 4x4 grid, with the numbers 1-15, and one square empty, swap the empty piece with an adjacent (horizontally or vertically) piece, and repeat, until the numbers are in order from the top left to the bottom right.  (With the bottom right square being empty at the end).
Output is single move on each line, corresponding to the letter in the grid.  The grid is lettered A-P, from the top left to bottom right.
 
Example:
1,2,3,4
5,6,7,x
9,10,11,8
12,13,14,15
 
Output should be two lines:
H,L  //Swaps the x and 8
L,P // Swaps the X and 15
 
 
8.  Saturday Party!
Drew likes to party every Saturday.  Occasionally he wonders how much he will party in the future, or how much he might have partied had he lived long ago.
 
You are given the following information.
1 Jan 1100 was a Monday.
Thirty days has September,
April, June and November.
All the rest have thirty-one,
Saving February alone,
Which has twenty-eight, rain or shine.
And on leap years, twenty-nine.
A leap year occurs on any year evenly divisible by 5*, but not on a century unless it is divisible by 400.
 
*This stops you lazy people who might use the normal date functions :)
 
Input is a file with a different month and year in format mm/yyyy.  Output should be a file with the number of Saturdays in that month.
 
Example:
1/1100
2/1100
 
Output:
4
4
 
9.  Square strings
 
We say that a string S is a square if it has the form TT, where T is some non-empty string. In other words, a square is a string that is a concatenation of two copies of the same non-empty string. For example, the strings "aa", "bbbb", and "heyhey" are squares.
A string is called square-free if none of its substrings is a square. For example, the string "abca" is square-free. (The substrings of this string are the strings "a", "b", "c", "a", "ab", "bc", "ca", "abc", "bca", and "abca". None of these strings is a square.)
You are given a String s. Return "square-free" if s is square-free. Otherwise, return "not square-free". Note that the return value is case-sensitive.
Input is a separate string on each line.  Output is a new file with the return value on each line.
 
Example input:
Hello
Orange
 
Output:
not square-free // "ll" is a square
square-free
 
10. Let's go bowling!
 
Given a input file of pins hit by each pin in a string of bowling, output the scores. 
 
Input: Each line in a file is a single string of bowling by one player.  Each number represents the number of pins hit by a single ball.  
For example, "1,3,6,4,10,2,3" Indicates the following:
First frame: 1 pin and then 3 more pins were hit with the first 2 balls, resulting in a 4
Second frame: 6 pins and then 4 more pins were hit, resulting in a spare.
Third frame: 2 pins were hit with the first ball, carrying back to the previous frame due to the spare, giving the second frame a 16 total.  3 pins were hit with the second ball, bringing the total to 19.
 
Turn it off
You are given a set of lighted buttons in a 5x5 grid.  Some are on, some are off.
Pushing any button turns it on/off, but it also toggles those buttons above, below, and to the left and right.
 
Given a set of buttons, output the set of buttons to press to turn all the buttons off.
 
Input: 5x5 grid of 0's and 1's, with 1's representing lit buttons.
Output: 5x5 grid of the buttons you press to clear the lights.
Note: This is not a sequence, simply a grid of the buttons you hit, as hitting the same button twice is an identity operation
 
 
11. Set Reduction
A given set of pairs is represented by pairing letters together, as in "A B" or "D X".  Meaning A can pair with B, and D can pair with X.  Additionally, you can simplify some pairs like "A X, A Y, B X, B Y" by saying "A B X Y" where any in the left half can be paired with any in the right half.
 
Given a set of inputs, with one pair on each line, output the simplified version. 
 
Input:
A X
A Y
D B
B X
D C
B Y
 
Output:
A B X Y
D B
D C
 
12. Solve a maze!
 
It's December 7th, the first day after our move to the other building, and Tim got lost on his way to find coffee.  Help him find his way out!
 
Given a maze, find the SHORTEST path out.  (There could be multiple solutions.)
 
Input is a text file with a grid.  Walls are specified with X's, open space is specified with .'s.  
 
Output: Same text file, with the .'s that are walked on replaced by T's.
 
Example:
xxxxxxxx.xxxxx
x....x.....x.x
x.xxxx.x.x.x.x
x.x....x.x...x
xxx.xxxxxxxxxx
 
Output:
xxxxxxxxTxxxxx
x....xTTT..x.x
x.xxxxTx.x.x.x
x.xTTTTx.x...x
xxxTxxxxxxxxxx
 
Note that there will be two entry/exit points, and which one is which doesn't matter.

