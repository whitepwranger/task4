// See https://aka.ms/new-console-template for more information


// Задача 25
int func1(int a, int b){
    int c = 1;
    for(int i = 0; i < b; i++){
        c = c * a;
    }
    Console.WriteLine(c);
    return 0;
}
// Задача 27
int func2(int a){
    int c = 0;
    int b = a / 10;
    c += (a % 10);
    while(b != 0){
        c += (b % 10);
        b = b / 10;
    }
    Console.WriteLine(c);
    return 0;
}
// Задача 29
int func3(int len_array){

    Console.WriteLine("Заполните массив цифрами:");
    int[] arr = new int[len_array];
    for(int i = 0; i < len_array; i++){
        arr[i] = int.Parse(Console.ReadLine());
    }
    Console.WriteLine("Ваш массив:");
    foreach(int i in arr){
        Console.Write(i.ToString() + ' ');
    }
    return 0;
}

func1(int.Parse(Console.ReadLine()),int.Parse(Console.ReadLine()));
func2(int.Parse(Console.ReadLine()));
func3(int.Parse(Console.ReadLine()));

