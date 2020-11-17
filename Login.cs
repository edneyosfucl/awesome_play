class Login{
  
  public Login(){
    string title = "LOGIN";
    string[] data = Views.login();//Dados do formulário
    string login = data[0];
    string password = data[1];
    User user = null;

    user = MyData.isUserExists(login, password);

    if(user != null){
      Views.showMessage(title, "Logado com Sucesso!");
      new Home(user);
    }
    else{
      Views.showMessage(title, "Login ou Senha Inválido!");
    }
  }
}