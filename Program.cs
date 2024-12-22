int monsterLife = 10;
int heroLife = 10;
do
{
    int heroAtack = new Random().Next(0,10);
    if (monsterLife > heroAtack)
    {
        monsterLife -= heroAtack;
        Console.WriteLine($"Monster was damaged and lost {heroAtack} health and now has {monsterLife} health");
    }else
    {
        monsterLife = 0;
        Console.WriteLine($"Monster was damaged and lost {heroAtack} health and now has {monsterLife} health");
        Console.WriteLine("Hero wins");
        break;
    }

    int monsterAtack = new Random().Next(0,10);
    if (heroLife > monsterAtack)
    {
        heroLife -= monsterAtack;
        Console.WriteLine($"Hero was damaged and lost {monsterAtack} health and now has {heroLife} health");
    }else
    {
        heroLife = 0;
        Console.WriteLine($"Hero was damaged and lost {monsterAtack} health and now has {heroLife} health");
        Console.WriteLine("Monster wins");
        break;
    }
}while (monsterLife > 0 && heroLife > 0);