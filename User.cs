using System;

[Serializable]
class User{

  //Singleton
  private static User instance = null;

  private int id = 0;
  private string nickname, login, password, birth = "";

  private User(){ }

  public User(string nickname, string birth, string login, string password){
    this.nickname = nickname;
    this.birth = birth;
    this.login = login;
    this.password = password;
  }

  public int getId(){
    return id;
  }

  public void setId(int id){
    this.id = id;
  }

  public string getNickname(){
    return nickname;
  }

  public void setNickname(string nickname){
    this.nickname = nickname;
  }

  public string getLogin(){
    return login;
  }
  
  public void setLogin(string login){
    this.login = login;
  }

  public string getPassword(){
    return password;
  }

  public void setPassword(string password){
    this.password = password;
  }

  public string getBirth(){
    return birth;
  }

  public void setBirth(string birth){
    this.birth = birth;
  }
  
  public string toString(){
    return "{id="+id.ToString()+", nickname='"+nickname+"', birth='"+birth+"', login='"+login+"', password='"+password+"'}";
  }

  public static void setUser(User u){ instance = u; }

  public static User get(){
    if (instance == null){
      instance = new User();
    }

    return instance;
  }
}