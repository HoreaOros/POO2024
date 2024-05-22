//MaxHeap mh = new MaxHeap(10);
var mh2 = new MaxHeap(new[] { 4, 1, 3, 2, 16, 9, 10, 14, 8, 7 });

//var mh3 = new MaxHeap(new[] { "f", "g", "a", "b", "t" , "c"});
Console.WriteLine(mh2);
//Console.WriteLine(mh3);

foreach (var item in mh2)
{
    Console.WriteLine(item);
}