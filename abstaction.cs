using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
 // Compiler version 4.0, .NET Framework 4.5


 namespace AbstractClass
 {
   public class Program
   {
     public static void Main(string[] args)
     {
      
       
       Console.WriteLine();
       
       Console.WriteLine("==== Senjata ====");
       
       Console.WriteLine();
       
       Senjata senjata;
       
       senjata = new Pistol();
       senjata.jenis();
       senjata.peluru();
       senjata.caliber();
       
       Console.WriteLine();
       
       senjata = new Sniper();
       senjata.jenis();
       senjata.peluru();
       senjata.caliber();
       
       }
       
   
   // Abstract Class 
   public abstract class Senjata {
     public abstract void jenis();
     public abstract void peluru();
     public abstract void caliber();
   }
   
   public class Pistol : Senjata {
     public override void jenis() {
       Console.WriteLine("Type  : Desert Eagle ");
     }
     
     public override void peluru() {
       Console.WriteLine("Peluru : .357 magnum ");
     }
     
     public override void caliber() {
       Console.WriteLine("Caliber : 9 mm ");
     }
   }
   
   public class Sniper : Senjata {
     public override void jenis() {
       Console.WriteLine("Type : VSS Vintores ");
     }
     
     public override void peluru() {
       Console.WriteLine("Peluru : SP -5,SP-6 ");
     }
     
     public override void caliber() {
       Console.WriteLine("Caliber : 9x39 mm ");
     }
   }
 
   
   
   } 
   
 }
    