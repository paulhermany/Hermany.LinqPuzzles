<Query Kind="Statements" />

/* LINQ Puzzle #1 *******************************************************
Summary:  Given a collection of integers, create a new collection containing the difference between each consecutive element in the collection.
Sample Input:  {4, 3 ,6, 8, 2}
Sample Output:  {1, -3, -2, 6}
************************************************************************/

var rand = new Random();
var values = Enumerable.Repeat(0, 100).Select(x => rand.Next(0, 100)).ToList();

values.Skip(1).Zip(values, (b, a) => a - b).Dump();
