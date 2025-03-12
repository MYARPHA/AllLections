class Person
{
    public string name;
    public int age;
    public const int AgeOfMajority = 18;

    public void Print() => Console.WriteLine($"Имя: {name}; Возраст: {age}");

    public int YearsUntillMajority() => AgeOfMajority - age;

    public Person() : this("Цырульник Антон Игоревич", 19)
    {
    }

    public Person(string name, int age)
    {
        this.name = name;
        this.age = age;
    }
}
