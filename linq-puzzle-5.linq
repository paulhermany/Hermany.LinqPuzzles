<Query Kind="Statements" />

/* LINQ Puzzle #5 *******************************************************
Description:  Generate the first n digits of the Fibonacci Series! 
Sample Input:  n = 9;
Sample Output:  {0, 1, 1, 2, 3, 5, 8, 13, 21};
************************************************************************/

var n = 4;

Enumerable.Range(0, n)
	.Select(i => 
		Enumerable.Range(0, i)
			.Aggregate((prev:0, curr:1), (fib, _) => (fib.curr, fib.prev + fib.curr)).prev).Dump();
