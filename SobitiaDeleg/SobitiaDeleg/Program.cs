using System;

namespace SobitiaDeleg
{
    delegate void MyDel();

    class Program
    {
        static void Main(string[] args)
        {
            //Создаем объект класса MyClass  
            MyClass myClass = new MyClass("Первое имя");
            //Подписываемся на событие MyEvent  
            myClass.MyEvent += new MyDel(Handler);

            //Изменяем поле name  
            myClass.ChangeName("Новое имя");
        }
        static void Handler()
        {
            Console.WriteLine("Имя изменилось!");
            Console.ReadKey();
        }
    }
    

}
