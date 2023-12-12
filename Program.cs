//1----------------------------------------------------------------------------------------------------------------------------------------------------
//using System;

//class SymbolClass
//{
//    private char symbol;

//    public SymbolClass(char symbol)
//    {
//        this.symbol = symbol;
//    }

//    public static SymbolClass operator ++(SymbolClass obj)
//    {
//        obj.symbol = (char)(obj.symbol + 1);
//        return obj;
//    }

//    public static SymbolClass operator --(SymbolClass obj)
//    {
//        obj.symbol = (char)(obj.symbol - 1);
//        return obj;
//    }

//    public static SymbolClass operator +(SymbolClass obj, int number)
//    {
//        return new SymbolClass((char)(obj.symbol + number));
//    }

//    public static SymbolClass operator +(int number, SymbolClass obj)
//    {
//        return new SymbolClass((char)(number + obj.symbol));
//    }

//    public static int operator -(SymbolClass obj1, SymbolClass obj2)
//    {
//        return obj1.symbol - obj2.symbol;
//    }

//    public override string ToString()
//    {
//        return symbol.ToString();
//    }
//}

//class Program
//{
//    static void Main()
//    {
//        SymbolClass obj1 = new SymbolClass('a');
//        SymbolClass obj2 = new SymbolClass('b');

//        Console.WriteLine(obj1); // Выводит символ 'a'
//        Console.WriteLine(obj2); // Выводит символ 'b'

//        obj1++; // Инкрементируем obj1
//        obj2--; // Декрементируем obj2

//        Console.WriteLine(obj1); // Выводит символ 'b'
//        Console.WriteLine(obj2); // Выводит символ 'a'

//        SymbolClass obj3 = obj1 + 1; // Суммируем obj1 и число 1
//        SymbolClass obj4 = 2 + obj2; // Суммируем число 2 и obj2

//        Console.WriteLine(obj3); // Выводит символ 'c'
//        Console.WriteLine(obj4); // Выводит символ 'c'

//        int diff = obj3 - obj4; // Вычисляем разность obj3 и obj4

//        Console.WriteLine(diff); // Выводит значение -1
//    }
//}
//2----------------------------------------------------------------------------------------------------------------------------------------------------
//using System;

//namespace Test
//{
//    class MyClass
//    {
//        int[] arr;
//        public int number;

//        public MyClass(int count)
//        {
//            arr = new int[count];
//            FillArray();
//            number = 0;
//        }

//        private void FillArray()
//        {
//            for (int i = 0; i < arr.Length; i++)
//                arr[i] = 0;
//        }

//        public void PrintArray()
//        {
//            for (int i = 0; i < arr.Length; i++)
//                Console.Write(arr[i].ToString());
//            Console.WriteLine();
//        }

//        public void PrintNumber()
//        {
//            Console.WriteLine($"Значение number равно {number}");
//        }
//        public static MyClass operator --(MyClass myClass)
//        {
//            int[] arrNew = new int[myClass.arr.Length - 1];
//            for (int i = 0; i < arrNew.Length; i++)
//                arrNew[i] = myClass.arr[i];
//            myClass.arr = arrNew;
//            return myClass;
//        }
//        public static MyClass operator +(MyClass current, MyClass other)
//        {
//            current.number += other.number;
//            return current;
//        }
//        public static MyClass operator +(MyClass myClass, int otherNumber)
//        {
//            myClass.number += otherNumber;
//            return myClass;
//        }

//    }

//    class Program
//    {
//        static void Main(string[] args)
//        {
//            MyClass myClass = new MyClass(5);
//            myClass.PrintArray();
//            myClass--;
//            myClass.PrintArray();
//            MyClass myClassTwo = new MyClass(1);
//            myClass.number = 10;
//            myClassTwo.number = 5;
//            myClass.PrintNumber();
//            myClass = myClass + myClassTwo;
//            myClass.PrintNumber();
//            myClass = myClass + 100;
//            myClass.PrintNumber();
//            Console.ReadKey();
//        }
//    }
//}
//3----------------------------------------------------------------------------------------------------------------------------------------------------
//using System;

//class MyClass
//{
//    private int field1;
//    private int field2;

//    public MyClass(int value1, int value2)
//    {
//        field1 = value1;
//        field2 = value2;
//    }

//    public static bool operator >(MyClass obj1, MyClass obj2)
//    {
//        int sum1 = obj1.field1 * obj1.field1 + obj1.field2 * obj1.field2;
//        int sum2 = obj2.field1 * obj2.field1 + obj2.field2 * obj2.field2;

//        return sum1 > sum2;
//    }

//    public static bool operator <(MyClass obj1, MyClass obj2)
//    {
//        int sum1 = obj1.field1 * obj1.field1 + obj1.field2 * obj1.field2;
//        int sum2 = obj2.field1 * obj2.field1 + obj2.field2 * obj2.field2;

//        return sum1 < sum2;
//    }

//    public override string ToString()
//    {
//        return $"Field1: {field1}, Field2: {field2}";
//    }
//}

//class Program
//{
//    static void Main()
//    {
//        MyClass obj1 = new MyClass(2, 3);
//        MyClass obj2 = new MyClass(4, 5);

//        Console.WriteLine(obj1); // Выводит "Field1: 2, Field2: 3"
//        Console.WriteLine(obj2); // Выводит "Field1: 4, Field2: 5"

