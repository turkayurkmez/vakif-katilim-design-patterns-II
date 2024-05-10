// See https://aka.ms/new-console-template for more information
using Strategy;

Console.WriteLine("Hello, World!");


CustomCollection customCollection = new CustomCollection();
customCollection.Sort(new BubbleStrategy());

customCollection.Sort(new HeapStrategy());  

