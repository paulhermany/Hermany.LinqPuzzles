<Query Kind="Statements" />

/* LINQ Puzzle #21 *******************************************************
Summary: Given a list integers, generate every sublist. A sublist is any consecutive sequence that
appears in the original list.
Sample: { 1, 2, 3 } => {
    {1},
    {2},
    {3},
    {1, 2},
    {2, 3},
    {1, 2, 3}
}
************************************************************************/

var ints = new[] { 1, 2, 3, 4 };

Enumerable.Range(1, ints.Length)
	.SelectMany(length =>
		Enumerable.Range(0, ints.Length - length + 1).Select(i => ints.Skip(i).Take(length))).Dump();