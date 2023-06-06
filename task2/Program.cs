﻿void Task2(){
    

    Console.WriteLine("Введите  число");
    string input = Console.ReadLine();
    int num1 = Convert.ToInt32(input);
    int num2 = num1 % 10;

    if (input.Length > 2){
        Console.WriteLine(input[2]);

    } else{
         Console.WriteLine("третьей цифры нет");
       // Сonsole.WriteLine();
    }

   

}
Task2();
