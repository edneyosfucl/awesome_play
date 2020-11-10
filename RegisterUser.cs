using System.Collections.Generic;

class RegisterUser{
  
  public RegisterUser(){
    string title = "NOVO USUÁRIO";
    User user = Views.register(); //Dados do formulário
    bool isExists = MyData.isUserExists(user.getLogin(), null);

    if(isExists == true){
      Views.showMessage(title, "Este Login já está cadastrado em nosso sistema.");
    }
    else{
      Views.showMessage(title, "Registrado com sucesso!");//Remover
      MyData.addUser(user);
    }
  }
}