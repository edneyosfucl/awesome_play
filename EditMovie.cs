class EditMovie{
  public EditMovie(){
    string title = "EDITAR FILME";
    Movie m = Views.addMovie(true);

    if(m != null){
      MyData.addMovie(m);
      Views.showMessage(title, "Filme editado com sucesso!");
    }
    else{
      Views.showMessage(title, "Falha ao editar filme!");
    }
  }
}