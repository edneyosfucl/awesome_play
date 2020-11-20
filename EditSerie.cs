class EditSerie{
  public EditSerie(bool isAnime){
		string title, name;

		if(!isAnime){
      title = "EDITAR SÉRIE"; 
      name = "Série";
    }
		else{
      title = "EDITAR ANIME"; 
      name = "Anime";
    }

    Serie s = Views.addSerie(true, isAnime);

    if(s != null){
      MyData.addSerie(s);
      Views.showMessage(title, name+" editado com sucesso!");
    }
    else{
      Views.showMessage(title, "Falha ao editar "+name+"!");
    }
  }
}