using System;
using static KodePos;

public class KodePos
{
    public string[] kelurahan = { "Batununggal", "Kujangsari", "Mengger", "Wates", 
        "Cijaura", "Jatisari", "Margasari", "Sekejati", "Kebonwaru", "Maleer", "Samoja" };
    public int[] kodePos = { 40266, 40287, 40267, 40256, 40287, 40286, 40286, 40286, 40272, 40274, 40273 };
    public int getKodePos(int i)
    {
        return kodePos[i];
    }
}

public class Program
{
    public static void Main(String[] args)
    {
        KodePos kodePos = new KodePos();
        for (int i = 0; i < kodePos.kelurahan.Length; i++)
        {
            Console.WriteLine("Kode Pos Kelurahan " + kodePos.kelurahan[i] + ": " + kodePos.getKodePos(i));
        }
    }
}