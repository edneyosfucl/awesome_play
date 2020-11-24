public class EditMedia: Screen, Action{

  public EditMedia(){
    title = Strings.editMediaTitle;
    int mediaTypeOption = Views.editMedia();

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
    string title = Strings.movieEditMediaTitle;
    Movie m = Views.addMovie(true);

    if(m != null){
      MyData.addMovie(m);
      Views.showMessage(title, Strings.successEditMedia(MediaType.Movie));
    }
    else{
      Views.showMessage(title, Strings.failEditMedia(MediaType.Movie));
    }
  }

  public void serie(bool isAnime){
		string title;
    MediaType type;
    Serie s;

		if(!isAnime){
      title = Strings.serieEditMediaTitle; 
      type = MediaType.Serie;
    }
		else{
      title = Strings.animeEditMediaTitle; 
      type = MediaType.Anime;
    }

    s = Views.addSerie(true, isAnime);

    if(s != null){
      MyData.addSerie(s);
      Views.showMessage(title, Strings.successEditMedia(type));
    }
    else{
      Views.showMessage(title, Strings.failEditMedia(type));
    }
  }
}