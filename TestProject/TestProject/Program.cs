// See https://aka.ms/new-console-template for more information
using TestProject.Printer;
using TestProject.Sort;

Console.WriteLine("Hello, World!");

var printer = new ConsolePrinter();
var linqSort = new TimerSortDecorator(new LinqSort(), printer);
var bubbleSort = new TimerSortDecorator(new BubbleSort(), printer);
var awesomeBubbleSort = new TimerSortDecorator(new AwesomeBubbleSort(), printer);

Random randNum = new Random();
var ints = Enumerable
    .Repeat(0, 40)
    .Select(i => randNum.Next(-40, 40))
    .ToArray();

var ints2 = Enumerable.Range(0, 40).Reverse().ToArray();

linqSort.Execute(ints);
bubbleSort.Execute(ints);
awesomeBubbleSort.Execute(ints);


linqSort.Execute(ints2);
bubbleSort.Execute(ints2);
awesomeBubbleSort.Execute(ints2);
