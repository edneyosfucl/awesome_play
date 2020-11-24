using System;
using System.IO;
using System.Collections.Generic;

//Responsável por gerenciar a persistência de dados em arquivo
public static class MyData{

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
    int id = data.Count == 0 ? 0 : (int)data[data.Count - 1].getId();

    u.setId(id);
    u++;
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
    int id = data.Count == 0 ? 0 : (int)data[data.Count - 1].getId();

    m.setId(id);
    m++;
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
    int id = data.Count == 0 ? 0 : (int)data[data.Count - 1].getId();

    
    s.setId(id);
    s++;
    data.Add(s);

    using (Stream stream = File.Open(serieFile, FileMode.Create))
    {
        var formatter = 
          new System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();

        formatter.Serialize(stream, data);
    }
  }

  public static Movie getMovieById(int id){
    List<Movie> data = getMovies();
    Movie movie = null;

    foreach(Movie m in data){
      if(m.getId() == id){
        movie = m;
        break;
      }
    }

    return movie;
  }

  public static bool setMovie(Movie movie){
    List<Movie> data = getMovies();
    bool status = false;

    for(int i = 0; i < data.Count ; i++){
      Movie m = data[i];

      if(m.getId() == movie.getId()){
        data.RemoveAt(i);
        data.Insert(i, movie);
        status = true;
        setMovies(data);
        break;
      }
    }

    return status;
  }

  public static bool removeMovieById(int id){
    List<Movie> data = getMovies();
    bool status = false;

    for(int i = 0; i < data.Count ; i++){
      Movie m = data[i];

      if(m.getId() == id){
        data.RemoveAt(i);
        status = true;
        setMovies(data);
        break;
      }
    }

    return status;
  }

  public static void setMovies(List<Movie> data){
    using (Stream stream = File.Open(movieFile, FileMode.Create))
    {
        var formatter = 
          new System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();

        formatter.Serialize(stream, data);
    }
  }

  public static Serie getSerieById(int id){
    List<Serie> data = getSeries();
    Serie serie = null;

    foreach(Serie s in data){
      if(s.getId() == id){
        serie = s;
        break;
      }
    }

    return serie;
  }

  public static bool setSerie(Serie serie){
    List<Serie> data = getSeries();
    bool status = false;

    for(int i = 0; i < data.Count ; i++){
      Serie s = data[i];

      if(s.getId() == serie.getId()){
        data.RemoveAt(i);
        data.Insert(i, serie);
        status = true;
        setSeries(data);
        break;
      }
    }

    return status;
  }

  public static bool removeSerieById(int id){
    List<Serie> data = getSeries();
    bool status = false;

    for(int i = 0; i < data.Count ; i++){
      Serie s = data[i];

      if(s.getId() == id){
        data.RemoveAt(i);
        status = true;
        setSeries(data);
        break;
      }
    }

    return status;
  }

  public static void setSeries(List<Serie> data){
    using (Stream stream = File.Open(serieFile, FileMode.Create))
    {
        var formatter = 
          new System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();

        formatter.Serialize(stream, data);
    }
  }
}