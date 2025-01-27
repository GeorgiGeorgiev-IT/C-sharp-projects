double paket_himikali = 5.80;
double paket_markeri = 7.20;
double preparat = 1.20;

int broi_paketi_himikali = int.Parse(Console.ReadLine());
int broi_paket_markeri = int.Parse(Console.ReadLine());
int litri_preparat = int.Parse(Console.ReadLine());
int procent_namalenie = int.Parse(Console.ReadLine());

double suma_bez_otstupka = paket_himikali * broi_paketi_himikali + paket_markeri * broi_paket_markeri + preparat * litri_preparat;
double otstupka = (suma_bez_otstupka * procent_namalenie) / 100.0; 
double cqla_suma_s_otstupka = suma_bez_otstupka - otstupka;

Console.WriteLine(cqla_suma_s_otstupka);