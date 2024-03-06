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

MyStack ms = new MyStack();

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


// Incerc sa elimin 101 elemente din stiva
for(int i = 0; i <= 100; i++)
    Console.WriteLine(ms.Pop());
Console.ReadKey();

