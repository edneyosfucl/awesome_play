public class Login: Screen{
  public Login(){
    title = Strings.loginTitle;
    User u = Views.login();
    User user = null;

    user = MyData.isUserExists(u.getLogin(), u.getPassword());

    if(user != null){
      Views.showMessage(title, Strings.successLogin);
      User.setUser(user);
      new Home();
    }
    else{
      Views.showMessage(title, Strings.failLogin);
    }
  }
}