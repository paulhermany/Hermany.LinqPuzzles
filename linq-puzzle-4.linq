<Query Kind="Statements" />

/* LINQ Puzzle #4 *******************************************************
Description:  Given a collection of objects and an integer n, cluster every n objects together.
Sample Input:  {0, 0, 0, 0, 0, 0, 0}; n = 3;
Sample Output:  {{0, 0, 0}, {0, 0, 0}, {0}}
************************************************************************/

var input = Enumerable.Repeat(0, 15).ToList();
var n = 5;

Enumerable.Range(0, input.Count / n).Select(i => input.Skip(n * i).Take(n)).Dump();