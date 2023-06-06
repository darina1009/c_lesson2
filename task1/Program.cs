﻿void Task1(){
    

    Console.WriteLine("Введите трехзначное число");
    int num1 = Convert.ToInt32(Console.ReadLine());

    if (num1 < 100 || num1 >= 1000){
        Console.WriteLine("Ввели не трехзначное число");
    }
    
    int num2 = num1 / 10 % 10;
    Console.WriteLine($"Вторая цифра {num2}");
}
Task1();
