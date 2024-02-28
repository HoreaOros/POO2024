Fractie f1 = new Fractie();
Console.WriteLine(f1);

Fractie f2 = new Fractie(2, 3);
Console.WriteLine(f2);

Fractie f3 = new Fractie(5);
Console.WriteLine(f3);



Fractie f4 = f2.Add(f3);
Console.WriteLine(f4);

Fractie f5 = f2 + f3;
Console.WriteLine(f5);


Fractie f6 = new Fractie("5 / 9");
Console.WriteLine(f6);

Fractie f7 = new Fractie("7");
Console.WriteLine(f7);

// TODO
// Scadere

// Inmultire

// Impartire

// Ridicare la putere
Fractie f8 = f6.Power(3);
Console.WriteLine(f8);

Fractie f9 = f6 ^ 3;
Console.WriteLine(f9);


int a = 1, b = 1;

f2 = new Fractie(2, 3);
f3 = new Fractie(2, 3);


// Operatii de egalitate, inegalitate, relationali
bool b1 = f2 == f3;
Console.WriteLine($"{f2} == {f3} -> {b1}");
bool b2 = f2 != f3;
Console.WriteLine($"{f2} != {f3} -> {b2}");

//bool b3 = f2 < f3;
//Console.WriteLine($"{f2} < {f3} -> {b3}");

//bool b4 = f2 <= f3;
//Console.WriteLine($"{f2} <= {f3} -> {b4}");
