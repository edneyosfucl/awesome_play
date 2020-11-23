class Login{
  
  public Login(){
    string title = "LOGIN";
    User u = Views.login();//Dados do formulário
    User user = null;

    user = MyData.isUserExists(u.getLogin(), u.getPassword());

    if(user != null){
      Views.showMessage(title, "Logado com Sucesso!");
      User.setUser(user);
      new Home();
    }
    else{
      Views.showMessage(title, "Login ou Senha Inválido!");
    }
  }
}