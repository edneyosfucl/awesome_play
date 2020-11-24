using System;

public class Search: Screen{
  public Search(){
    // int option = Views.search();

    // switch(option){
    //   case 1:
    //     byName();
    //     break;
    //   case 2:
    //     byGender();
    //     break;
    //   case 3:
    //     byType();
    //     break;
    //   default:
    //     Views.invalidOption("Caro "+loggedUser.getNickname());
    //     break;
    // }
    byName();
  }

  private void byName(){
    bool hasFavorite;
    int option;
    string name = Views.searchByName();
    Movie movie = MyData.searchMovieByName(name);
    Serie serie = MyData.searchSerieByName(name);

    if(movie != null){
      hasFavorite = false; //Verificar
      option = Views.showMovie(movie, hasFavorite);
    }
    else if(serie != null){
      hasFavorite = false; //Verificar
      option = Views.showSerie(serie, hasFavorite);
    }
    else{
      hasFavorite = false; //Verificar
      Views.showMessage(title, Strings.noMediaSearch);
      return;
    }

    switch(option){
      case 1:
        EditMedia edit = new EditMedia();
        
        if(movie != null){
          edit.movie(movie);
        }
        else if(serie != null){
          edit.serie(serie, serie.getGender().getType() == MediaType.Anime);
        }
        break;
      case 2:
        //Favorite
        break;
      case 3:
        break;
      default:
        Views.invalidOption("Caro "+loggedUser.getNickname());  
        break;
    }
  }

  // private void byGender(){
  // }

  // private void byType(){
  // }
}