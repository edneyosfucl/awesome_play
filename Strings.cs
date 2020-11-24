public static class Strings{
  public static string welcomeTitle = "BEM-VINDO";
  public static string loginTitle = "LOGIN";
  public static string successLogin = "Logado com Sucesso!";
  public static string failLogin = "Login ou Senha Inválido!";
  public static string registerUserTitle = "NOVO USUÁRIO";
  public static string successRegisterUser = "Registrado com sucesso!";
  public static string failRegisterUser = "Este Login já está cadastrado em nosso sistema!";
  public static string addMediaTitle = "NOVA MÍDIA";
  public static string movieAddMediaTitle = "NOVO FILME";
  public static string serieAddMediaTitle = "NOVA SÉRIE";
  public static string animeAddMediaTitle = "NOVO ANIME";
  public static string invalidMedia = "Tipo de mídia inválido!";
  public static string successAddMedia(MediaType type) => getMediaTypeName(type) + " adicionado com sucesso!";
  public static string failAddMedia(MediaType type) => "Falha ao adicionar " + getMediaTypeName(type) + "!";
  public static string editMediaTitle = "EDITAR MÍDIA";
  public static string movieEditMediaTitle = "EDITAR FILME";
  public static string serieEditMediaTitle = "EDITAR SÉRIE";
  public static string animeEditMediaTitle = "EDITAR ANIME";
  public static string successEditMedia(MediaType type) => getMediaTypeName(type) + " editado com sucesso!";
  public static string failEditMedia(MediaType type) => "Falha ao editar " + getMediaTypeName(type) + "!";

  private static string getMediaTypeName(MediaType type){
    string name = "";

    switch(type){
      case MediaType.Movie:
        name = "Filme";
        break;
      case MediaType.Serie:
        name = "Série";
        break;
      case MediaType.Anime:
        name = "Anime";
        break;
    }

    return name;
  }
}