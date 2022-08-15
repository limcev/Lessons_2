// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели,
// и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет


Console.WriteLine("Введите цифру дня недели "); 
int number1 = Convert.ToInt32(Console.ReadLine());
if(number1 >= 1 & number1 <= 7)
{  
   if (number1 == 6 | number1 == 7){
    Console.WriteLine("Да");
   } 
   else
   {
    Console.WriteLine("Нет");
   }
}
else
{
    Console.WriteLine("Нет такого дня недели.");
}  
