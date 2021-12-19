using System;
using System.Collections.Generic;
using System.Text;

namespace SobitiaDeleg
{
    class MyClass
    {
        //поле  
        string name;

        //событие  
        public event MyDel MyEvent;

        //конструктор  
        public MyClass(string name)
        {
            this.name = name;
        }

        //метод для редактирования поля name  
        public void ChangeName(string name)
        {
            this.name = name;
            //генерирование события  
            if (MyEvent != null)
                MyEvent();
        }
    }
}

