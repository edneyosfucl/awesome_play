class Login{
  
  public Login(){
    string title = "LOGIN";
    string[] data = Views.login();//Dados do formulário

    string login = data[0];
    string password = data[1];

    bool isExists = MyData.isUserExists(login, password);

    if(isExists == true){
      Views.showMessage(title, "Logado com Sucesso!");
    }
    else{
      Views.showMessage(title, "Login ou Senha Inválido!");
    }

  }
}