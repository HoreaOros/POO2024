/*Stack<int> st =  new Stack<int>();
int n = 10;
for (int i = 0; i < n; i++)
    st.Push(i);

Console.WriteLine($"Elementul din varful stivei este: {st.Peek()}");

while (st.Count > 0)
{
    Console.WriteLine(st.Pop());
}
*/

MyStack<int> ms = new MyStack<int>();

ms.Push(5);
ms.Push(6);
ms.Push(7);

Console.WriteLine($"Elementul din varful stivei este: {ms.Peek()}");

while(ms.Count > 0)
{
    Console.WriteLine(ms.Pop());
}

// Adaug 100 de elemente in stiva
for (int i = 0; i < 100; i++)
    ms.Push(i);


try
{
	// Incerc sa elimin 101 elemente din stiva
	for (int i = 0; i <= 100; i++)
		Console.WriteLine(ms.Pop());
}
catch (StackEmptyException e)
{
    Console.WriteLine(e.Message);
}


MyStack<string> mss = new MyStack<string>();
mss.Push("hello");
mss.Push("world");

Console.WriteLine(mss.Pop());
Console.WriteLine(mss.Pop());


Console.ReadKey();