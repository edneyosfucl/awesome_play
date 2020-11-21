class Search{
  public Search(){
    int option = Views.search();
    switch(option){
      case 1:
        break;
      case 2:
        break;
      case 3:
        break;
      default:
        Views.invalidOption("Caro "+User.get().getNickname());
        break;
    }
  }
}