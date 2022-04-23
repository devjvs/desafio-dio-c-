using System;
using DOTNET___POO.src.Entities;

namespace DOTNET___POO{
    class Program {
        static void Main(String[] args){

            Knight arus = new Knight("Arus", 42, "Knight");
            Ninja wedge = new Ninja("Wedge", 42, "Ninja");
            Wizard wizard = new Wizard("Jennica", 23, "White Wizard");
            BlackWizard topapa = new BlackWizard("Topapa", 42, "Black Wizard");
            
            Console.WriteLine(arus.Attack());
            Console.WriteLine(wedge.Attack());
            Console.WriteLine(wizard.Attack(7));
            Console.WriteLine(topapa.Attack(1));
        }
    }
}