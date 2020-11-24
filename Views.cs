using System;

//Responsável por gerenciar as interações do usuário do console com a aplicação
public static class Views{
  
  //Visualização inicial
  public static int init(){
    int data = -1;

    Console.Clear();
    Utils.showAppTitle();
    Console.WriteLine("\n[1] Login");
    Console.WriteLine("[2] Novo usuário\n");
    Utils.showFooter();
    Console.WriteLine("- Escolha uma das opções:\n");

    try{ data = Convert.ToInt32(Console.ReadLine());}
    catch(Exception e){  }

    return data;
  }

  //Visualização de opção inválida
  public static void invalidOption(string title){
    Console.Clear();
    Utils.showAppTitle();
    Console.WriteLine("\n"+title);
    Console.WriteLine("\nOpção inválida!\n");  
    Utils.showFooter();
    Utils.sleep(3);
  }

  //Visualização mensagens
  public static void showMessage(string title, string msg){
    Console.Clear();
    Utils.showAppTitle();
    Console.WriteLine("\n"+title);
    Console.WriteLine("\n"+msg+"\n");  
    Utils.showFooter();
    Utils.sleep(3);
  }

  //Visualização para tela de login
  public static User login(){
    UserBuilder builder = new UserBuilder();
    string login, password;

    Console.Clear();
    Utils.showAppTitle();
    Console.WriteLine("\nLOGIN\n");
    Utils.showFooter();
    Console.WriteLine("- Informe o login de usuário:\n");
    login = Console.ReadLine();
    Console.WriteLine("\n- Infome a senha de usuário:\n");
    password = Utils.passwordConsole();

    return builder
      .login(login)
      .password(password)
      .build();
  }

  //Visualização para tela de registro
  public static User register(){
    UserBuilder builder = new UserBuilder();
    string nickname, birth, login, password;

    Console.Clear();
    Utils.showAppTitle();
    Console.WriteLine("\nNOVO USUÁRIO\n");
    Utils.showFooter();
    Console.WriteLine("- Informe o apelido:\n");
    nickname = Console.ReadLine();
    Console.WriteLine("\n- Informe a data de nascimento:\n");
    birth = Console.ReadLine();
    Console.WriteLine("\n- Informe o login:\n");
    login = Console.ReadLine();
    Console.WriteLine("\n- Informe a Senha:\n");
    password = Console.ReadLine();

    return builder
      .nickname(nickname)
      .birth(birth)
      .login(login)
      .password(password)
      .build();
  }

  //Visualização após a realização do login, para o gerenciamento de mídias
  public static int home(string nickname){
    int data = -1;

    Console.Clear();
    Utils.showAppTitle();
    Console.WriteLine("\nOlá, "+nickname+"!\n");
    Console.WriteLine("\n[1] Pesquisar");
    Console.WriteLine("[2] Favoritos");
    Console.WriteLine("[3] Nova mídia");
    Console.WriteLine("[4] Logout\n");
    Utils.showFooter();
    Console.WriteLine("- Escolha uma das opções:\n");

    try{ data = Convert.ToInt32(Console.ReadLine());}
    catch(Exception e){  }

    return data;
  }

  //Visualização para o cadastro de mídias
  public static int addMedia(){
    int data = -1;

    Console.Clear();
    Utils.showAppTitle();
    Console.WriteLine("\nNOVA MÍDIA\n");
    Console.WriteLine("[1] Filme");
    Console.WriteLine("[2] Serie");
    Console.WriteLine("[3] Anime\n");
    Utils.showFooter();
    Console.WriteLine("- Escolha uma das opções:\n");

    try{ data = Convert.ToInt32(Console.ReadLine());}
    catch(Exception e){  }

    return data;
  }

  public static int editMedia(){
    int data = -1;

    Console.Clear();
    Utils.showAppTitle();
    Console.WriteLine("\nEDITAR MÍDIA\n");
    Console.WriteLine("[1] Filme");
    Console.WriteLine("[2] Serie");
    Console.WriteLine("[3] Anime\n");
    Utils.showFooter();
    Console.WriteLine("- Escolha uma das opções:\n");

    try{ data = Convert.ToInt32(Console.ReadLine()); }
    catch(Exception e){  }

    return data;
  }

