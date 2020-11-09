class Movie:Media {

  private string durationTime;
  private Gender gender;

  public Movie(){
    
  }

  public Movie(string durationTime, Gender gender){
    this.durationTime = durationTime;
    this.gender = gender;
  }

  public string getDurationTime(){
    return durationTime;
  }

  public void setDurationTime(string durationTime){
    this.durationTime = durationTime;
  }

  public Gender getGender(){
    return gender;
  }

  public void setGender(Gender gender){
    this.gender = gender;
  }
}