class RegisterUser{
  
  public RegisterUser(){
    User user = Views.register(); //Dados do formulário
    Views.showMessage("NOVO USUÁRIO", "Registrado com sucesso!");//Remover
  }
}