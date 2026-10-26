int angka1;
int angka2;

    Console.Write("Masukkan angka pertama: ");
        angka1 = Convert.ToInt32(Console.ReadLine());

    Console.Write("Masukkan angka kedua: ");
        angka2 = Convert.ToInt32(Console.ReadLine());

int tambah = angka1 + angka2;
int kurang = angka1 - angka2;
int kali = angka1 * angka2;
int bagi = angka1 / angka2;
int sisa = angka1 % angka2;

    Console.WriteLine();
    Console.WriteLine($"Hasil Penjumlahan: {tambah}");
    Console.WriteLine($"Hasil Pengurangan: {kurang}");
    Console.WriteLine($"Hasil Perkalian: {kali}");
    Console.WriteLine($"Hasil Pembagian: {bagi}");
    Console.WriteLine($"Sisa Pembagian: {sisa}");
