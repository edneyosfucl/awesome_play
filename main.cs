using System;
using System.Collections.Generic;

class MainClass {
  public static void Main (string[] args){

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