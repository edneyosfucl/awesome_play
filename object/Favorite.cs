public class Favorite{
  private int idUser, idMedia;

  public Favorite(int idUser, int idMedia){
    this.idUser = idUser;
    this.idMedia = idMedia;
  }

  public int getIdUser(){
    return idUser;
  }

  public void setIdUser(int idUser){
    this.idUser = idUser;
  }

  public int getIdMedia(){
    return idMedia;
  }

  public void setIdMedia(int idMedia){
    this.idMedia = idMedia;
  }
}