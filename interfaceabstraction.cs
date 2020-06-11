using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
 // Compiler version 4.0, .NET Framework 4.5


 namespace Dcoder
 {
   public class Program
   {
     public static void Main(string[] args)
     {
       Console.WriteLine();
       
       Console.WriteLine("==== Senjata ====");
       
       Console.WriteLine();
       
       ISenjata senjata;
       
       senjata = new pistol();
       senjata.jenis();
       senjata.peluru();
       senjata.caliber();
       
       Console.WriteLine();
       
       senjata = new sniper();
       senjata.jenis();
       senjata.peluru();
       senjata.caliber();
     }
     
     
     public interface ISenjata{
     void jenis();
     void peluru();
     void caliber();
   }
   
  public class pistol : ISenjata {
     public void jenis() {
       Console.WriteLine("Type : HK USP P9 ");
     }
   
     public void peluru() {
       Console.WriteLine("Peluru : 9x19 mm para");
     }
     public void caliber() {
       Console.WriteLine("Caliber : 9 mm");
     }
     
   } 
   
   
   public class sniper : ISenjata {
     public void jenis() {
       Console.WriteLine("Type : Barret M82A1");
     }
     public void peluru() {
       Console.WriteLine("Peluru : 12.7x99 mm(.50 BMG)");
     }
     public void caliber() {
       Console.WriteLine("Caliber : 12.7-mm");
     }
     
   }
   
 }
}