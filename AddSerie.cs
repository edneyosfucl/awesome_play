class AddSerie{
  public AddSerie(bool type_anime){
		string title, nomezinho;

		if(type_anime == false){title = "NOVA SÉRIE"; nomezinho = "Série";}
		else{title = "NOVO ANIME"; nomezinho = "Anime";}

		Serie s = Views.addSerie(type_anime);

		if(s != null){
			MyData.addSerie(s);
			Views.showMessage(title, nomezinho+" adicionada com sucesso!");
		}
		else{
			Views.showMessage(title, "Falha ao adicionar "+nomezinho+"!");
		}
  }
}