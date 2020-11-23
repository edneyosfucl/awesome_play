class AddMedia : Action{

  public AddMedia(){
    title = "NOVA MÍDIA";
    int mediaTypeOption = Views.addMedia();

    switch(mediaTypeOption){
      case 1:
        new AddMovie();
        break;
      case 2:
				new AddSerie(false);
        break;
      case 3:
				new AddSerie(true);
        break;
      default:
        Views.showMessage(title, "Tipo de mídia inválido!");
        break;
    }
  }
}