class AddMovie{
  public AddMovie(){
    string title = "NOVO FILME";
    Movie m = Views.addMovie(false);

    if(m != null){
      MyData.addMovie(m);
      Views.showMessage(title, "Filme adicionado com sucesso!");
    }
    else{
      Views.showMessage(title, "Falha ao adicionar filme!");
    }
  }
}