namespace Lection3
{
    internal class Cat : Animal
    {
        public string Color { get; set; }

        public Cat(string name, int age, string color)
            : base(name, age)
        {
            Color = color;
        }

        public override void Say()
        {
            base.Say();
            Console.WriteLine("meow MEoOOooooooOOOOOOw GIVE ME LASAGNA!!!");
        }

        public override string ToString() 
            => base.ToString() + $" цвет: {Color}";
    }
}
