Rational r1 = new Rational(); // ???
Rational r2 = new Rational(3, 4);
Rational r3 = new Rational("2/3");
Rational r33 = new Rational("2");
Rational r4 = new Rational(5); // 5/1


Console.WriteLine(r3);
// Adunare
Rational r5 = r2.Add(r3);
Rational r6 = r2 + r3; // operator overloading


// Scadere

// Inmultire

// Impartire

// Ridicare la putere
Rational r7 = r2.Power(7);
r7 = r2 ^ 7;

// Aducere la forma ireductibila
r7.Ireductibil();


// Operatii de egalitate, comparare
bool b1 = r2 == r3;
bool b2 = r2 != r3;
bool b3 = r2 < r3;
bool b4 = r2 <= r3;

