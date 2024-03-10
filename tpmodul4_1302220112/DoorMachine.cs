using System;
using System.Security.Cryptography.X509Certificates;
public enum StatePintu { Terkunci, Terbuka };
public class DoorMachine
{	
	public DoorMachine()
	{
	}
	public void pintuTrigger(ref StatePintu currentState, string perintah)
	{
		switch (currentState)
		{
			case StatePintu.Terkunci:
				if (perintah == "Buka" || perintah == "buka")
				{
					currentState = StatePintu.Terbuka;
					Console.WriteLine("Pintu tidak terkunci");
				} else
				{
					Console.WriteLine("Pintu terkunci");
				}
				break;
			case StatePintu.Terbuka:
				if (perintah == "Kunci" || perintah == "kunci"){
					currentState = StatePintu.Terkunci;
					Console.WriteLine("Pintu terkunci");
				} else
				{
					Console.WriteLine("Pintu tidak terkunci");
				}
				break;
		}
	}
}
public class Proram
{
    public static void Main(string[] args)
	{
		StatePintu currentState = StatePintu.Terkunci;
		DoorMachine pintu = new DoorMachine();
		Console.WriteLine("Kondisi pintu sekarang: " + currentState);
		Console.Write("Masukkan Perintah: ");
		string perintah = Console.ReadLine();
		pintu.pintuTrigger(ref currentState, perintah);
        Console.WriteLine("============================");
        while (perintah != "exit")
		{
            Console.WriteLine("Kondisi pintu sekarang: " + currentState);
            Console.Write("Masukkan Perintah: ");
            perintah = Console.ReadLine();
            pintu.pintuTrigger(ref currentState, perintah);
			Console.WriteLine("============================");
        }
	}
}
	
