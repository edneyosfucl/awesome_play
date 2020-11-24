using System.Collections.Generic;

public class RegisterUser: Screen{
  public RegisterUser(){
    title = Strings.registerUserTitle;
    User u = Views.register();
    bool isExists = MyData.isUserExists(u.getLogin(), null) != null;

    if(!isExists){
      Views.showMessage(title, Strings.successRegisterUser);
      MyData.addUser(u);    
    }
    else{
      Views.showMessage(title, Strings.failRegisterUser);
    }
  }
}