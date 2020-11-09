class Serie:Media{
  
  private int numEpisodes, numSeasons;
  private Gender gender;

  public Serie(int numEpisodes, int numSeasons, Gender gender){
    this.numEpisodes = numEpisodes;
    this.numSeasons = numSeasons;
    this.gender = gender;
  }

  public int getNumEpisodes(){
    return numEpisodes;
  }

  public void setNumEpisodes(int numEpisodes){
    this.numEpisodes = numEpisodes;
  }

  public int getNumSeasons(){
    return numSeasons;
  }

  public void setNumSeasons(int numSeasons){
    this.numSeasons = numSeasons;
  }

  public Gender getGender(){
    return gender;
  }

  public void setGender(Gender gender){
    this.gender = gender;
  }
}