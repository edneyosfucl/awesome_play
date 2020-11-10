class Episode: Media{

  private int episodesNumber, seasonsNumber;
  private string durationTime, description;

  public Episode(int episodesNumber, int seasonsNumber, string durationTime, string description){
    this.episodesNumber = episodesNumber;
    this.seasonsNumber = seasonsNumber;
    this.durationTime = durationTime;
    this.description = description;
  }

  public int getEpisodesNumber(){
    return episodesNumber;
  }

  public void setEpisodesNumber(int episodesNumber){
    this.episodesNumber = episodesNumber;
  }

  public int getSeasonsNumber(){
    return seasonsNumber;
  }

  public void setSeasonsNumber(int seasonsNumber){
    this.seasonsNumber = seasonsNumber;
  }

  public void setDurationTime(string durationTime){
    this.durationTime = durationTime;
  }

  public string getDurationTime(){
    return durationTime;
  }

  public void setDescription(string description){
    this.description = description;
  }

  public string getDescription(string description){
    return description;
  }
}