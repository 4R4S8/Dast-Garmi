int x = 0;
int y = 0;
int e = 0;
Console.Write("Enter Your Goal Number: ");
int z = int.Parse(Console.ReadLine());
Console.Write("Enter The Limit of Numbers: ");
int w = int.Parse(Console.ReadLine());

for (int i = 0; i < w; i++)
{
    x++;
    for (int j = 0; j <= w; j++)
    {
        e = x * y;
        if (e == z)
        {
            Console.WriteLine("{0} * {1} = {2}", x, y, e);
        }
        y++;
    }
    y = 0;
}


