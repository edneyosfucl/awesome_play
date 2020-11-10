using System;
using System.IO;
using System.Collections.Generic;

//Responsável por gerenciar a persistência de dados em arquivo
class MyData{

  //Nome de arquivo com dados de usuário
  private static string userFile = "user.data";

  //Recupera uma lista de usuários registradas no arquivo user.data
  public static List<User> getUsers(){
    List<User> data = new List<User>();

    if(File.Exists(userFile)){
      using (Stream stream = File.Open(userFile, FileMode.Open))
      {
          var formatter = 
            new System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();

          data = (List<User>)formatter.Deserialize(stream);
      }
    }

    return data;
  }

  //Registra um usuário no arquivo user.data
  public static void addUser(User u){
    List<User> data = getUsers();

    data.Add(u);

    using (Stream stream = File.Open(userFile, FileMode.Create))
    {
        var formatter = 
          new System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();

        formatter.Serialize(stream, data);
    }
  }

  public static bool isUserExists(string login, string pass){
    List<User> data = MyData.getUsers();
    bool isExists = false;

    foreach(User u in data){
      if(pass == null){
        if(login == u.getLogin()){
          isExists = true;
          break;
        }
      }
      else{
        if(login == u.getLogin() && pass == u.getPassword()){
          isExists = true;
          break;
        }
      }
    }

    return isExists;
  }
}