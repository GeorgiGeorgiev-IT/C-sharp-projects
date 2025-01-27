int godishna_taksa_za_trenirovki = int.Parse(Console.ReadLine());

double procent_basketbolni_kecove = 0.60;
double procent_basketbolen_ekip = 0.80;

double basketbolni_kecove = godishna_taksa_za_trenirovki * procent_basketbolni_kecove;
double basketbolen_ekip = basketbolni_kecove * procent_basketbolen_ekip;
double basketbolna_topka = basketbolen_ekip * 1.0 / 4.0;
double basketbolni_aksesoari = basketbolna_topka * 1.0 / 5.0;

double obshta_suma = godishna_taksa_za_trenirovki + basketbolni_kecove + basketbolen_ekip + basketbolna_topka + basketbolni_aksesoari;

Console.WriteLine(obshta_suma);

