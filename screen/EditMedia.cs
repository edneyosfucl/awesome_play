public class EditMedia: Screen, Action{

  public EditMedia(){
    title = Strings.editMediaTitle;
  }

  public void movie(Movie movie){
    string title = Strings.movieEditMediaTitle;
    Movie m = Views.addMovie(movie);

    if(m != null){
      MyData.setMovie(m);
      Views.showMessage(title, Strings.successEditMedia(MediaType.Movie));
    }
    else{
      Views.showMessage(title, Strings.failEditMedia(MediaType.Movie));
    }
  }

  public void serie(Serie serie, bool isAnime){
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

    s = Views.addSerie(serie, isAnime);

    if(s != null){
      MyData.setSerie(s);
      Views.showMessage(title, Strings.successEditMedia(type));
    }
    else{
      Views.showMessage(title, Strings.failEditMedia(type));
    }
  }
}