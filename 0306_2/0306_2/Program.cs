﻿// 1. Utilizarea clasei Stack din biblioteca .NET
/*Stack<int> stack = new Stack<int>();
for (int i = 0; i < 10; i++)
    stack.Push(i);
Console.WriteLine($"Numarul de elemente din stiva este: {stack.Count}");

while(stack.Count > 0)
{
    Console.WriteLine($"{stack.Pop()}");
}

stack.Pop();
*/


MyStack<int> mystack = new MyStack<int>();

for (int i = 0; i < 100; i++)
    mystack.Push(i);

Console.WriteLine($"Elementul din varful stivei este: {mystack.Peek()}");

while(mystack.Count > 0)
{
    Console.WriteLine(mystack.Pop());
}

try
{
	mystack.Pop();
}
catch (StackEmptyException e)
{
    Console.WriteLine(e.Message);
}


MyStack<string> ss = new MyStack<string>();
ss.Push("hello");
ss.Push("world");