  //Visualização para tela de adicionar mídia
  public static Movie addMovie(bool isEdit){
    MovieBuilder builder = new MovieBuilder();
    Movie movie = null;

    Console.Clear();
    Utils.showAppTitle();
    Console.WriteLine("\nNOVO FILME\n");
    Utils.showFooter();

    try{
      string name, description, link, durationTime, gender;
      int classification;

      Console.WriteLine("- Informe o nome:\n");
      name = Console.ReadLine();

      Console.WriteLine("\n- Informe a descrição:\n");
      description = Console.ReadLine();

      Console.WriteLine("\n- Informe a classificação (0, 10, 12, 14, 16 ou 18):\n");
      classification = Convert.ToInt32(Console.ReadLine());

      Console.WriteLine("\n- Informe o link da imagem de capa:\n");
      link = Console.ReadLine();

      Console.WriteLine("\n- Informe a duração (ex: 1h 20min):\n");
      durationTime = Console.ReadLine();

      Console.WriteLine("\n- Informe o gênero:\n");
      gender = Console.ReadLine();

      movie = builder
        .name(name)
        .description(description)
        .classification(classification)
        .link(link)
        .gender(new Gender(MediaType.Movie, gender))
        .durationTime(durationTime)
        .build();
    }
    catch(Exception e){ }

    return movie;
  }

	public static Serie addSerie(bool isEdit, bool type_anime){
    SerieBuilder builder = new SerieBuilder();
		MediaType media_type;
		string title;
    Serie serie = null;
		
    if(type_anime == false){
      media_type = MediaType.Serie; 
      title = "NOVA SÉRIE";
    }
		else{
      media_type = MediaType.Anime; 
      title = "NOVO ANIME";
    }

    Console.Clear();
    Utils.showAppTitle();
    Console.WriteLine("\n"+title+"\n");
    Utils.showFooter();

    try{
      string name, description, link, gender;
      int classification, num_episodes, num_seasons;

      Console.WriteLine("- Informe o nome:\n");
      name = Console.ReadLine();

      Console.WriteLine("\n- Informe a descrição:\n");
      description = Console.ReadLine();

      Console.WriteLine("\n- Informe a classificação (0, 10, 12, 14, 16 ou 18):\n");
      classification = Convert.ToInt32(Console.ReadLine());

      Console.WriteLine("\n- Informe o link da imagem de capa:\n");
      link = Console.ReadLine();

      Console.WriteLine("\n- Informe o número de episódios:\n");
      num_episodes = Convert.ToInt32(Console.ReadLine());
      
			Console.WriteLine("\n- Informe o número de temporadas:\n");
      num_seasons = Convert.ToInt32(Console.ReadLine());

      Console.WriteLine("\n- Informe o gênero:\n");
      gender = Console.ReadLine();

      serie = builder
        .name(name)
        .description(description)
        .classification(classification)
        .link(link)
        .gender(new Gender(media_type, gender))
        .numSeasons(num_seasons)
        .numEpisodes(num_episodes)
        .build();
    }
    catch(Exception e){ }

    return serie;
  }

  public static int search(){
    int data = -1;

    Console.Clear();
    Utils.showAppTitle();
    Console.WriteLine("\nBUSCAR MÍDIA\n");
    Console.WriteLine("\n[1] Por nome");
    Console.WriteLine("[2] Por gênero");
    Console.WriteLine("[3] Por tipo\n");
    Utils.showFooter();
    Console.WriteLine("- Escolha uma das opções:\n");

    try{ data = Convert.ToInt32(Console.ReadLine());}
    catch(Exception e){  }

    return data;
  }

  public static string searchByName(){
    string name = "";

    Console.Clear();
    Utils.showAppTitle();
    Console.WriteLine("\nBUSCAR MÍDIA - Por nome\n");
    Utils.showFooter();
    Console.WriteLine("\n- Nome da mídia:\n");
    name = Console.ReadLine();

    return name;
  }
}