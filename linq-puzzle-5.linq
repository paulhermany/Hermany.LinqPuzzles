<Query Kind="Statements" />

/* LINQ Puzzle #5 *******************************************************
Description:  Generate the first n digits of the Fibonacci Series! 
Sample Input:  n = 9;
Sample Output:  {0, 1, 1, 2, 3, 5, 8, 13, 21};
************************************************************************/

var n = 4;

Enumerable.Range(0, n)
	.Aggregate(
		(prev: 0, curr:1, list: Enumerable.Range(0,0))
		,(fib, i) => (fib.curr, fib.prev + fib.curr, fib.list.Append(fib.prev))
	).list.Dump();

