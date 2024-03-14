using System.Runtime.CompilerServices;

namespace Modul4_1302220088
{
    internal class Program
    {
        class Kodebuah
        {
            public enum getBuah
            {
                Apel, Aprikot, Alpukat, Pisang, Paprika, Blackberry, Ceri, Kelapa, Jagung
            }

            public static string getKodeBuah(getBuah inputan)
            {
                string[] kodebuah = { "A00", "B00", "C00", "D00", "E00", "F00", "H00", "I00", "J00" };
                return kodebuah[(int)inputan];
            }
        }



        public class PosisiKarakterGame
        {
            public enum Posisi { Berdiri, Jongkok, Tengkurap, Terbang };
            public enum Triger { TombolW, TombolX, TombolS };


            public class berubah
            {
                public Posisi stateAwal;
                public Posisi stateAkhir;
                public Triger triger;

                public berubah(Posisi stateAwal, Posisi stateAkhir, Triger triger)
                {
                    this.stateAwal = stateAwal;
                    this.triger = triger;
                    this.stateAkhir = stateAkhir;
                }
            }

            berubah[] transisi =
            {
                new berubah(Posisi.Terbang,Posisi.Jongkok, Triger.TombolX),
                new berubah(Posisi.Berdiri,Posisi.Terbang, Triger.TombolW),
            };

            public Posisi GetnextState(Posisi stateAwal, Triger triger)
            { 
               
                Posisi stateAkhir = stateAwal;
                for (int i = 0; i < transisi.Length; i++)
                {
                    berubah berubah = transisi[i];
                    if (stateAwal == berubah.stateAwal && triger == berubah.triger)
                    {
                        stateAkhir = berubah.stateAkhir;
                    }
                }
                return stateAkhir;
            }

            public Posisi currentState = Posisi.Terbang;

            public void TrigerAktif(Triger triger)
            {
                currentState = GetnextState(currentState, triger);
                
                if (currentState == Posisi.Terbang)
                {
                    Console.WriteLine("Posisi landing");
                } else if (currentState == Posisi.Berdiri)
                {
                    Console.WriteLine("Posisi take off");
                }
            }


            static void Main(string[] args)
            {
               // Console.WriteLine(Kodebuah.getKodeBuah(Kodebuah.getBuah.Apel));
                PosisiKarakterGame objGerak = new PosisiKarakterGame();
                objGerak.TrigerAktif(Triger.TombolX);
                objGerak.TrigerAktif(Triger.TombolW);
            }
        }
    }
}
