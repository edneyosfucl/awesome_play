using System;
using System.Collections.Generic;

class MainClass {
  public static void Main (string[] args){
    /*User user = new User("ed", "17/08/1997", "edneyosf", "123");
    MyData.addUser(user);
    List<User> data = MyData.getUsers();

    foreach(User u in data){
      Console.WriteLine(u.toString());
    }*/

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
          Views.invalidOption("BEM-VINDO");
          break;
      }
    }
  }
}