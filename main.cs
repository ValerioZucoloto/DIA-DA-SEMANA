using System;

class MainClass {
  public static void Main (string[] args) {
    int x;
    string dia;

    Console.WriteLine ("Informe um número de 1 à 4: ");
    x = int.Parse (Console.ReadLine());

    switch (x) {
      case 1 : 
        dia = "domingo";
        break;
      case 2:
        dia = "Segunda";
        break;
      case 3:
        dia = "Terça";
      break;
      case 4:
        dia = "Quarta";
      break;
      default:
        dia = "Valor inválido";
        break;
    }

    Console.WriteLine ("Dia da semana: " + dia);
  }
}