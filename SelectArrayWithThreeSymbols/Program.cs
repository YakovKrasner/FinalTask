string [] PrimaryArray = {"Hola, muchachos!","Feci quod potui, faciant meliora potentes!",":)","Yes"};
int MaxStringLength = 3; // Указываем максимальное количество знаков, при котором мы будем включаь элемент исходного массива в новый массив
int DerivateArrayElements = 0; // Вводим счетчик для количества элементов, содержащих MaxStringLength символов или менее.
for (int i = 0; i < PrimaryArray.Length; i++) 
    {
        if (PrimaryArray[i].Length<=MaxStringLength) DerivateArrayElements ++;
    }
string [] DerivateArray = new string [DerivateArrayElements];

int j = 0;
for (int i = 0; i < PrimaryArray.Length; i++) 
    {
        if (PrimaryArray[i].Length<=MaxStringLength) 
                {
                    DerivateArray [j] = PrimaryArray [i];
                    j ++;
                }
    }
for (int i = 0; i < DerivateArray.Length; i++) Console.WriteLine (DerivateArray[i]);
