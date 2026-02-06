using System;

class Program
{
    public static void Main(string[] args)
    {
        //

        Cat nero = new Cat("nero", "black and white");
        Console.WriteLine("Cat {0} : {1}", nero.Name, nero.Color);

        //이름, 색 수정
        nero.Name = "Rui";
        nero.Color = "Beige";
        Console.WriteLine("Cat {0} : {1}", nero.Name, nero.Color);

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
    public string Name;
    public string Color;

    // 생성자 - 초기화 코드
    public Cat()
    {
        Name = "";
        Color = "";
    }

    public Cat(string name, string color)
    {
        Name = name;
        Color = color;
    }

    public void setName(string name)
    {
        Name = name;
    }

    public void setColor(string color)
    {
        Color = color;
    }


}