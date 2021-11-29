// See https://aka.ms/new-console-template for more information
using TestProject.Generator;
using TestProject.Printer;
using TestProject.Sort;

Console.WriteLine("Hello, World!");

var printer = new ConsolePrinter();
var linqSort = new TimerSortDecorator<LinqSort>(printer);
var bubbleSort = new TimerSortDecorator<BubbleSort>(printer);
var awesomeBubbleSort = new TimerSortDecorator<AwesomeBubbleSort>(printer);

var arrayGenerator = new IntArrayGenerator();
var ints = arrayGenerator.GenerateRandom(40);
var ints2 = arrayGenerator.GenerateReverse(40);

linqSort.Execute(ints);
bubbleSort.Execute(ints);
awesomeBubbleSort.Execute(ints);


linqSort.Execute(ints2);
bubbleSort.Execute(ints2);
awesomeBubbleSort.Execute(ints2);
