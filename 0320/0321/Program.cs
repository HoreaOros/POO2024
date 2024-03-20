// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");


 
World w = World.Instance;
w.SayHello();



World2 pw = new World2();
pw.SayHello();

World2 pw2 = new World2();
pw2.SayHello();

pw.SendMessage(pw2, ".-- --- .-. .-.. -..");
pw.SendMessage(pw2, "... --- ...");

pw2.DisplayAllMessages();


