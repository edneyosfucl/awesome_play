using System;
using System.IO;
using System.Collections.Generic;

//Responsável por gerenciar a persistência de dados em arquivo
class MyData{

  //Nome de arquivo com dados de usuário
  private static string userFile = "user.data";

  //Nome de arquivo com dados dos filmes
  private static string movieFile = "movie.data";
  
	//Nome de arquivo com dados das séries
  private static string serieFile = "serie.data";

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

  public static User isUserExists(string login, string pass){
    List<User> data = MyData.getUsers();
    User user = null;


    foreach(User u in data){
      if(pass == null){
        if(login == u.getLogin()){
          user = u;
          break;
        }
      }
      else{
        if(login == u.getLogin() && pass == u.getPassword()){
          user = u;
          break;
        }
      }
    }

    return user;
  }

  //Recupera uma lista de filmes registradas no arquivo movie.data
  public static List<Movie> getMovies(){
    List<Movie> data = new List<Movie>();

    if(File.Exists(movieFile)){
      using (Stream stream = File.Open(movieFile, FileMode.Open))
      {
          var formatter = 
            new System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();

          data = (List<Movie>)formatter.Deserialize(stream);
      }
    }

    return data;
  }

  //Registra um filme no arquivo movie.data
  public static void addMovie(Movie m){
    List<Movie> data = getMovies();

    data.Add(m);

    using (Stream stream = File.Open(movieFile, FileMode.Create))
    {
        var formatter = 
          new System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();

        formatter.Serialize(stream, data);
    }
  }

	  //Recupera uma lista de filmes registradas no arquivo serie.data
  public static List<Serie> getSeries(){
    List<Serie> data = new List<Serie>();

    if(File.Exists(serieFile)){
      using (Stream stream = File.Open(serieFile, FileMode.Open))
      {
          var formatter = 
            new System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();

          data = (List<Serie>)formatter.Deserialize(stream);
      }
    }

    return data;
  }

  //Registra um filme no arquivo serie.data
  public static void addSerie(Serie s){
    List<Serie> data = getSeries();

    data.Add(s);

    using (Stream stream = File.Open(serieFile, FileMode.Create))
    {
        var formatter = 
          new System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();

        formatter.Serialize(stream, data);
    }
  }

}