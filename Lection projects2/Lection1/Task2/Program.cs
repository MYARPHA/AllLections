double radius = 5;
double perimeter = 2 * Math.PI * radius;
Console.WriteLine(perimeter);

Person alina = new Person();
string personName = alina.name;
int personAge = alina.age;
alina.name = "Алина";
alina.age = 18;
alina.Print();
Console.WriteLine(alina.YearsUntillMajority());