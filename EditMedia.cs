class EditMedia{
  public EditMedia(){
    string title = "EDITAR MÍDIA";
    int mediaTypeOption = Views.editMedia();

    switch(mediaTypeOption){
      case 1:
        new EditMovie();
        break;
      case 2:
				new EditSerie(false);
        break;
      case 3:
				new EditSerie(true);
        break;
      default:
        Views.showMessage(title, "Tipo de mídia inválido!");
        break;
    }
  }
}