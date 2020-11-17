class AddMedia{
  public AddMedia(){
    string title = "NOVA MÍDIA";
    int mediaTypeOption = Views.addMedia();

    switch(mediaTypeOption){
      case 1:
        new AddMovie();
        break;
      case 2:
        break;
      case 3:
        break;
      default:
        Views.showMessage(title, "Tipo de mídia inválido!");
        break;
    }
  }
}