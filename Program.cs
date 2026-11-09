Console.Write("Nama Pelanggaan: ");
String namaPelanggan = Console.ReadLine();

Console.Write("Nama dokumen: ");
String namaDokumen = Console.ReadLine();

Console.Write("Jumlah Halaman: ");
int jumlahHalaman = int.Parse(Console.ReadLine());

Console.Write("Harga Per Halaman: ");
int hargaPerHalaman = int.Parse(Console.ReadLine());

const int  biayaAdmin = 2000;

int subTotal = jumlahHalaman * hargaPerHalaman;
int totalBayar = subTotal + biayaAdmin;

Console.WriteLine();
Console.WriteLine("==== RINCIAN PENCETAKAN ==== ");
Console.WriteLine($"Nama Pelanggan: {namaPelanggan}");
Console.WriteLine($"Nama Dokumen: {namaDokumen}");
Console.WriteLine($"Jumlah Halaman: {jumlahHalaman}");
Console.WriteLine($"Harga Per Halaman: {hargaPerHalaman}");
Console.WriteLine($"Biaya Administrasi: {biayaAdmin}");
Console.WriteLine($"Sub Total: {subTotal}");
Console.WriteLine($"Total Bayar: {totalBayar}");
Console.WriteLine("TERIMAKASIH SUDAH BERBELANJA");
