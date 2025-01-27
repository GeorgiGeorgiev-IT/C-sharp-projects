int duljina_cm = int.Parse(Console.ReadLine());
int shirochina_cm = int.Parse(Console.ReadLine());
int visochina_cm = int.Parse(Console.ReadLine());
double procent = double.Parse(Console.ReadLine()) / 100;

double obem_akvarium = duljina_cm * shirochina_cm * visochina_cm;

double obem_litri = obem_akvarium * 0.001; // 1000
double nujni_litri = obem_litri * (1 - procent);
// double nujnu_litri = obem_litri * procent;
// double nujni_litri_krai = obem_litri - nujnu_litri;
Console.WriteLine(nujni_litri);