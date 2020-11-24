public class Search: Screen{
  public Search(){
    int option = Views.search();

    switch(option){
      case 1:
        byName();
        break;
      case 2:
        byGender();
        break;
      case 3:
        byType();
        break;
      default:
        Views.invalidOption("Caro "+loggedUser.getNickname());
        break;
    }
  }

  private void byName(){
    string name = Views.searchByName();

  }

  private void byGender(){

  }

  private void byType(){

  }
}