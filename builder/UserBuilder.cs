public class UserBuilder: IUserBuilder{

  private User user = new User(null, null, null, null);

  public UserBuilder(){ }

  public UserBuilder id(int? id){
    user.setId(id);
    return this;
  }

  public UserBuilder nickname(string nickname){
    user.setNickname(nickname);
    return this;
  }

  public UserBuilder birth(string birth){
    user.setBirth(birth);
    return this;
  }

  public UserBuilder login(string login){
    user.setLogin(login);
    return this;
  }

  public UserBuilder password(string password){
    user.setPassword(password);
    return this;
  }

  public User build() => user;
}