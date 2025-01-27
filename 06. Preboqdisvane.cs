double predpazen_nailon = 1.50;
double boq = 14.50;
double razreditel_za_boq = 5.00;
double procent_kolichestvo_boq = 0.10;
int kv_metra_nailon = 2;
double torbichki = 0.40;

int neobhodimo_kolichestvo_nailon = int.Parse(Console.ReadLine());
int neobhodimo_kolichestvo_boq = int.Parse(Console.ReadLine());
int kolichestvo_razreditel = int.Parse(Console.ReadLine());
int chasove_za_maistori_za_rabota = int.Parse(Console.ReadLine());

double suma_predpazen_nailon = (neobhodimo_kolichestvo_nailon + kv_metra_nailon) * predpazen_nailon;
double suma_boq = (neobhodimo_kolichestvo_boq * (1 + procent_kolichestvo_boq) * boq);
double suma_razreditel_boq = kolichestvo_razreditel * razreditel_za_boq;
double suma_materiali = suma_predpazen_nailon + suma_boq + suma_razreditel_boq + torbichki;
double obshta_suma_za_maistori = (suma_materiali * 0.30) * chasove_za_maistori_za_rabota;
double kraina_suma = suma_materiali + obshta_suma_za_maistori;

Console.WriteLine($"{kraina_suma}");
