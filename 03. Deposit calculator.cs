double deposit_sum = double.Parse(Console.ReadLine());
int srok_deposit = int.Parse(Console.ReadLine());
double godishen_lihven_procent = double.Parse(Console.ReadLine()) / 100; 

double sum = deposit_sum + srok_deposit * ((deposit_sum * godishen_lihven_procent) / 12);

Console.WriteLine(sum);