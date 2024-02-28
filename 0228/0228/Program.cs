Rational r1 = new Rational(); // ???
Console.WriteLine(r1);

Rational r2 = new Rational(3, 4);
Console.WriteLine(r2);


Rational r3 = new Rational("2/3");
Console.WriteLine(r3);


Rational r33 = new Rational("2");
Console.WriteLine(r33);


Rational r4 = new Rational(5); // 5/1
Console.WriteLine(r4);
// Adunare
Rational r5 = r2.Add(r3);
Console.WriteLine(r5);
Rational r6 = r2 + r3; // operator overloading
Console.WriteLine(r6);


// Scadere

// Inmultire

// Impartire

// Ridicare la putere
Rational r7 = r2.Power(7);
r7 = r2 ^ 7;

// Aducere la forma ireductibila
r7.Ireductibil();
Console.WriteLine(r7);


// Operatii de egalitate, comparare
bool b1 = r2 == r3;
Console.WriteLine($"{r2} == {r3} -> {b1}");
bool b2 = r2 != r3;
Console.WriteLine($"{r2} != {r3} -> {b2}");

bool b3 = r2 < r3;
Console.WriteLine($"{r2} < {r3} -> {b3}");

bool b4 = r2 <= r3;
Console.WriteLine($"{r2} <= {r3} -> {b4}");


