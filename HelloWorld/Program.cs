// See https://aka.ms/new-console-template for more information
using HelloWorld.data;
Console.WriteLine("Hello, World!");
KetNoi con = new KetNoi();
Console.WriteLine(con.ConString);
Console.WriteLine(con.TongHaiSo(1000,1000));
// con.TinhBinhPhuong(100);
KetNoi.TinhBinhPhuong(1000);
Console.WriteLine(KetNoi.FullName("Vu", "Chung"));
int b = 1000;
Console.WriteLine(KetNoi.check(ref b));
int c;
Console.WriteLine(KetNoi.checkout(out c));