//        Console.WriteLine(obj1 > obj2); // Выводит "False"
//        Console.WriteLine(obj1 < obj2); // Выводит "True"
//    }
//}
//4----------------------------------------------------------------------------------------------------------------------------------------------------
//using System;
//class MyClass
//{
//    public int intValue;
//    public string stringValue;
//    public static bool operator >(MyClass a, MyClass b)
//    {
//        return a.stringValue.Length > b.stringValue.Length;
//    }
//    public static bool operator <(MyClass a, MyClass b)
//    {
//        return a.stringValue.Length < b.stringValue.Length;
//    }
//    public static bool operator >=(MyClass a, MyClass b)
//    {
//        return a.intValue >= b.intValue;
//    }
//    public static bool operator <=(MyClass a, MyClass b)
//    {
//        return a.intValue <= b.intValue;
//    }
//    public static bool operator ==(MyClass a, MyClass b)
//    {
//        return a.intValue == b.intValue && a.stringValue == b.stringValue;
//    }
//    public static bool operator !=(MyClass a, MyClass b)
//    {
//        return a.intValue != b.intValue || a.stringValue != b.stringValue;
//    }
//    public override bool Equals(object obj)
//    {
//        if (obj == null || GetType() != obj.GetType())
//            return false;

//        MyClass other = (MyClass)obj;
//        return (intValue == other.intValue) && (stringValue == other.stringValue);
//    }
//    public override int GetHashCode()
//    {
//        return intValue.GetHashCode() ^ stringValue.GetHashCode();
//    }
//}
//class Program
//{
//    static void Main()
//    {
//        MyClass obj1 = new MyClass() { intValue = 5, stringValue = "Hello" };
//        MyClass obj2 = new MyClass() { intValue = 3, stringValue = "World" };
//        Console.WriteLine(obj1 > obj2);
//        Console.WriteLine(obj1 <= obj2);
//        Console.WriteLine(obj1 == obj2);
//        Console.WriteLine(obj1.Equals(obj2));
//    }
//}
//5----------------------------------------------------------------------------------------------------------------------------------------------------
//using System;

//public class MyClass
//{
//    private int integerValue;
//    private char charValue;

//    public int IntegerValue
//    {
//        get { return integerValue; }
//        set { integerValue = value; }
//    }

//    public char CharValue
//    {
//        get { return charValue; }
//        set { charValue = value; }
//    }

//    // Перегрузка оператора true
//    public static bool operator true(MyClass obj)
//    {
//        int diff = Math.Abs(obj.IntegerValue - (int)obj.CharValue);
//        return diff <= 10;
//    }

//    // Перегрузка оператора false
//    public static bool operator false(MyClass obj)
//    {
//        int diff = Math.Abs(obj.IntegerValue - (int)obj.CharValue);
//        return diff > 10;
//    }

//    // Оператор явного преобразования класса MyClass к типу string
//    public static explicit operator string(MyClass obj)
//    {
//        return obj.CharValue.ToString();
//    }
//}

//class Program
//{
//    static void Main(string[] args)
//    {
//        MyClass obj = new MyClass();
//        obj.IntegerValue = 65;
//        obj.CharValue = 'A';

//        if (obj)
//        {
//            string sequence = (string)obj;
//            Console.WriteLine(sequence);
//        }
//    }
//}
//6----------------------------------------------------------------------------------------------------------------------------------------------------
//using System;

//class MyNumber
//{
//    private int value;
//    public MyNumber(int val)
//    {
//        value = val;
//    }
//    public static bool operator &(MyNumber a, MyNumber b)
//    {
//        return (a.value == 2 || a.value == 3 || a.value == 5 || a.value == 7) &&
//        (b.value == 2 || b.value == 3 || b.value == 5 || b.value == 7);
//    }
//    public static bool operator |(MyNumber a, MyNumber b)
//    {
//        return (a.value == 2 || a.value == 3 || a.value == 5 || a.value == 7) &&
//        (b.value == 2 || b.value == 3 || b.value == 5 || b.value == 7);
//    }
//    public static bool operator true(MyNumber a)
//    {
//        return (a.value == 2 || a.value == 3 || a.value == 5 || a.value == 7);
//    }
//    public static bool operator false(MyNumber a)
//    {
//        return (a.value < 1 || a.value > 10);
//    }
//}
//class Program
//{
//    static void Main()
//    {
//        MyNumber num1 = new MyNumber(3);
//        MyNumber num2 = new MyNumber(8);
//        Console.WriteLine(num1 || num2);
//        Console.WriteLine(num1 || num2);
//    }
//}
//6.2--------------------------------------------------------------------------------------------------------------------------------------------------
//using System;

//class Program
//{
//    static void Main()
//    {
//        MyClass obj1 = new MyClass(3);
//        MyClass obj2 = new MyClass(6);
//        if (obj1 && obj2)
//        {
//            Console.WriteLine("Оба объекта истинны");
//            Console.ReadLine();
//        }

//        if (obj1 || obj2)
//        {
//            Console.WriteLine("Хотя бы один объект истинный");
//            Console.ReadLine();
//        }

//        if (obj1)
//        {
//            Console.WriteLine("obj1 истинный");
//            Console.ReadLine();
//        }

//        if (obj2)
//        {
//            Console.WriteLine("obj2 ложный");
//            Console.ReadLine();
//        }
//    }

//}
//class MyClass
//{
//    public int code;
//    public MyClass(int value)
//    {
//        code = value;
//    }

//    public static MyClass operator &(MyClass a, MyClass b)
//    {
//        if (a)
//        {
//            return b;
//        }
//        else
//        {
//            return a;
//        }
//    }

//    public static MyClass operator |(MyClass a, MyClass b)
//    {
//        if (a)
//        {
//            return a;
//        }
//        else
//        {
//            return b;
//        }
//    }

//    public static bool operator true(MyClass a)
//    {
//        switch (a.code)
//        {
//            case 2:
//            case 3:
//            case 5:
//            case 7:
//                return true;
//            default:
//                return false;
//        }
//    }

//    public static bool operator false(MyClass a)
//    {
//        return a.code < 1;
//        return a.code > 10;
//    }
//}