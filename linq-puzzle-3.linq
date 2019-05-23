<Query Kind="Statements" />

/* LINQ Puzzle #3 *******************************************************
Summary:  Given a collection of integers, find the mode.  The mode is the value(s) that appears most often in the collection.  If multiple values appear equally as often, return all values.
Sample Input:  {4, 3, 6, 8, 2, 3}
Sample Output:  {3}
Sample Input:  {4, 3, 6, 8, 2, 3, 4}
Sample Output:  {3, 4}
************************************************************************/

var rand = new Random();
var input = Enumerable.Repeat(0, 100).Select(x => rand.Next(0, 30)).ToList();

input.GroupBy(_ => _).GroupBy(g => g.Count()).OrderByDescending(gg => gg.Key).First().Select(g => g.Key).Dump();