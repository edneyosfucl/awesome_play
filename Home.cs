class Home{
  public Home(User user){
    bool isLogout = false;

    while(!isLogout){
      int optionHome = Views.home(user.getNickname());

      switch(optionHome){
        case 1:
          break;
        case 2:
          break;  
        case 3:
          break;  
        case 4:
          break;  
        case 5:
          break;  
        case 6:
          isLogout = true;
          break; 
        default:
          Views.invalidOption("Caro "+user.getNickname());
          break;
      }
    }
  }
}