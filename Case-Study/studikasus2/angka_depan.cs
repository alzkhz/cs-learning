double angka;
double hitung1;
double hitung2;
double hitung3;

Console.Write("Masukkan angka desimal: ");
angka = Convert.ToDouble(Console.ReadLine());



hitung1 = angka - (angka % 1);   //angka depan 1
hitung2 = (int)angka;             //angka depan 2
hitung3 = Convert.ToInt32(angka); //pembulatan

Console.WriteLine("Angka depan: " + hitung1);
Console.WriteLine("Angka depan: " + hitung2);
Console.WriteLine("Angka bulat: " + hitung3);