int broi_stranici_kniga = int.Parse(Console.ReadLine());
int broi_stranici_za_chas = int.Parse(Console.ReadLine());
int broi_dni_prochitane_cqlata_kniga = int.Parse(Console.ReadLine());

int obshto_vreme_za_knigata = broi_stranici_kniga / broi_stranici_za_chas;
int chasove_na_den = obshto_vreme_za_knigata / broi_dni_prochitane_cqlata_kniga;

Console.WriteLine(chasove_na_den);