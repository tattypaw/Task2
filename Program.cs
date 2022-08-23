// Задача 10: Напишите программу, которая принимает на вход трёхзначное число 
//и на выходе показывает вторую цифру этого числа.

int Cut2Number(int number){
    int result = (number % 100) / 10;
    return result;
}

Console.Write("введите трехзначное число: ");
int number = Convert.ToInt32(Console.ReadLine());
int positive = Math.Abs(number);
if(positive>99 & positive<1000){
    Console.WriteLine("вторая цифра числа =  " + Cut2Number(positive));
}
else{
    Console.WriteLine("Число нетрехзначное");
}


//Напишите программу, которая выводит третью цифру заданного числа 
//или сообщает, что третьей цифры нет.
/*
int Number3(int number){
    //отбрасываем знак числа, если число отрицательное
    int positive = Math.Abs(number);
    //конвертируем в строку и вычисляем разряд числа
    double n = Convert.ToString(positive).Length;
    int result = Convert.ToInt32(positive/Math.Pow(10, n-3))%10;
    return result;
}

Console.Write("введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
if((number>99) || (number<-99)){
    Console.WriteLine("Третья цифра числа =  " + Number3(number));
}
else{
    Console.WriteLine("В числе меньше трех цифр, третьей цифры нет");
}
*/

//Напишите программу, которая принимает на вход цифру, обозначающую день недели, 
//и проверяет, является ли этот день выходным.
/*
void RestDay(int number){
    if ((number < 8) & (number > 5)){
       Console.WriteLine("Выходной!"); 
    }
    else if ((number < 6) & (number > 0)){
       Console.WriteLine("Рабочий."); 
    }
    else{
       Console.WriteLine("Такого дня недели нет"); 
    }
    
}

Console.Write("введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
RestDay(number);
*/