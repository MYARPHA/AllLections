namespace lection4_1
{
    [Flags]
    public enum Color
    {
        Black,       //0
        Red,         //1
        Yellow,      //2
        Blue = 4,    //4
        Green = Blue | Yellow,        //6
        White = Red | Yellow | Blue  //7
    }
}
