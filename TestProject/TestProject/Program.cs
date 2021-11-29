// See https://aka.ms/new-console-template for more information
using TestProject.Generator;
using TestProject.Printer;
using TestProject.Sort;

Console.WriteLine("Hello, World!");

var printer = new ConsolePrinter();
var linqSort = new TimerSortDecorator<LinqSort>(printer);
var bubbleSort = new TimerSortDecorator<BubbleSort>(printer);
var awesomeBubbleSort = new TimerSortDecorator<AwesomeBubbleSort>(printer);

var arrayGenerator = new StringArrayGenerator();
var arrayRandom = arrayGenerator.GenerateRandom(40);
var arrayReverse = arrayGenerator.GenerateReverse(40);

linqSort.Execute(arrayRandom);
bubbleSort.Execute(arrayRandom);
awesomeBubbleSort.Execute(arrayRandom);


linqSort.Execute(arrayReverse);
bubbleSort.Execute(arrayReverse);
awesomeBubbleSort.Execute(arrayReverse);
