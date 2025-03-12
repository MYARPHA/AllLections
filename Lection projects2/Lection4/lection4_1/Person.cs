namespace lection4_1
{
    /* internal record Person
    {
        /*property
        public string Name { get; init; }

        //constructor
        public Person(string name) => Name = name;
    } */
    internal record Person(string Name, int Age);
}
