// Дан массив размера n, заполнить его случайными числами, Найти все нечётные числа массива.

int Message(string text) {
    Console.Write(text);
    int num = int.Parse(Console.ReadLine());
    return num;
}

int[] FillArray(int n){ // Заполнение массива случайными числами
    int[] arr = new int[n];
    for (int i = 0; i < arr.Length; i++)
    {
        Random rnd = new Random();
        arr[i] = rnd.Next(1,10);
    }
    return arr;
}

void GetArray(int[] arr) { // Вывод массива
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write(arr[i] + " ");
    }
}

int[] FindElements(int[] MyArr) { 
    int[] array  = Array.FindAll(MyArr, i => i % 2 != 0); // поиск группы элементов в массиве с условием, что они должны быть нечётными.
    return array;
}


int n = Message("Введите размер массива: ");
int[] MyArray = FillArray(n);
int[] resullt = FindElements(MyArray);
Console.Write("Массив: ");
GetArray(MyArray);
Console.WriteLine();
Console.Write("Нечётные элементы массива: ");
GetArray(resullt);