Console.WriteLine("For Dögüsü Uygulamasına Hoşgeldiniz.");
Console.WriteLine("1 -> Kendime inanıyorum. :)");
Console.WriteLine("2 -> 1 ile 20 arasındaki sayılar.");
Console.WriteLine("3 -> 1 ile 20 arasındaki çift sayılar.");
Console.WriteLine("4 -> 50 ile 150 arasındaki sayıların toplamı.");
Console.WriteLine("5 -> 1 ie 120 arasındaki tek ve çift sayıların toplamı.");
void ILoveMe()
{
    for(int i = 0; i < 10; i++)
    Console.WriteLine("Kendime inanıyorum, ben bu yazılım işini hallederim!");
}
void Consecutive()
{
    Console.WriteLine("1 ile 20 arasındaki sayılar:");
    for(int i = 2; i<20; i++)
    {
        Console.WriteLine(i);
    }
}
void Twin()
{
    Console.WriteLine("1 ile 20 arasındaki çift sayılar:");
    for (int i = 2; i < 20; i=i+2)
    {
        Console.WriteLine(i);
    }
}

int Total()
{
    int total = 0;
    Console.WriteLine("50 ile 150 arasındaki sayıların toplamı:");
    for (int i=51; i<150; i++)
    {
        total = i + total;
    }
    return total;
}

void OddEven()
{
    int odd = 0;
    int even = 0;

    for (int i = 1; i < 120; i=i+2)    {
        odd = i + odd;
    }
    for (int i = 2; i < 120; i = i + 2)
    {
        even = i + even;
    }
    Console.WriteLine("1 ile 120 arasındaki tek sayıların toplamı:"+odd);
    Console.WriteLine("1 ile 120 arasındaki çift sayıların toplamı:" + even);
}

string input = Console.ReadLine();
switch (input)
{
    case "1":
        ILoveMe();
        break;
    case "2":
        Consecutive();
        break;
    case "3":
        Twin();
        break;
    case "4":
        int total = Total();
        Console.WriteLine(total);
        break;
    case "5":
        OddEven();
        break;


    default:
        Console.WriteLine("Patlama için geri sayım başladı...");
        break;
}