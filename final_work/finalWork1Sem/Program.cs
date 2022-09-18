/*Итоговая проверочная работа.
написать программу, которая из имеющегося массива строк формирует массив из строк,
длина которых меньше либо равна 3 символа. Первоначальный массив можно ввести с клавиатуры, 
либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, 
лучше обойтись исключительно массивами.*/

string [] array = {"hello", "2", "world", ";-)"};
//string [] array = {"1234", "1567", "-2", "computer science"};
//string [] array = {"Russia", "Denmark", "Kazan"};

int size = 0;
for (int i = 0; i < array.Length; i ++)
{
    if(array[i].Length <= 3) size++;
}

string [] newArray = new string [size];
int j = 0;
for (int i=0; i < array.Length; i++)
{
    if(array[i].Length <= 3)
    {
        newArray[j] = array[i];
        j++;
    }
}
