double pileshko_menu = 10.35;
double ribeshko_menu = 12.40;
double vegetariansko_menu = 8.15;

double dostavka = 2.50;

int broi_pileshki_menuta = int.Parse(Console.ReadLine());
int broi_ribeski_menuta = int.Parse(Console.ReadLine());
int broi_vegetarianski_menuta = int.Parse(Console.ReadLine());

double obshta_suma = broi_pileshki_menuta * pileshko_menu + broi_ribeski_menuta * ribeshko_menu + broi_vegetarianski_menuta * vegetariansko_menu;
double desert = obshta_suma * 0.20;
double kraina_cena = obshta_suma + dostavka + desert;

Console.WriteLine(kraina_cena);
