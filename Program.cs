namespace Modul4_1302220088
{
    internal class Program
    {
        class Kodebuah
        {
            public enum getBuah
            {
                Apel,Aprikot,Alpukat,Pisang,Paprika,Blackberry,Ceri,Kelapa,Jagung
            }

            public static string getKodeBuah(getBuah inputan)
            {
                string[] kodebuah = {"A00", "B00", "C00", "D00", "E00", "F00", "H00", "I00", "J00" };
                return kodebuah[(int)inputan];
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine(Kodebuah.getKodeBuah(Kodebuah.getBuah.Apel));
        }
    }
}
