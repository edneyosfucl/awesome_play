using System;
using System.Diagnostics;
using System.IO;
using System.Threading.Tasks;
using System.Collections.Generic;

public static class Utils{

  //Exibe o titulo do app
  public static void showAppTitle(){
    Console.WriteLine("==================== Awesome Play ====================");
  }

  //Exibe o rodapé do app
  public static void showFooter(){
    Console.WriteLine("======================================================");
    Console.WriteLine("\n");
  }

  //Pausa o console
  public static void sleep(int second){
    System.Threading.Thread.Sleep(second * 1000);
  }

  //Oculta os caracteres digitados substituindo por '*'
  public static string passwordConsole(){    
    string pass = "";
    
    do{ 
      ConsoleKeyInfo key = Console.ReadKey(true);

      if (key.Key != ConsoleKey.Backspace && key.Key != ConsoleKey.Enter){
        pass += key.KeyChar;
        Console.Write("*");
      }
      else{
        if (key.Key == ConsoleKey.Backspace && pass.Length > 0){
          pass = pass.Substring(0, (pass.Length - 1));
          Console.Write("\b \b");
        }
        else if(key.Key == ConsoleKey.Enter){
          break;
        }
      }
    } while (true);

    return pass;
  }
}