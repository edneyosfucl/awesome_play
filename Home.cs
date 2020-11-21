class Home{
  public Home(){
    bool isLogout = false;

    while(!isLogout){
      int optionHome = Views.home(User.get().getNickname());

      switch(optionHome){
        case 1:
          new Search();
          break;
        case 2:
          break;  
        case 3:
          new AddMedia();
          break;  
        case 4:
          isLogout = true;
          User.setUser(null);
          break; 
        default:
          Views.invalidOption("Caro "+User.get().getNickname());
          break;
      }
    }
  }
}