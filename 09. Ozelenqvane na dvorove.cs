double one_kv_metur_dds = 7.61;
double procent_namalenie = 0.18;

double kv_metri_ozelenqvane = double.Parse(Console.ReadLine());

double kraina_cena_bez_otstupka = one_kv_metur_dds * kv_metri_ozelenqvane; //4185.50
double otstupka = kraina_cena_bez_otstupka * 0.82; // 753.39
double kraina_cena_otstupka = kraina_cena_bez_otstupka - otstupka; // 4185.50 - 753.39 = 3432.11

Console.WriteLine($"The discount is: {otstupka} lv.");
