<Query Kind="Statements" />

/* LINQ Puzzle #2 *******************************************************
 
Summary: Given a collection of objects, unsort it!  (i.e randomize it.)
 
Sample Input: {"a", "b", "c", "d"}
Sample Output: {"d", "a", "c", "b"}
 
************************************************************************/

var input = Enumerable.Range(0, 100).ToList();

input.OrderBy(_ => Guid.NewGuid()).Dump();