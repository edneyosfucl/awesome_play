public class AddMedia : Screen, Action{

  public AddMedia(){
    title = Strings.addMediaTitle;
    int mediaTypeOption = Views.addMedia();

    switch(mediaTypeOption){
      case 1:
        movie();
        break;
      case 2:
				serie(false);
        break;
      case 3:
				serie(true);
        break;
      default:
        Views.showMessage(title, Strings.invalidMedia);
        break;
    }
  }

  public void movie(){
    string title = Strings.movieAddMediaTitle;
    Movie m = Views.addMovie(false);

    if(m != null){
      MyData.addMovie(m);
      Views.showMessage(title, Strings.successAddMedia(MediaType.Movie));
    }
    else{
      Views.showMessage(title, Strings.failAddMedia(MediaType.Movie));
    }
  }

  public void serie(bool isAnime){
		string title;
    MediaType type;
    Serie s;

		if(isAnime == false){
      title = Strings.serieAddMediaTitle; 
      type = MediaType.Serie;
    }
		else{
      title = Strings.animeAddMediaTitle; 
      type = MediaType.Anime;
    }

		s = Views.addSerie(false, isAnime);

		if(s != null){
			MyData.addSerie(s);
			Views.showMessage(title, Strings.successAddMedia(type));
		}
		else{
			Views.showMessage(title, Strings.failAddMedia(type));
		}
  }
}