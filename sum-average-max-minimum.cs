// საერთო ჯამი.

int jami = 0;
while (index < x.Length)
{
    x[index] = Random.Shared.Next(100);
    jami += x[index];
    Console.WriteLine($"x[{index}] = {x[index]}, jami = {jami}");
    index++;
}


// საშუალო არითმეტიკული.

double jami = 0;
while (index < x.Length)
{
    x[index] = Random.Shared.Next(100);
    jami += x[index];
    index++;
}
double sashualo = jami / x.Length;
Console.WriteLine($"jami = {jami} sashualo = {sashualo}" + "0");

// მაქსიმალური რიცხვი.

int maximaluri = 0;
while (index < x.Length)
{
    x[index] = Random.Shared.Next(100);
    if (x[index] >= maximaluri)
    {
        maximaluri = x[index];
    }
    Console.WriteLine($"x[{index}] = {x[index]}");
    index++;
}

Console.WriteLine($"maximaluri = {maximaluri}");


// მინიმალური რიცხვი.

int minimum = 100;
while (index < x.Length)
{
    x[index] = Random.Shared.Next(100);
    if (x[index] < minimum)
    {
        minimum = x[index];
    }
    Console.WriteLine($"x[{index}] = {x[index]}");
    index++;
}

Console.WriteLine($"minimum = {minimum}");
