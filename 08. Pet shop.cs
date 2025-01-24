double dog_food = 2.50;
int cat_food = 4;

double dog_food_per_can = double.Parse(Console.ReadLine());
int cat_food_per_can = int.Parse(Console.ReadLine());

double kraina_suma = dog_food * dog_food_per_can + cat_food * cat_food_per_can;

Console.WriteLine($"{kraina_suma} lv.");