using System;

class Program
{
    public static void Main(string[] args)
    {
        //

        Cat nero = new Cat("nero", "black and white");
        Console.WriteLine("Cat {0} : {1}", nero.Name, nero.Color);

        //이름, 색 수정

        Cat meow = new Cat("Coco", "Black");
        Console.WriteLine("Cat {0} : {1}", meow.Name, meow.Color);

        meow.setName("하늘이");
        meow.setColor("갈색");
        Console.WriteLine("Cat {0} : {1}", meow.Name, meow.Color);
    }
}

class Cat
{
    // 필드 선언
    protected string _Name;
    protected string _Color;

    // 생성자 - 초기화 코드
    public Cat()
    {
        _Name = "";
        _Color = "";
    }

    public Cat(string name, string color)
    {
        _Name = name;
        _Color = color;
    }

    public void setName(string name)
    {
        _Name = name;
    }

    public void setColor(string color)
    {
        _Color = color;
    }

    public string Name => _Name;
    public string Color => _Color;
}