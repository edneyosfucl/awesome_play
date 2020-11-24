using System;

[Serializable]
public class User{

  //Singleton
  private static User instance = null;

  private int? id = null;
  private string nickname, login, password, birth = "";

  private User(){ }

  public User(string nickname, string birth, string login, string password){
    this.nickname = nickname;
    this.birth = birth;
    this.login = login;
    this.password = password;
  }

  public static User operator ++(User user){
    user.setId(user.getId() + 1);

    return user;
  }

  public void setId(int? id){
    this.id = id;
  }

  public int? getId() => id;

  public void setNickname(string nickname){
    this.nickname = nickname;
  }

  public string getNickname() => nickname;

  public string getLogin() => login;
  
  public void setLogin(string login){
    this.login = login;
  }

  public void setPassword(string password){
    this.password = password;
  }

  public string getPassword() => password;

  public void setBirth(string birth){
    this.birth = birth;
  }

  public string getBirth() => birth;

  public override string ToString(){
    return "{id="+id.ToString()+", nickname='"+nickname+"', birth='"+birth+"', login='"+login+"', password='"+password+"'}";
  }

  public static void setUser(User u) => instance = u;

  public static User getInstance(){
    if (instance == null){
      instance = new UserBuilder()
        .build();
    }

    return instance;
  }
}