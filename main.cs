using System;
using System.Collections.Generic;

class MainClass {
  public static void Main (string[] args){
    // foreach(User u in MyData.getUsers()){
    //   Console.WriteLine(u.ToString());
    // }
    // Console.WriteLine("\n");
    // foreach(Serie s in MyData.getSeries()){
    //   Console.WriteLine(s.ToString());
    // }
    // Console.WriteLine("\n");
    // foreach(Movie m in MyData.getMovies()){
    //   Console.WriteLine(m.ToString());
    // }
    while(true){
      int optionHome = Views.init();

      switch(optionHome){
        case 1:
          new Login();
          break;
        case 2:
          new RegisterUser();
          break;  
        default:
          Views.invalidOption(Strings.welcomeTitle);
          break;
      }
    }
  }
}