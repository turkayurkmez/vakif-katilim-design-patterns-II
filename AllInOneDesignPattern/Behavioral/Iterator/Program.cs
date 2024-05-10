// See https://aka.ms/new-console-template for more information

using Iterator;

Iterator.Iterator iterator = new Iterator.Iterator();

iterator.Add("A");
iterator.Add("B");
iterator.Add("C");

var first = iterator.First();
Console.WriteLine($" first value: {first}");

if (iterator.MoveNext())
{
    Console.WriteLine($" current value: {iterator.Current}");
}

var nextOne = iterator.Next();
Console.WriteLine($" next value: {nextOne}");
Console.WriteLine($" current value: {iterator.Current}");



